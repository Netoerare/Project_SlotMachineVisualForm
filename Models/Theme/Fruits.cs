using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Fruits : Theme
    {
        public Fruits(PictureBox pictureBox) : base(pictureBox) { }

        public override Dictionary<string, Image> SymbolImages
        {
            get
            {
                return new Dictionary<string, Image>
                {
                    { "apple", Properties.Resources.Apple },
                    { "cherry", Properties.Resources.Cherry },
                    { "grape", Properties.Resources.Grape },
                    { "orange", Properties.Resources.Orange },
                    { "melon", Properties.Resources.Melon }
                };
            }
        }

        public override string[] SymbolIdentifiers
        {
            get
            {
                return new string[] { "apple", "cherry", "grape", "orange", "melon" };
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
