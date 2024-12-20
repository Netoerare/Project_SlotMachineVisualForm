    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace SlotMachine.Models
    {
    public class Reel
    {
        private string symbolIdentifier; // Identifier for the symbol
        private readonly PictureBox pictureBox;
        private readonly Theme theme;
        private static readonly Random random = new Random();

        public Reel(PictureBox pictureBox, Theme theme)
        {
            this.theme = theme;
            this.pictureBox = pictureBox;
            this.pictureBox.Paint += Reel_Paint;
            this.symbolIdentifier = theme.SymbolIdentifiers[random.Next(theme.SymbolIdentifiers.Length)];
        }

        public string SymbolIdentifier
        {
            get => symbolIdentifier;
            set
            {
                symbolIdentifier = value;
                pictureBox.Invalidate(); // Redraw the PictureBox
            }
        }

        private void Reel_Paint(object sender, PaintEventArgs e)
        {
            if (SymbolIdentifier != null)
            {
                var symbolImage = theme.GetSymbolImage(SymbolIdentifier);
                e.Graphics.DrawImage(symbolImage, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            }
        }

        public void Spin()
        {
            // Randomly select a symbol identifier for the reel
            SymbolIdentifier = theme.SymbolIdentifiers[random.Next(theme.SymbolIdentifiers.Length)];
        }
    }



}
