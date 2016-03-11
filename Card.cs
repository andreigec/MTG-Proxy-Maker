using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using ANDREICSLIB;
using ANDREICSLIB.ClassExtras;

namespace MTGProxyMaker
{
    public enum PrintModes
    {
        Minimal, BlackAndWhite, Colour
    }

    public enum SearchType
    {
        Name,MultiverseID
    }

    public class MinimalOptions
    {
        public bool Expansion;
        public bool Rarity;
        public bool Flavour;
    }

    public class CardHolder
    {
        public static string ImageFolder = "Images";
        public Card C;
        public Bitmap CardImage;

        public CardHolder(Card c, int count)
        {
            C = c;
            Count = count;
        }

        public int Count;

        private static string GetImageFilename(Card c, PrintModes pm)
        {
            switch (pm)
            {
                case PrintModes.Minimal:
                    return Path.Combine(ImageFolder, c.ID.ToString() + ".min.jpg");
                case PrintModes.BlackAndWhite:
                    return Path.Combine(ImageFolder, c.ID.ToString() + ".bw.jpg");
                case PrintModes.Colour:
                    return Path.Combine(ImageFolder, c.ID.ToString() + ".col.jpg");
            }

            return null;
        }

        private void SetImage(PrintModes pm)
        {
            var fn = GetImageFilename(C, pm);
            using (var i = (Bitmap)Image.FromFile(fn))
            {
                CardImage = new Bitmap(i);
            }
        }

        public void GetAndSetImages(PrintModes pm, MinimalOptions mo)
        {
            //download first if necessary
            //colour
            var pathColour = GetImageFilename(C, PrintModes.Colour);
            if (File.Exists(pathColour) == false)
                NetExtras.DownloadFile(C.ImgURL, pathColour);

            //black and white
            var pathBw = GetImageFilename(C, PrintModes.BlackAndWhite);
            if (File.Exists(pathBw) == false)
            {
                Bitmap bw;
                using (var i = (Bitmap)Image.FromFile(pathColour))
                {
                    bw = BitmapExtras.ApplyGrayscale(new Bitmap(i));
                }

                bw.Save(pathBw);
            }

            //minimal - always generate in case options have changed - todo - do properly
            var minpath = GetImageFilename(C, PrintModes.Minimal);
            if (File.Exists(minpath))
                File.Delete(minpath);

            var m = MinimalCardControl.Show(C, mo);
            var min = new Bitmap(m.Width, m.Height);
            m.DrawToBitmap(min, new Rectangle(0, 0, m.Width, m.Height));
            min.Save(minpath);

            SetImage(pm);
        }
    }

    public class Card
    {
        public int? ID = null;
        public string ImgURL;
        public string Name;
        public string Cost;
        public string Types;
        public string NewestExpansion;
        public string Text;
        public string FlavourText;
        public string PT;
        public string Rarity;
    }
}
