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

            button2.Enabled = false;
        }

        public void Resetanimals()
        {
            string message = "De race is afgelopen, wilt u een nieuwe ronden starten?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            label5.Text = "Sietse heeft nog niet gewed";
            label6.Text = "Peter heeft nog niet gewed";
            label7.Text = "Fer heeft nog niet gewed";

            label8.Text = "Sietse heeft: €...";
            label9.Text = "Peter heeft: €...";
            label10.Text = "fer heeft: €...";

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                pictureBox1.Location = new Point(75, 50);
                pictureBox2.Location = new Point(75, 106);
                pictureBox3.Location = new Point(75, 161);
                pictureBox4.Location = new Point(75, 219);
                pictureBox5.Location = new Point(75, 273);
                pictureBox6.Location = new Point(75, 329);

                radiobutton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                button1.Enabled = true;
            }

            else if (result == System.Windows.Forms.DialogResult.No)
            {
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }

        public void GuyArray()
        {
            playerarray = new Guy[numberofplayers];

            for (int i = 0; i < numberofplayers; i++)
            {
                playerarray[i] = new Guy();
            }
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
            radiobutton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            button1.Enabled = false;

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

                Thread.Sleep(10);
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
        {/*
            bool radiobutton1_CheckedChanged = true;
            bool radioButton2_CheckedChanged = true;
            bool radioButton3_CheckedChanged = true;

            if (radiobutton1.Checked)
            {

                object nmr_inzet = null;
                playerarray[1].BetAmount = (int)numericUpDown1.Value;
                playerarray[1].AnimalBet = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed1 = null;
                label5.Text = "Speler 1 heeft €" + playerarray[1].BetAmount + " op cheetah nummer " + playerarray[1].AnimalBet + " ingezet";
                label8.Text = "Sietse heeft: € " + playerarray[1].TotalAmount;
            }

            if (radioButton2.Checked)
            {
                object nmr_inzet2 = null;
                playerarray[2].BetAmount = (int)numericUpDown1.Value;
                playerarray[2].AnimalBet = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed2 = null;
                label6.Text = "Speler 2 heeft €" + playerarray[2].BetAmount + " op cheetah nummer " + playerarray[2].AnimalBet + " ingezet";
                label9.Text = "Peter heeft: €" + playerarray[2].TotalAmount;
            }

            if (radioButton3.Checked)
            {
                object nmr_inzet3 = null;
                playerarray[3].BetAmount = (int)numericUpDown1.Value;
                playerarray[3].AnimalBet = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed3 = null;
                label7.Text = "Speler 3 heeft €" + playerarray[3].BetAmount + " op cheetah nummer " + playerarray[3].AnimalBet + " ingezet";
                label10.Text = "Fer heeft: €" + playerarray[3].TotalAmount;
            }*/
        }

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
            button2.Enabled = true;
            bool radiobutton1_CheckedChanged = true;
            bool radioButton2_CheckedChanged = true;
            bool radioButton3_CheckedChanged = true;

            if (radiobutton1.Checked)
            {
                playerarray[1].BetAmount = (int)numericUpDown1.Value;
                TotalBet += (int)numericUpDown1.Value;
                playerarray[1].AnimalBet = Convert.ToInt32(numericUpDown2.Value);
                label5.Text = "Speler 1 heeft €" + playerarray[1].BetAmount + " op cheetah nummer " + playerarray[1].AnimalBet + " ingezet";
                label8.Text = "Sietse heeft: € " + playerarray[1].TotalAmount;
            }

            if (radioButton2.Checked)
            {
                object nmr_BetAmount = null;
                playerarray[2].BetAmount = (int)numericUpDown1.Value;
                TotalBet += (int)numericUpDown1.Value;
                playerarray[2].AnimalBet = Convert.ToInt32(numericUpDown2.Value);
                object lbl_AnimalBet = null;
                label6.Text = "Speler 2 heeft €" + playerarray[2].BetAmount + " op cheetah nummer " + playerarray[2].AnimalBet + " ingezet";
                this.label9.Text = "Peter heeft: €" + playerarray[2].TotalAmount;
            }

            if (radioButton3.Checked)
            {
                object nmr_inzet3 = null;
                playerarray[3].BetAmount = (int)numericUpDown1.Value;
                TotalBet += (int)numericUpDown1.Value;
                playerarray[3].AnimalBet = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed3 = null;
                label7.Text = "Speler 3 heeft €" + playerarray[3].BetAmount + " op cheetah nummer " + playerarray[3].AnimalBet + " ingezet";
                this.label10.Text = "Fer heeft: €" + playerarray[3].TotalAmount;
            }
        }
    }
}
