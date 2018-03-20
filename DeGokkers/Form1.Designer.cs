namespace DeGokkers
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player1 = new System.Windows.Forms.RadioButton();
            this.Player2 = new System.Windows.Forms.RadioButton();
            this.Player3 = new System.Windows.Forms.RadioButton();
            this.BetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Player1Status = new System.Windows.Forms.Label();
            this.Player2Status = new System.Windows.Forms.Label();
            this.Player3Status = new System.Windows.Forms.Label();
            this.MoneyBet = new System.Windows.Forms.NumericUpDown();
            this.Animalbet = new System.Windows.Forms.NumericUpDown();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.Player1Money = new System.Windows.Forms.Label();
            this.Player2Money = new System.Windows.Forms.Label();
            this.Player3Money = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Animalbet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(214, 540);
            this.Player1.Margin = new System.Windows.Forms.Padding(2);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(54, 17);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = true;
            this.Player1.Text = "Sietse";
            this.Player1.UseVisualStyleBackColor = true;
            this.Player1.CheckedChanged += new System.EventHandler(this.radiobutton1_CheckedChanged);
            this.Player1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radiobutton1_MouseClick);
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(214, 561);
            this.Player2.Margin = new System.Windows.Forms.Padding(2);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(50, 17);
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = true;
            this.Player2.Text = "Peter";
            this.Player2.UseVisualStyleBackColor = true;
            this.Player2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.Player2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3.Location = new System.Drawing.Point(214, 582);
            this.Player3.Margin = new System.Windows.Forms.Padding(2);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(37, 17);
            this.Player3.TabIndex = 2;
            this.Player3.TabStop = true;
            this.Player3.Text = "fer";
            this.Player3.UseVisualStyleBackColor = true;
            this.Player3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.Player3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton3_MouseClick);
            // 
            // BetButton
            // 
            this.BetButton.Location = new System.Drawing.Point(214, 630);
            this.BetButton.Margin = new System.Windows.Forms.Padding(2);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(56, 21);
            this.BetButton.TabIndex = 4;
            this.BetButton.Text = "Bet";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.button1_Click);
            this.BetButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 614);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min $5 max $100000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 634);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Op:";
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.Image = ((System.Drawing.Image)(resources.GetObject("GoButton.Image")));
            this.GoButton.Location = new System.Drawing.Point(667, 622);
            this.GoButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(86, 27);
            this.GoButton.TabIndex = 13;
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.button2_Click);
            this.GoButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 498);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "betting agency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(663, 502);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Betting";
            // 
            // Player1Status
            // 
            this.Player1Status.AutoSize = true;
            this.Player1Status.Location = new System.Drawing.Point(615, 540);
            this.Player1Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1Status.Name = "Player1Status";
            this.Player1Status.Size = new System.Drawing.Size(146, 13);
            this.Player1Status.TabIndex = 18;
            this.Player1Status.Text = "Sietse hasn\'t placed a bet yet";
            this.Player1Status.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // Player2Status
            // 
            this.Player2Status.AutoSize = true;
            this.Player2Status.Location = new System.Drawing.Point(619, 561);
            this.Player2Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2Status.Name = "Player2Status";
            this.Player2Status.Size = new System.Drawing.Size(142, 13);
            this.Player2Status.TabIndex = 19;
            this.Player2Status.Text = "Peter hasn\'t placed a bet yet";
            this.Player2Status.TextChanged += new System.EventHandler(this.label6_TextChanged);
            // 
            // Player3Status
            // 
            this.Player3Status.AutoSize = true;
            this.Player3Status.Location = new System.Drawing.Point(629, 582);
            this.Player3Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player3Status.Name = "Player3Status";
            this.Player3Status.Size = new System.Drawing.Size(132, 13);
            this.Player3Status.TabIndex = 20;
            this.Player3Status.Text = "Fer hasn\'t placed a bet yet";
            this.Player3Status.TextChanged += new System.EventHandler(this.label7_TextChanged);
            this.Player3Status.Click += new System.EventHandler(this.label7_Click);
            // 
            // MoneyBet
            // 
            this.MoneyBet.Location = new System.Drawing.Point(275, 630);
            this.MoneyBet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MoneyBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MoneyBet.Name = "MoneyBet";
            this.MoneyBet.Size = new System.Drawing.Size(120, 20);
            this.MoneyBet.TabIndex = 21;
            this.MoneyBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MoneyBet.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Animalbet
            // 
            this.Animalbet.Location = new System.Drawing.Point(429, 630);
            this.Animalbet.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Animalbet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Animalbet.Name = "Animalbet";
            this.Animalbet.Size = new System.Drawing.Size(120, 20);
            this.Animalbet.TabIndex = 22;
            this.Animalbet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::DeGokkers.Properties.Resources.Jachtluipaard;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(75, 329);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(76, 48);
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::DeGokkers.Properties.Resources.Jachtluipaard;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(75, 273);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(76, 48);
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::DeGokkers.Properties.Resources.Jachtluipaard;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(75, 219);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 48);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DeGokkers.Properties.Resources.Jachtluipaard;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(75, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 48);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DeGokkers.Properties.Resources.Jachtluipaard;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(75, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 48);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DeGokkers.Properties.Resources.Jachtluipaard;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(74, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 48);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackgroundImage = global::DeGokkers.Properties.Resources.running_game1;
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMain.Location = new System.Drawing.Point(-1, -3);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(969, 434);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMain.TabIndex = 16;
            this.pictureBoxMain.TabStop = false;
            // 
            // Player1Money
            // 
            this.Player1Money.AutoSize = true;
            this.Player1Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Money.Location = new System.Drawing.Point(272, 540);
            this.Player1Money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1Money.Name = "Player1Money";
            this.Player1Money.Size = new System.Drawing.Size(68, 13);
            this.Player1Money.TabIndex = 38;
            this.Player1Money.Text = "Sietse has: €";
            // 
            // Player2Money
            // 
            this.Player2Money.AutoSize = true;
            this.Player2Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Money.Location = new System.Drawing.Point(272, 563);
            this.Player2Money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2Money.Name = "Player2Money";
            this.Player2Money.Size = new System.Drawing.Size(64, 13);
            this.Player2Money.TabIndex = 39;
            this.Player2Money.Text = "Peter has: €";
            this.Player2Money.Click += new System.EventHandler(this.label9_Click);
            // 
            // Player3Money
            // 
            this.Player3Money.AutoSize = true;
            this.Player3Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3Money.Location = new System.Drawing.Point(271, 584);
            this.Player3Money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player3Money.Name = "Player3Money";
            this.Player3Money.Size = new System.Drawing.Size(54, 13);
            this.Player3Money.TabIndex = 40;
            this.Player3Money.Text = "Fer has: €";
            this.Player3Money.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(426, 615);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Cheetah 1 to 6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Total bet:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(962, 720);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Player3Money);
            this.Controls.Add(this.Player2Money);
            this.Controls.Add(this.Player1Money);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Animalbet);
            this.Controls.Add(this.MoneyBet);
            this.Controls.Add(this.Player3Status);
            this.Controls.Add(this.Player2Status);
            this.Controls.Add(this.Player1Status);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetButton);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeGokkers";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Animalbet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Player1;
        private System.Windows.Forms.RadioButton Player2;
        private System.Windows.Forms.RadioButton Player3;
        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label Player1Status;
        private System.Windows.Forms.Label Player2Status;
        private System.Windows.Forms.Label Player3Status;
        private System.Windows.Forms.NumericUpDown MoneyBet;
        private System.Windows.Forms.NumericUpDown Animalbet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Player1Money;
        private System.Windows.Forms.Label Player2Money;
        private System.Windows.Forms.Label Player3Money;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
    }
}


 

