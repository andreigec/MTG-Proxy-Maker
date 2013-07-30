using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTGProxyMaker
{
    public partial class MinimalCardControl : UserControl
    {
        private MinimalCardControl()
        {
            InitializeComponent();
        }

        public static MinimalCardControl Show(Card c, MinimalOptions mo)
        {
            var cc = new MinimalCardControl();

            try
            {
                cc.CardName.Text = c.Name;
                cc.cardMana.Text = "Cost:" + c.Cost;
                cc.cardTypes.Text = c.Types;
                cc.expansion.Text = mo.Expansion ? c.NewestExpansion : "";
                cc.rarity.Text = mo.Rarity ? c.Rarity : "";
                cc.textTB.Text = c.Text;
                cc.flavourTB.Text = mo.Flavour ? c.FlavourText : "";
                cc.ptTB.Text = c.PT;
            }
            catch (Exception)
            {

            }
            return cc;
        }
    }
}
