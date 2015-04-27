using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.NewControls;
using HtmlAgilityPack;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace MTGProxyMaker
{
	public class MtgController
	{

		public static Form1 baseform;

		public static void SavePDF(List<CardHolder> toprint, string filename)
		{
			const double mult = 0.8;
			const int PDFCardWidth = (int)(223 * mult);
			const int PDFCardHeight = (int)(310 * mult);
			const int marginTop = 60;
			const int marginBottom = 10;
			const int marginLeft = 60;
			const int marginRight = 10;

			var doc = new PdfDocument();
			PdfPage page;
			XGraphics xgr = null;

			var colnum = -1;
			var rownum = 0;
			var pagenum = -1;

			foreach (var ch in toprint)
			{
				for (int c = 0; c < ch.Count; c++)
				{
					colnum++;
					if (colnum == 3)
					{
						colnum = 0;
						rownum++;
					}

					if (rownum == 3 || pagenum == -1)
					{
						rownum = 0;
						pagenum++;
						page = doc.AddPage();
						var size = PageSizeConverter.ToSize(PdfSharp.PageSize.A4);
						page.Width = size.Width;
						page.Height = size.Height;
						page.Orientation = PageOrientation.Portrait;
						page.TrimMargins.Top = marginTop;
						page.TrimMargins.Right = marginRight;
						page.TrimMargins.Bottom = marginBottom;
						page.TrimMargins.Left = marginLeft;
						xgr = XGraphics.FromPdfPage(doc.Pages[pagenum]);
					}

					var r = new Rectangle(colnum * PDFCardWidth, rownum * PDFCardHeight, PDFCardWidth, PDFCardHeight);
					xgr.DrawImage(ch.CardImage, r);
				}
			}

			doc.Save(filename);
			doc.Close();
		}

		private static bool CardInvalid(HtmlDocument hd)
		{
			//invalid id
			var notfoundnodes = hd.DocumentNode.SelectNodes("//span[@class='introheader']");
			return (notfoundnodes != null && notfoundnodes.Count > 0);
		}

		private static CardHolder GetCardByName(string rawCardName)
		{
			try
			{
				var name = GetSanitisedCardName(rawCardName);
				if (name == null)
					return null;

				var hd = DownloadCardWebPage(name.Item1);
				if (CardInvalid(hd))
					return null;

				if (hd != null)
				{
					//see if single card, or multiple - have use choose
					var myCard = IsMulti(hd) ? ChooseMulti(hd) : ScrapeCardDetails(hd);

					return new CardHolder(myCard, name.Item2);
				}
			}
			catch (Exception ex)
			{
			}

			return null;
		}

		private static CardHolder GetCardByID(string rawCardName)
		{
			try
			{
				var hd = DownloadCardWebPage(int.Parse(rawCardName));
				if (CardInvalid(hd))
					return null;

				if (hd != null)
				{
					var myCard = ScrapeCardDetails(hd);
					return new CardHolder(myCard, 1);
				}
			}
			catch (Exception ex)
			{
			}

			return null;
		}

		/// <summary>
		/// returns card names and counts
		/// </summary>
		/// <param name="rawCardNames"></param>
		/// <returns></returns>
		public static List<Tuple<string, int>> GetSanitisedCardNames(string[] rawCardNames)
		{
			var ret = new List<Tuple<string, int>>();

			var namer = new Regex(@"\s*([0-9]+)x?\s+(.*)");
			//download webpage
			foreach (var cr in rawCardNames)
			{
				//trim white space at ends, and merge white space
				string c = StringExtras.MergeWhiteSpace(StringExtras.CleanString(cr));

				int cardCount = 1;
				//try and scrape count
				var matches = namer.Match(c);

				if (matches.Groups.Count == 3)
				{
					cardCount = Int32.Parse(matches.Groups[1].Value);
					c = matches.Groups[2].Value;
				}

				//wrap each word with +[]
				var words = c.Split(null);
				c = words.Aggregate("", (current, w) => current + ("+[" + w + "]"));
				ret.Add(new Tuple<string, int>(c, cardCount));
			}

			return ret;
		}

		public static Tuple<string, int> GetSanitisedCardName(string rawCardName)
		{
			try
			{
				var namer = new Regex(@"\s*([0-9]+)x?\s+(.*)");
				//download webpage
				//trim white space at ends, and merge white space
				string c = StringExtras.MergeWhiteSpace(StringExtras.CleanString(rawCardName));

				int cardCount = 1;
				//try and scrape count
				var matches = namer.Match(c);

				if (matches.Groups.Count == 3)
				{
					cardCount = Int32.Parse(matches.Groups[1].Value);
					c = matches.Groups[2].Value;
				}

				//wrap each word with +[]
				var words = c.Split(null);
				c = words.Aggregate("", (current, w) => current + ("+[" + w + "]"));
				return new Tuple<string, int>(c, cardCount);
			}
			catch (Exception ex)
			{
			}

			return null;
		}

		/// <summary>
		/// return list of cards that didnt get parsed
		/// </summary>
		/// <param name="rawCardNames"></param>
		/// <returns></returns>
		public static void AddCardsToForm(IEnumerable<string> rawCardLines, SearchType st)
		{
			baseform.ResetProgress();
			foreach (var s in rawCardLines)
			{
				CardHolder card = null;
				if (st == SearchType.MultiverseID)
					card = GetCardByID(s);
				else if (st == SearchType.Name)
					card = GetCardByName(s);

				if (card == null)
					continue;

				baseform.AddCardToLV(card);
				baseform.AddProgress();
			}

			baseform.ResetProgress();
		}

		public static Card ChooseMulti(HtmlDocument hd)
		{
			var cn = GetMultiCardNames(hd);
			if (cn == null)
				return null;

			var list = new List<ListViewItem>();
			foreach (var c in cn)
			{
				var lvi = new ListViewItem(c.Item1);
				lvi.SubItems.Add(c.Item2);
				list.Add(lvi);
			}

			var res = selectItemFromListView.ShowDialog("there are multiple choices, choose one", "choose one", list, false, 1);
			var lvi1 = res.SingleOrDefault();
			if (lvi1 == null)
				return null;

			var id = int.Parse(lvi1.SubItems[1].Text);

			var hd2 = DownloadCardWebPage(id);
			return ScrapeCardDetails(hd2);
		}


		private static HtmlDocument DownloadCardWebPage(int cardID)
		{
			try
			{
				return DownloadWebPage(String.Format("http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid={0}", cardID));
			}
			catch (Exception)
			{
			}

			return null;
		}

		private static HtmlDocument DownloadCardWebPage(string cardName)
		{
			try
			{
				var name = DownloadWebPage(String.Format("http://gatherer.wizards.com/Pages/Search/Default.aspx?name={0}", cardName));
				return name;
			}
			catch (Exception)
			{
			}

			return null;
		}

		private static HtmlDocument DownloadWebPage(string url)
		{
			var htmlDoc = new HtmlDocument();

			// There are various options, set as needed
			htmlDoc.OptionFixNestedTags = true;

			WebResponse objResponse;
			WebRequest objRequest = WebRequest.Create(url);

			objResponse = objRequest.GetResponse();

			// filePath is a path to a file containing the html
			htmlDoc.Load(objResponse.GetResponseStream());

			//strip scripts and style
			htmlDoc.DocumentNode.Descendants()
				.Where(n => n.Name == "script" || n.Name == "style")
				.ToList()
				.ForEach(n => n.Remove());

			//replace mana symbols with their name only
			ReplaceChildren(ref htmlDoc, "//img[contains(@src,'type=symbol')]", "<img.*?name=(.+?)&amp;type=symbol.*?>");

			return htmlDoc;
		}

		/// <summary>
		/// html agility helper - replace all children with text from itself
		/// </summary>
		/// <param name="htmlDoc"></param>
		/// <param name="childrenXPath"></param>
		/// <param name="childRegex"></param>
		private static void ReplaceChildren(ref HtmlDocument htmlDoc, string childrenXPath, string childRegex)
		{
			//replace mana cost images
			var symbolParents = htmlDoc.DocumentNode.SelectNodes(childrenXPath);
			var parents = new List<HtmlNode>();
			foreach (var s in symbolParents.Where(s => parents.Contains(s.ParentNode) == false))
			{
				parents.Add(s.ParentNode);
			}

			foreach (var p in parents)
			{
				p.InnerHtml = Regex.Replace(p.InnerHtml, childRegex, "$1");
			}
		}

		private static bool IsMulti(HtmlDocument hd)
		{
			var subtitles = hd.DocumentNode.SelectSingleNode("//div[contains(@id,'nameRow')]");
			return subtitles == null;
		}

		/// <summary>
		/// tuple name,id
		/// </summary>
		/// <param name="hd"></param>
		/// <returns></returns>
		private static List<Tuple<string, string>> GetMultiCardNames(HtmlDocument hd)
		{
			try
			{
				var ret = new List<Tuple<string, string>>();
				foreach (var c in hd.DocumentNode.SelectNodes("//a[contains(@id,'cardTitle')]"))
				{
					var idstr = c.Attributes["href"].Value;
					idstr = idstr.Substring(idstr.LastIndexOf('=') + 1);

					ret.Add(new Tuple<string, string>(c.InnerHtml, idstr));
				}
				return ret;
			}
			catch (Exception)
			{
			}
			return null;
		}

		private static Card ScrapeCardDetails(HtmlDocument hd)
		{
			var c = new Card();

			try
			{
				try
				{
					//image url
					var url1 = hd.DocumentNode.SelectSingleNode("//div[@class='cardImage']/img").Attributes["src"].Value;
					var url2 = "http://gatherer.wizards.com/" + url1.Substring(6);
					c.ImgURL = url2.Replace("&amp;", "&");
				}
				catch { }


				//trim tree for further details
				var h = hd.DocumentNode.SelectSingleNode("//td[contains(@id,'rightCol')]");

				try
				{
					//name
					c.Name = Clean(h.SelectNodes("//div[contains(@id,'nameRow')]/div[@class='value']").First().InnerHtml);
				}
				catch { }

				try
				{
					//mana
					c.Cost = Clean(h.SelectNodes("//div[contains(@id,'manaRow')]/div[@class='value']").First().InnerHtml);
				}
				catch { }

				try
				{
					//type
					c.Types = Clean(h.SelectNodes("//div[contains(@id,'typeRow')]/div[@class='value']").First().InnerHtml);
				}
				catch { }


				try
				{
					//text
					c.Text = Clean(h.SelectNodes("//div[contains(@id,'textRow')]/div[@class='value']/div[@class='cardtextbox']").Select(s => s.InnerHtml).Aggregate((a, b) => a + Environment.NewLine + b));
				}
				catch { }

				try
				{
					//flavour
					c.FlavourText = Clean(h.SelectNodes("//div[@class='flavortextbox']").Select(s => s.InnerHtml).Aggregate((a, b) => a + "," + b));
				}
				catch { }


				try
				{
					//p/t
					c.PT = Clean(h.SelectNodes("//div[contains(@id,'ptRow')]/div[@class='value']").First().InnerHtml);
				}
				catch { }

				try
				{
					//newest set
					c.NewestExpansion = Clean(h.SelectNodes("//div[contains(@id,'setRow')]/div[@class='value']/div/a").Last().InnerHtml);
				}
				catch { }

				try
				{
					//rarity
					c.Rarity = Clean(h.SelectNodes("//div[contains(@id,'rarityRow')]/div[@class='value']/span").First().InnerHtml);
				}
				catch { }

				//id last just to make sure no other errors occured easily
				var id1 = hd.DocumentNode.SelectSingleNode("//form").Attributes["action"].Value;
				c.ID = Int32.Parse(id1.Substring(id1.LastIndexOf("=", StringComparison.Ordinal) + 1));

			}
			catch { }

			if (c.ID == null)
				return null;
			return c;
		}

		private static string Clean(string instr)
		{
			var str1 = StringExtras.CleanString(instr);
			//manually replace weird shit
			str1 = str1.Replace("â€”", "-");
			return str1;
		}
	}
}
