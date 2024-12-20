using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;
        private readonly Theme theme;

        public Slot(int initialBalance, Theme theme, PictureBox[] pictureBoxes)
        {
            this.theme = theme;
            this.balance = initialBalance;
            this.reels = new Reel[pictureBoxes.Length];

            // Create Reel objects based on the provided theme
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                this.reels[i] = new Reel(pictureBoxes[i], theme);
            }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Stake
        {
            get { return stake; }
            set { stake = value; }
        }

        public void Spin()
        {
            // Spin each reel
            foreach (var reel in reels)
            {
                reel.Spin();
            }

        }

        public int CheckResult()
        {
            Console.WriteLine($"Reel Symbols: {reels[0].SymbolIdentifier}, {reels[1].SymbolIdentifier}, {reels[2].SymbolIdentifier}");

            if (reels[0].SymbolIdentifier == reels[1].SymbolIdentifier && reels[1].SymbolIdentifier == reels[2].SymbolIdentifier)
            {
                Console.WriteLine("Jackpot! All three symbols match.");
                return stake * 10;
            }
            else if (reels[0].SymbolIdentifier == reels[1].SymbolIdentifier || reels[1].SymbolIdentifier == reels[2].SymbolIdentifier || reels[0].SymbolIdentifier == reels[2].SymbolIdentifier)
            {
                Console.WriteLine("Two symbols match.");
                return stake * 2;
            }

            Console.WriteLine("No match.");
            return 0;
        }


        public void UpdateBalance(int winnings)
        {
            Balance += winnings;
        }
    }
}
