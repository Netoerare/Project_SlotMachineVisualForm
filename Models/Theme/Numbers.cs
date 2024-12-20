using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Numbers : Theme
    {
        public Numbers(PictureBox pictureBox) : base(pictureBox) { }

        public override Dictionary<string, Image> SymbolImages
        {
            get
            {
                return new Dictionary<string, Image>
            {
                { "7", Properties.Resources._7 },
                { "6", Properties.Resources._6 },
                { "1", Properties.Resources._1 },
                { "2", Properties.Resources._2 }
            };
            }
        }

        public override string[] SymbolIdentifiers
        {
            get
            {
                return new string[] { "7", "6", "1", "2" };
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
