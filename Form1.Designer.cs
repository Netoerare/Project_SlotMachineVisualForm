namespace SlotMachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtStake = new System.Windows.Forms.TextBox();
            this.timerSpin = new System.Windows.Forms.Timer(this.components);
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnFruits = new System.Windows.Forms.Button();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.Jewels = new System.Windows.Forms.Button();
            this.btnNumbers = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AnimatedLvr = new System.Windows.Forms.PictureBox();
            this.AnimationTimer_Tick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimatedLvr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(199, 429);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(57, 16);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Balance";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(316, 47);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // txtStake
            // 
            this.txtStake.Location = new System.Drawing.Point(74, 426);
            this.txtStake.Name = "txtStake";
            this.txtStake.Size = new System.Drawing.Size(100, 22);
            this.txtStake.TabIndex = 5;
            this.txtStake.TextChanged += new System.EventHandler(this.txtStake_TextChanged);
            // 
            // timerSpin
            // 
            this.timerSpin.Enabled = true;
            this.timerSpin.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSpin
            // 
            this.btnSpin.AutoSize = true;
            this.btnSpin.BackColor = System.Drawing.Color.Transparent;
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpin.ForeColor = System.Drawing.Color.Black;
            this.btnSpin.Image = global::SlotMachine.Properties.Resources.Lever0;
            this.btnSpin.Location = new System.Drawing.Point(550, 137);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(45, 145);
            this.btnSpin.TabIndex = 6;
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click_1);
            // 
            // btnFruits
            // 
            this.btnFruits.BackColor = System.Drawing.Color.Transparent;
            this.btnFruits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFruits.ForeColor = System.Drawing.Color.Transparent;
            this.btnFruits.Image = global::SlotMachine.Properties.Resources.DarkRed_Beautiful_Sunset_Thank_You_Watching_Youtube_Video__6__removebg_preview;
            this.btnFruits.Location = new System.Drawing.Point(309, 391);
            this.btnFruits.Name = "btnFruits";
            this.btnFruits.Size = new System.Drawing.Size(71, 74);
            this.btnFruits.TabIndex = 7;
            this.btnFruits.UseVisualStyleBackColor = false;
            this.btnFruits.Click += new System.EventHandler(this.btnFruits_Click_1);
            // 
            // btnAnimals
            // 
            this.btnAnimals.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnimals.Image = global::SlotMachine.Properties.Resources.bluedog;
            this.btnAnimals.Location = new System.Drawing.Point(386, 391);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(74, 74);
            this.btnAnimals.TabIndex = 8;
            this.btnAnimals.UseVisualStyleBackColor = false;
            this.btnAnimals.Click += new System.EventHandler(this.button1_Click);
            // 
            // Jewels
            // 
            this.Jewels.BackColor = System.Drawing.Color.Transparent;
            this.Jewels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Jewels.Image = global::SlotMachine.Properties.Resources.DarkRed_Beautiful_Sunset_Thank_You_Watching_Youtube_Video__4__removebg_preview;
            this.Jewels.Location = new System.Drawing.Point(466, 391);
            this.Jewels.Name = "Jewels";
            this.Jewels.Size = new System.Drawing.Size(75, 74);
            this.Jewels.TabIndex = 9;
            this.Jewels.UseVisualStyleBackColor = false;
            this.Jewels.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNumbers
            // 
            this.btnNumbers.BackColor = System.Drawing.Color.Transparent;
            this.btnNumbers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumbers.ForeColor = System.Drawing.Color.Transparent;
            this.btnNumbers.Image = global::SlotMachine.Properties.Resources.DarkRed_Beautiful_Sunset_Thank_You_Watching_Youtube_Video__5__removebg_preview;
            this.btnNumbers.Location = new System.Drawing.Point(547, 391);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(75, 74);
            this.btnNumbers.TabIndex = 10;
            this.btnNumbers.UseVisualStyleBackColor = false;
            this.btnNumbers.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(419, 239);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 69);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(338, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 69);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(252, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AnimatedLvr
            // 
            this.AnimatedLvr.BackColor = System.Drawing.Color.Transparent;
            this.AnimatedLvr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AnimatedLvr.Image = global::SlotMachine.Properties.Resources.Lever;
            this.AnimatedLvr.Location = new System.Drawing.Point(468, 137);
            this.AnimatedLvr.Name = "AnimatedLvr";
            this.AnimatedLvr.Size = new System.Drawing.Size(203, 234);
            this.AnimatedLvr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AnimatedLvr.TabIndex = 13;
            this.AnimatedLvr.TabStop = false;
            this.AnimatedLvr.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // AnimationTimer_Tick
            // 
            this.AnimationTimer_Tick.Tick += new System.EventHandler(this.AnimationTimer_Tick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlotMachine.Properties.Resources.Finalebackground_8_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 518);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.AnimatedLvr);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnNumbers);
            this.Controls.Add(this.Jewels);
            this.Controls.Add(this.btnAnimals);
            this.Controls.Add(this.btnFruits);
            this.Controls.Add(this.txtStake);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimatedLvr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtStake;
        private System.Windows.Forms.Timer timerSpin;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnFruits;
        private System.Windows.Forms.Button btnAnimals;
        private System.Windows.Forms.Button Jewels;
        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.PictureBox AnimatedLvr;
        private System.Windows.Forms.Timer AnimationTimer_Tick;
    }
}

