using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Jewels : Theme
    {
        public Jewels(PictureBox pictureBox) : base(pictureBox) { }

        public override Dictionary<string, Image> SymbolImages
        {
            get
            {
                return new Dictionary<string, Image>
                {
                    { "diamond", Properties.Resources.diamond },
                    { "sapphire", Properties.Resources.sapphire },
                    { "ruby", Properties.Resources.Ruby },
                    { "emerald", Properties.Resources.Emerald }
                };
            }
        }

        public override string[] SymbolIdentifiers
        {
            get
            {
                return new string[] { "diamond", "sapphire", "ruby", "emerald" };
            }
        }

        public override void Reel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(((PictureBox)sender).BackColor);
            if (SymbolIdentifiers != null)
            {
                var symbolImage = GetSymbolImage(SymbolIdentifiers[0]);
                e.Graphics.DrawImage(symbolImage, new Rectangle(0, 0, ((PictureBox)sender).Width, ((PictureBox)sender).Height));
            }
        }
    }
}
