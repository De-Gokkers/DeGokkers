using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DeGokkers
{
    public partial class Form1 : Form
    {

        int numberofplayers = 3;
        Guy[] playerarray;

        int go = 0;
        int GuyNumber = 1;
        public static int TotalBet = 0;

        public static int AnimalWinner;

        public static int AmountBedsnr1 = 0;
        public static int AmountBedsnr2 = 0;
        public static int AmountBedsnr3 = 0;
        public static int AmountBedsnr4 = 0;
        public static int AmountBedsnr5 = 0;
        public static int AmountBedsnr6 = 0;


        public Form1()
        {
            InitializeComponent();

            GoButton.Enabled = true;

            playerarray = new Guy[3];
            playerarray[0] = new Guy();
            playerarray[1] = new Guy();
            playerarray[2] = new Guy();

            Changeplayerstatus();
        }

        public void Changeplayerstatus()
        {
            Player1Money.Text = "Sietse heeft: €" + playerarray[0].TotalAmount;
            Player2Money.Text = "Peter heeft: €" + playerarray[1].TotalAmount;
            Player3Money.Text = "fer heeft: €" + playerarray[2].TotalAmount;
        }

        public void Resetanimals()
        {
            string message = "De race is afgelopen, wilt u een nieuwe ronden starten?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            Player1Status.Text = "Sietse heeft nog niet gewed";
            Player2Status.Text = "Peter heeft nog niet gewed";
            Player3Status.Text = "Fer heeft nog niet gewed";

            Changeplayerstatus();

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                pictureBox1.Location = new Point(75, 50);
                pictureBox2.Location = new Point(75, 106);
                pictureBox3.Location = new Point(75, 161);
                pictureBox4.Location = new Point(75, 219);
                pictureBox5.Location = new Point(75, 273);
                pictureBox6.Location = new Point(75, 329);

                Player1.Enabled = true;
                Player2.Enabled = true;
                Player3.Enabled = true;
                MoneyBet.Enabled = true;
                Animalbet.Enabled = true;
                BetButton.Enabled = true;

                for(int i = 0; i < playerarray.Length; i++)
                {
                    playerarray[i].NumberOfBets();
                }

                for (int i = 0; i < playerarray.Length; i++)
                {
                    playerarray[i].Collect();
                }

                Changeplayerstatus();
            }

            else if (result == System.Windows.Forms.DialogResult.No)
            {
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }

        public void GuyArray()
        {
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void radiobutton1_MouseClick(object sender, MouseEventArgs e)
        {
            GuyNumber = 1;
        }

        public void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            GuyNumber = 2;
        }

        public void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            GuyNumber = 3;
        }

        public void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_Click(object sender, EventArgs e)
        {
            
        }

        private void domainUpDown2_Click(object sender, EventArgs e)
        {

        }

        private void radiobutton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player1.Enabled = false;
            Player2.Enabled = false;
            Player3.Enabled = false;
            
            MoneyBet.Enabled = false;
            Animalbet.Enabled = false;
            BetButton.Enabled = false;

            int GuyNumber = 1;
            int go = 1;

            while (pictureBox2.Location.X <= 800 && pictureBox3.Location.X <= 800 && pictureBox4.Location.X <= 800 && pictureBox5.Location.X <= 800 && pictureBox1.Location.X <= 800 && pictureBox6.Location.X <= 800)
            {
                Random rnd = new Random();
                pictureBox1.Location = new Point(pictureBox1.Location.X + rnd.Next(1, 5), pictureBox1.Location.Y);
                pictureBox2.Location = new Point(pictureBox2.Location.X + rnd.Next(1, 5), pictureBox2.Location.Y);
                pictureBox3.Location = new Point(pictureBox3.Location.X + rnd.Next(1, 5), pictureBox3.Location.Y);
                pictureBox4.Location = new Point(pictureBox4.Location.X + rnd.Next(1, 5), pictureBox4.Location.Y);
                pictureBox5.Location = new Point(pictureBox5.Location.X + rnd.Next(1, 5), pictureBox5.Location.Y);
                pictureBox6.Location = new Point(pictureBox6.Location.X + rnd.Next(1, 5), pictureBox6.Location.Y);

                Thread.Sleep(50);
                this.Refresh();
            }


            if (pictureBox1.Location.X >= 800)
            {
                MessageBox.Show("Nummer 1 heeft gewonnen.");
                //MessageBox.Show("Nummer 1 heeft gewonnen.", MessageBoxButtons.YesNo, == DialogResult.Yes);    
                // Initializes the variables to pass to the MessageBox.Show method.
                AnimalWinner = 1;
                Resetanimals();
            }

            if (pictureBox2.Location.X >= 800)
            {
                MessageBox.Show("Nummer 2 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.
                AnimalWinner = 2;
                Resetanimals();
            }

            if (pictureBox3.Location.X >= 800)
            {
                MessageBox.Show("Nummer 3 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.
                AnimalWinner = 3;
                Resetanimals();
            }

            if (pictureBox4.Location.X >= 800)
            {
                MessageBox.Show("Nummer 4 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.
                AnimalWinner = 4;
                Resetanimals();
            }

            if (pictureBox5.Location.X >= 800)
            {
                MessageBox.Show("Nummer 5 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.
                AnimalWinner = 5;

                Resetanimals();
            }

            if (pictureBox6.Location.X >= 800)
            {
                MessageBox.Show("Nummer 6 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.
                AnimalWinner = 6;

                Resetanimals();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        { }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)

        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GoButton.Enabled = true;
            bool radiobutton1_CheckedChanged = true;
            bool radioButton2_CheckedChanged = true;
            bool radioButton3_CheckedChanged = true;

            if (Player1.Checked)
            {
                playerarray[0].BetAmount = (int)MoneyBet.Value;
                if(playerarray[0].BetAmount >= playerarray[0].TotalAmount)
                {
                    playerarray[0].BetAmount = 5;
                }

                TotalBet += (int)MoneyBet.Value;
                playerarray[0].AnimalBet = Convert.ToInt32(Animalbet.Value);
                Player1Status.Text = "Speler 1 heeft €" + playerarray[0].BetAmount + " op cheetah nummer " + playerarray[0].AnimalBet + " ingezet";
                Player1Money.Text = "Sietse heeft: €" + playerarray[0].TotalAmount;
            }

            if (Player2.Checked)
            {
                playerarray[1].BetAmount = (int)MoneyBet.Value;
                if (playerarray[1].BetAmount >= playerarray[1].TotalAmount)
                {
                    playerarray[1].BetAmount = 5;
                }
                TotalBet += (int)MoneyBet.Value;
                playerarray[1].AnimalBet = Convert.ToInt32(Animalbet.Value);
                Player2Status.Text = "Speler 2 heeft €" + playerarray[1].BetAmount + " op cheetah nummer " + playerarray[1].AnimalBet + " ingezet";
                this.Player2Money.Text = "Peter heeft: €" + playerarray[1].TotalAmount;
            }

            if (Player3.Checked)
            {
                playerarray[2].BetAmount = (int)MoneyBet.Value;
                if (playerarray[2].BetAmount >= playerarray[2].TotalAmount)
                {
                    playerarray[2].BetAmount = 5;
                }
                TotalBet += (int)MoneyBet.Value;
                playerarray[2].AnimalBet = Convert.ToInt32(Animalbet.Value);
                Player3Status.Text = "Speler 3 heeft €" + playerarray[2].BetAmount + " op cheetah nummer " + playerarray[2].AnimalBet + " ingezet";
                this.Player3Money.Text = "Fer heeft: €" + playerarray[2].TotalAmount;
            }
        }
    }
}
