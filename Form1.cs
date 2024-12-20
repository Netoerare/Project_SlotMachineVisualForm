using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using SlotMachine.Models;
using System.Media;
using System.IO;
namespace SlotMachine

{
    public partial class Form1 : Form
    {
        private Timer animationTimer;
        private Slot slotMachine;
        private int spinTimeElapsed = 0;
        private Slot currentSlot;
        private PictureBox[] pictureBoxes;
        public Form1()
        {
            InitializeComponent();

            // Initialize the PictureBoxes
            pictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3 };

            // Initialize Slot machine with a default theme
            Theme initialTheme = new Animals(pictureBoxes[0]);
            slotMachine = new Slot(1000, initialTheme, pictureBoxes);

            lblBalance.Text = "Balance: P" + slotMachine.Balance;

            // Initialize the timer and ensure it is disabled
            timerSpin = new Timer
            {
                Interval = 100, // Adjust as needed
                Enabled = false // Ensure it doesn't start automatically
            };
            timerSpin.Tick += timer1_Tick;
            animationTimer = new Timer
            {
                Interval = 900 // Set to 1 second (1000 milliseconds)
            };
            animationTimer.Tick += AnimationTimer_Tick_Tick;
            AnimatedLvr.Visible = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       

        // Method to change the theme and reinitialize the Slot and Reels
        private void ChangeTheme(Theme newTheme)
        {
            if (pictureBoxes == null || newTheme == null)
            {
                MessageBox.Show("Error: Theme or PictureBoxes not initialized.");
                return;
            }

            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Image = null;
            }

            slotMachine = new Slot(slotMachine.Balance, newTheme, pictureBoxes);
            lblBalance.Text = "Balance: P" + slotMachine.Balance;
            
        }


        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!btnSpin.Enabled) // Ensure this runs only during an active spin
            {
                spinTimeElapsed += timerSpin.Interval;
                slotMachine.Spin();

                if (spinTimeElapsed >= 5000) // Stop after 2 seconds
                {
                    timerSpin.Stop();
                    spinTimeElapsed = 0;
                    btnSpin.Enabled = true;

                    int winnings = slotMachine.CheckResult();
                    slotMachine.UpdateBalance(winnings);

                    if (winnings > 0)
                    {
                        SoundPlayer player = new SoundPlayer(Properties.Resources.Cashh);
                        player.Play();

                        lblResult.Text = $"🎉 WIN! You earned P{winnings} 🎉";
                        lblResult.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblResult.Text = "No luck this time!";
                        lblResult.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btnSpin_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtStake.Text, out int stake) && stake > 0 && stake <= slotMachine.Balance)
            {
                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                btnSpin.Enabled = false;    
                lblResult.Text = "";
                AnimatedLvr.Image = Properties.Resources.Lever; // Replace with your GIF resource name
                animationTimer.Start();
                spinTimeElapsed = 0;        
                timerSpin.Start();          
            }
            else
            {
                MessageBox.Show("Please enter a valid stake amount (between 1 and your balance).");
            }
            AnimatedLvr.Visible = true;
            

        }

        private void btnFruits_Click_1(object sender, EventArgs e)
        {
            ChangeTheme(new Fruits(pictureBox1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
               ChangeTheme(new Animals(pictureBox1)); //Animals
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeTheme(new Jewels(pictureBox1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeTheme(new Numbers(pictureBox1));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtStake_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnimationTimer_Tick_Tick(object sender, EventArgs e)
        {
            animationTimer.Stop(); // Stop the animation timer
            AnimatedLvr.Visible = false;
        }

        
    }
}
