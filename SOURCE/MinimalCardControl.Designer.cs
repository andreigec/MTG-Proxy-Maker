namespace MTGProxyMaker
{
    partial class MinimalCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinimalCardControl));
            this.CardName = new System.Windows.Forms.TextBox();
            this.cardMana = new System.Windows.Forms.TextBox();
            this.cardTypes = new System.Windows.Forms.TextBox();
            this.expansion = new System.Windows.Forms.TextBox();
            this.rarity = new System.Windows.Forms.TextBox();
            this.textTB = new System.Windows.Forms.TextBox();
            this.flavourTB = new System.Windows.Forms.TextBox();
            this.ptTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardName
            // 
            this.CardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.CardName.Location = new System.Drawing.Point(3, 3);
            this.CardName.MaximumSize = new System.Drawing.Size(210, 0);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(210, 23);
            this.CardName.TabIndex = 0;
            this.CardName.Text = "Test Name";
            // 
            // cardMana
            // 
            this.cardMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardMana.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardMana.Location = new System.Drawing.Point(3, 22);
            this.cardMana.MaximumSize = new System.Drawing.Size(210, 0);
            this.cardMana.Name = "cardMana";
            this.cardMana.Size = new System.Drawing.Size(210, 20);
            this.cardMana.TabIndex = 1;
            this.cardMana.Text = "test: 2RRR";
            // 
            // cardTypes
            // 
            this.cardTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardTypes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTypes.Location = new System.Drawing.Point(3, 44);
            this.cardTypes.MaximumSize = new System.Drawing.Size(210, 0);
            this.cardTypes.Name = "cardTypes";
            this.cardTypes.Size = new System.Drawing.Size(210, 20);
            this.cardTypes.TabIndex = 2;
            this.cardTypes.Text = "Instant";
            // 
            // expansion
            // 
            this.expansion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expansion.Font = new System.Drawing.Font("Calibri", 8F);
            this.expansion.Location = new System.Drawing.Point(3, 70);
            this.expansion.MaximumSize = new System.Drawing.Size(120, 0);
            this.expansion.Name = "expansion";
            this.expansion.Size = new System.Drawing.Size(120, 14);
            this.expansion.TabIndex = 3;
            this.expansion.Text = "test expansion";
            // 
            // rarity
            // 
            this.rarity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rarity.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rarity.Location = new System.Drawing.Point(136, 70);
            this.rarity.MaximumSize = new System.Drawing.Size(80, 0);
            this.rarity.Name = "rarity";
            this.rarity.Size = new System.Drawing.Size(80, 14);
            this.rarity.TabIndex = 4;
            this.rarity.Text = "test rarity";
            this.rarity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textTB
            // 
            this.textTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTB.Location = new System.Drawing.Point(3, 90);
            this.textTB.MaximumSize = new System.Drawing.Size(210, 0);
            this.textTB.MinimumSize = new System.Drawing.Size(0, 110);
            this.textTB.Multiline = true;
            this.textTB.Name = "textTB";
            this.textTB.Size = new System.Drawing.Size(210, 110);
            this.textTB.TabIndex = 5;
            this.textTB.Text = resources.GetString("textTB.Text");
            // 
            // flavourTB
            // 
            this.flavourTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flavourTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flavourTB.Location = new System.Drawing.Point(3, 208);
            this.flavourTB.MaximumSize = new System.Drawing.Size(210, 0);
            this.flavourTB.MinimumSize = new System.Drawing.Size(0, 60);
            this.flavourTB.Multiline = true;
            this.flavourTB.Name = "flavourTB";
            this.flavourTB.Size = new System.Drawing.Size(210, 66);
            this.flavourTB.TabIndex = 6;
            this.flavourTB.Text = "Flashback 4Red (You may cast this card from your graveyard for its flashback cost" +
    ". Then exile it.)";
            // 
            // ptTB
            // 
            this.ptTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptTB.Location = new System.Drawing.Point(113, 280);
            this.ptTB.MaximumSize = new System.Drawing.Size(205, 0);
            this.ptTB.Name = "ptTB";
            this.ptTB.Size = new System.Drawing.Size(95, 20);
            this.ptTB.TabIndex = 7;
            this.ptTB.Text = "10/10";
            this.ptTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flavourTB);
            this.panel1.Controls.Add(this.CardName);
            this.panel1.Controls.Add(this.textTB);
            this.panel1.Controls.Add(this.ptTB);
            this.panel1.Controls.Add(this.cardMana);
            this.panel1.Controls.Add(this.cardTypes);
            this.panel1.Controls.Add(this.expansion);
            this.panel1.Controls.Add(this.rarity);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 306);
            this.panel1.TabIndex = 0;
            // 
            // MinimalCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Name = "MinimalCardControl";
            this.Size = new System.Drawing.Size(223, 310);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.TextBox cardMana;
        private System.Windows.Forms.TextBox cardTypes;
        private System.Windows.Forms.TextBox expansion;
        private System.Windows.Forms.TextBox rarity;
        private System.Windows.Forms.TextBox textTB;
        private System.Windows.Forms.TextBox flavourTB;
        private System.Windows.Forms.TextBox ptTB;
        private System.Windows.Forms.Panel panel1;
    }
}
