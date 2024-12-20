using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Animals : Theme
    {
        public Animals(PictureBox pictureBox) : base(pictureBox) { }

        public override Dictionary<string, Image> SymbolImages
        {
            get
            {
                return new Dictionary<string, Image>
                {
                    { "dog", Properties.Resources.dog },
                    { "cat", Properties.Resources.cat },
                    { "hamster", Properties.Resources.hamster },
                    { "rabbit", Properties.Resources.rabbit }
                };
            }
        }

        public override string[] SymbolIdentifiers
        {
            get
            {
                return new string[] { "dog", "cat", "hamster", "rabbit" };
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
