using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public abstract class Theme
    {
        private readonly Dictionary<string, Image> symbolImages; // Map identifiers to images
        private readonly PictureBox pictureBox;

        public abstract Dictionary<string, Image> SymbolImages { get; }
        public abstract string[] SymbolIdentifiers { get; } // Array of symbol identifiers

        public Theme(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.symbolImages = SymbolImages;
            this.pictureBox.Paint += Reel_Paint;
        }

        public Image GetSymbolImage(string identifier)
        {
            return symbolImages.TryGetValue(identifier, out var image) ? image : null;
        }

        public abstract void Reel_Paint(object sender, PaintEventArgs e);
    }


}

