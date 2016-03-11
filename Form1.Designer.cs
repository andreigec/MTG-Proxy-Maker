namespace MTGProxyMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimalOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newestExpansionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newestExpansionRarityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flavourTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.EnteredCards = new System.Windows.Forms.ListView();
            this.CardID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardrightclick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchType = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintType = new System.Windows.Forms.ComboBox();
            this.ExportB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPDFOnExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dontSaveOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveCardSearchTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cardrightclick.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.minimalOptionsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // minimalOptionsToolStripMenuItem
            // 
            this.minimalOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newestExpansionToolStripMenuItem,
            this.newestExpansionRarityToolStripMenuItem,
            this.flavourTextToolStripMenuItem});
            this.minimalOptionsToolStripMenuItem.Name = "minimalOptionsToolStripMenuItem";
            this.minimalOptionsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.minimalOptionsToolStripMenuItem.Text = "Minimal Options";
            // 
            // newestExpansionToolStripMenuItem
            // 
            this.newestExpansionToolStripMenuItem.Checked = true;
            this.newestExpansionToolStripMenuItem.CheckOnClick = true;
            this.newestExpansionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newestExpansionToolStripMenuItem.Name = "newestExpansionToolStripMenuItem";
            this.newestExpansionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.newestExpansionToolStripMenuItem.Text = "Newest Expansion";
            // 
            // newestExpansionRarityToolStripMenuItem
            // 
            this.newestExpansionRarityToolStripMenuItem.Checked = true;
            this.newestExpansionRarityToolStripMenuItem.CheckOnClick = true;
            this.newestExpansionRarityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newestExpansionRarityToolStripMenuItem.Name = "newestExpansionRarityToolStripMenuItem";
            this.newestExpansionRarityToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.newestExpansionRarityToolStripMenuItem.Text = "Newest Expansion Rarity";
            // 
            // flavourTextToolStripMenuItem
            // 
            this.flavourTextToolStripMenuItem.Checked = true;
            this.flavourTextToolStripMenuItem.CheckOnClick = true;
            this.flavourTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flavourTextToolStripMenuItem.Name = "flavourTextToolStripMenuItem";
            this.flavourTextToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.flavourTextToolStripMenuItem.Text = "Flavour Text";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressTSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Progress:";
            // 
            // progressTSSL
            // 
            this.progressTSSL.Name = "progressTSSL";
            this.progressTSSL.Size = new System.Drawing.Size(13, 17);
            this.progressTSSL.Text = "0";
            // 
            // EnteredCards
            // 
            this.EnteredCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnteredCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CardID,
            this.CardName,
            this.CardCount});
            this.EnteredCards.ContextMenuStrip = this.cardrightclick;
            this.EnteredCards.FullRowSelect = true;
            this.EnteredCards.GridLines = true;
            this.EnteredCards.Location = new System.Drawing.Point(0, 20);
            this.EnteredCards.Name = "EnteredCards";
            this.EnteredCards.Size = new System.Drawing.Size(486, 407);
            this.EnteredCards.TabIndex = 10;
            this.EnteredCards.UseCompatibleStateImageBehavior = false;
            this.EnteredCards.View = System.Windows.Forms.View.Details;
            // 
            // CardID
            // 
            this.CardID.Text = "ID";
            // 
            // CardName
            // 
            this.CardName.Text = "Name";
            this.CardName.Width = 138;
            // 
            // CardCount
            // 
            this.CardCount.Text = "Count";
            // 
            // cardrightclick
            // 
            this.cardrightclick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSelectedToolStripMenuItem});
            this.cardrightclick.Name = "cardrightclick";
            this.cardrightclick.Size = new System.Drawing.Size(165, 26);
            this.cardrightclick.Opening += new System.ComponentModel.CancelEventHandler(this.cardrightclick_Opening);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cards";
            // 
            // SearchType
            // 
            this.SearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchType.FormattingEnabled = true;
            this.SearchType.Location = new System.Drawing.Point(6, 446);
            this.SearchType.Name = "SearchType";
            this.SearchType.Size = new System.Drawing.Size(121, 21);
            this.SearchType.TabIndex = 12;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.Location = new System.Drawing.Point(133, 444);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(6, 20);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(388, 407);
            this.SearchBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Card Search";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrintType);
            this.panel1.Controls.Add(this.ExportB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EnteredCards);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(399, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 470);
            this.panel1.TabIndex = 16;
            // 
            // PrintType
            // 
            this.PrintType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrintType.FormattingEnabled = true;
            this.PrintType.Location = new System.Drawing.Point(6, 446);
            this.PrintType.Name = "PrintType";
            this.PrintType.Size = new System.Drawing.Size(121, 21);
            this.PrintType.TabIndex = 18;
            // 
            // ExportB
            // 
            this.ExportB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportB.Location = new System.Drawing.Point(133, 446);
            this.ExportB.Name = "ExportB";
            this.ExportB.Size = new System.Drawing.Size(75, 23);
            this.ExportB.TabIndex = 12;
            this.ExportB.Text = "Export";
            this.ExportB.UseVisualStyleBackColor = true;
            this.ExportB.Click += new System.EventHandler(this.ExportB_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Print Type";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Silver;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(394, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 470);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SearchType);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 470);
            this.panel2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search Type";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPDFOnExportToolStripMenuItem,
            this.saveCardSearchTextBoxToolStripMenuItem,
            this.toolStripSeparator1,
            this.dontSaveOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // openPDFOnExportToolStripMenuItem
            // 
            this.openPDFOnExportToolStripMenuItem.Checked = true;
            this.openPDFOnExportToolStripMenuItem.CheckOnClick = true;
            this.openPDFOnExportToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openPDFOnExportToolStripMenuItem.Name = "openPDFOnExportToolStripMenuItem";
            this.openPDFOnExportToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.openPDFOnExportToolStripMenuItem.Text = "Open PDF on export";
            // 
            // dontSaveOptionsToolStripMenuItem
            // 
            this.dontSaveOptionsToolStripMenuItem.CheckOnClick = true;
            this.dontSaveOptionsToolStripMenuItem.Name = "dontSaveOptionsToolStripMenuItem";
            this.dontSaveOptionsToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.dontSaveOptionsToolStripMenuItem.Text = "Don\'t save options between sessions";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // saveCardSearchTextBoxToolStripMenuItem
            // 
            this.saveCardSearchTextBoxToolStripMenuItem.Checked = true;
            this.saveCardSearchTextBoxToolStripMenuItem.CheckOnClick = true;
            this.saveCardSearchTextBoxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveCardSearchTextBoxToolStripMenuItem.Name = "saveCardSearchTextBoxToolStripMenuItem";
            this.saveCardSearchTextBoxToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.saveCardSearchTextBoxToolStripMenuItem.Text = "Save Card Search Text Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cardrightclick.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel progressTSSL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView EnteredCards;
        private System.Windows.Forms.ColumnHeader CardName;
        private System.Windows.Forms.ColumnHeader CardCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchType;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PrintType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader CardID;
        private System.Windows.Forms.Button ExportB;
        private System.Windows.Forms.ContextMenuStrip cardrightclick;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimalOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newestExpansionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newestExpansionRarityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flavourTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPDFOnExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dontSaveOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveCardSearchTextBoxToolStripMenuItem;
    }
}

