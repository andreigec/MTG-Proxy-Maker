using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.ClassExtras;
using ANDREICSLIB.NewControls;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace MTGProxyMaker
{
    public partial class Form1 : Form
    {
        #region licensing

        private const string AppTitle = "MTG Proxy Maker";
        private const double AppVersion = 0.1;
        private const String HelpString = "";

        private const String UpdatePath = "https://github.com/EvilSeven/MTG-Proxy-Maker/zipball/master";
        private const String VersionPath = "https://raw.github.com/EvilSeven/MTG-Proxy-Maker/master/INFO/version.txt";
        private const String ChangelogPath = "https://raw.github.com/EvilSeven/MTG-Proxy-Maker/master/INFO/changelog.txt";

        private readonly String OtherText =
            @"©" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets © SharpZipLib (http://www.sharpdevelop.net/OpenSource/SharpZipLib/)
";
        #endregion

        private static string configPath = "MTGPM.cfg";

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static HtmlDocument goblinlackey;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MtgController.baseform = this;

            DirectoryExtras.SetCurrentDirectoryToDefault();
            var sd = new Licensing.SolutionDetails(HelpString, AppTitle, AppVersion, OtherText, VersionPath, UpdatePath,
                                                   ChangelogPath);
            Licensing.CreateLicense(this, sd, menuStrip1);
            ResetProgress();

            SearchType.Items.AddRange(Enum.GetValues(typeof(SearchType)).Cast<object>().ToArray());
            SearchType.SelectedIndex = 0;

            PrintType.Items.AddRange(Enum.GetValues(typeof(PrintModes)).Cast<object>().ToArray());
            PrintType.SelectedIndex = 0;
            LoadConfig();

            if (Directory.Exists(CardHolder.ImageFolder) == false)
                Directory.CreateDirectory(CardHolder.ImageFolder);
        }

        public void AddCardToLV(CardHolder ch)
        {
            var c = ch.C;

            if (EnteredCards.Items.ContainsKey(c.ID.ToString()))
                return;

            var lvi = new ListViewItem(c.ID.ToString());
            lvi.Name = c.ID.ToString();
            lvi.SubItems.Add(c.Name);
            //lvi.SubItems.Add(c.Cost);
            //lvi.SubItems.Add(c.Types);
            //lvi.SubItems.Add(c.NewestExpansion);
            //lvi.SubItems.Add(c.Rarity);
            lvi.SubItems.Add(ch.Count.ToString());
            // lvi.SubItems.Add(ch.PrintMode.ToString());
            lvi.Tag = ch;

            EnteredCards.Items.Add(lvi);
        }

        public void SetCardSearchTextbox(string s)
        {
            SearchBox.Text = s;
        }

        public void ResetProgress()
        {
            progressTSSL.Text = "0";
            Application.DoEvents();
        }

        public void AddProgress()
        {
            try
            {
                var v = int.Parse(progressTSSL.Text);
                v++;
                progressTSSL.Text = v.ToString();
                Application.DoEvents();
            }
            catch (Exception)
            {
                progressTSSL.Text = "0";
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var cards = SearchBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            MtgController.AddCardsToForm(cards, GetSearchType());
        }

        public PrintModes GetPrintMode()
        {
            return (PrintModes)Enum.Parse(typeof(PrintModes), PrintType.Text, true);
        }

        public SearchType GetSearchType()
        {
            return (SearchType)Enum.Parse(typeof(SearchType), SearchType.Text, true);
        }

        private void ExportB_Click(object sender, EventArgs e)
        {
            try
            {
                var cardholders = GetCardHolders(GetPrintMode());
                if (cardholders == null || cardholders.Count == 0)
                {
                    MessageBox.Show("no cards found. search for cards first");
                    return;
                }

                var fn = GetImageFilename();
                MtgController.SavePDF(cardholders, fn);
                if (File.Exists(fn) && openPDFOnExportToolStripMenuItem.Checked)
                {
                    Process.Start(fn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error has occured while exporting:" + ex);
            }
        }

        private static string GetImageFilename()
        {
            return DateTime.Now.Ticks.ToString() + ".pdf";
        }

        private List<CardHolder> GetCardHolders(PrintModes pm)
        {
            int failcount = 0;
            int failmax = 10;
            List<CardHolder> i = null;
        tryagain:
            try
            {
                var op = new MinimalOptions()
                {
                    Expansion = newestExpansionToolStripMenuItem.Checked,
                    Flavour = flavourTextToolStripMenuItem.Checked,
                    Rarity = newestExpansionRarityToolStripMenuItem.Checked
                };

                i = EnteredCards.Items.Cast<ListViewItem>().Select(s => s.Tag).Cast<CardHolder>().ToList();
                i.AsParallel().ForAll(s => s.GetAndSetImages(pm, op));
                return i;
            }
            catch (Exception ex)
            {
                if (failcount < failmax)
                {
                    failcount++;
                    Thread.Sleep(100);
                    goto tryagain;
                }
                MessageBox.Show("an error has occured. try again:" + ex);
            }
            return null;
        }

        private void cardrightclick_Opening(object sender, CancelEventArgs e)
        {
            removeSelectedToolStripMenuItem.Enabled = (EnteredCards.SelectedItems.Count != 0);
        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in EnteredCards.SelectedItems)
            {
                EnteredCards.Items.Remove(eachItem);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        public void SaveConfig()
        {
            var savethese1 = new List<Control>();
            var savethese2 = new List<ToolStripItem>();

            if (dontSaveOptionsToolStripMenuItem.Checked)
            {
                savethese2.Add(dontSaveOptionsToolStripMenuItem);
            }
            else
            {
                savethese1.Add(PrintType);
                savethese1.Add(SearchType);
                savethese2.Add(newestExpansionRarityToolStripMenuItem);
                savethese2.Add(newestExpansionToolStripMenuItem);
                savethese2.Add(flavourTextToolStripMenuItem);
                savethese2.Add(openPDFOnExportToolStripMenuItem);
            }

            FormConfigRestore.SaveConfig(this, configPath, savethese1, savethese2);
        }

        public void LoadConfig()
        {
            FormConfigRestore.LoadConfig(this, configPath);
        }
    }

}