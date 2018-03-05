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

        int GuyNumber = 1;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Parent = pictureBoxMain;
            pictureBox1.BackColor = Color.Transparent;

            button2.Enabled = false;
            GuyArray();
        }

        public void Resetanimals()
        {
            string message = "De race is afgelopen, wilt u een nieuwe ronden starten?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

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

            CollectBets(1);
        }

        public void CollectBets(int winnerAnimal)
        {
            for (int i = 0; i < playerarray.Length; i++)
            {
                playerarray[i].Collect(winnerAnimal);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            radiobutton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            button1.Enabled = false;

            int GuyNumber = 1;

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
                //MessageBox.Show("Nummer 1 heeft gewonnen.", MessageBoxButtons.YesNo, == DialogResult.Yes);    
                // Initializes the variables to pass to the MessageBox.Show method.

                Resetanimals();
            }

            if (pictureBox2.Location.X >= 800)
            {
                MessageBox.Show("Nummer 2 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.

                Resetanimals();
            }

            if (pictureBox3.Location.X >= 800)
            {
                MessageBox.Show("Nummer 3 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.

                Resetanimals();
            }

            if (pictureBox4.Location.X >= 800)
            {
                MessageBox.Show("Nummer 4 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "De race is afgelopen, wilt u een nieuwe ronden starten?";
                string caption = "Error Detected In Input.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

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

            if (pictureBox5.Location.X >= 800)
            {
                MessageBox.Show("Nummer 5 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.

                Resetanimals();
            }

            if (pictureBox6.Location.X >= 800)
            {
                MessageBox.Show("Nummer 6 heeft gewonnen.");
                // Initializes the variables to pass to the MessageBox.Show method.

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = true;
            bool radiobutton1_CheckedChanged = true;
            bool radioButton2_CheckedChanged = true;
            bool radioButton3_CheckedChanged = true;

            if (radiobutton1.Checked)
            {

                //object nmr_BetAmount = null;
                playerarray[1].BetAmount = (int)numericUpDown1.Value;
                playerarray[1].AnimalBet = Convert.ToInt32(numericUpDown2.Value);
                //object lbl_AnimalBet = null;
                label5.Text = "Speler 1 heeft €" + playerarray[1].BetAmount + " op cheetah nummer " + playerarray[1].AnimalBet + " ingezet";
                label8.Text = "Sietse heeft: € " + playerarray[1].TotalAmount;
            }

            if (radioButton2.Checked)
            {
                object nmr_BetAmount = null;
                playerarray[2].BetAmount = (int)numericUpDown1.Value;
                playerarray[2].AnimalBet = Convert.ToInt32(numericUpDown2.Value);
                object lbl_AnimalBet = null;
                label6.Text = "Speler 2 heeft €" + playerarray[2].BetAmount + " op cheetah nummer " + playerarray[2].AnimalBet + " ingezet";
                this.label9.Text = "Peter heeft: €" + playerarray[2].TotalAmount;
            }

            if (radioButton3.Checked)
            {
                object nmr_inzet3 = null;
                playerarray[3].BetAmount = (int)numericUpDown1.Value;
                playerarray[3].AnimalBet = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed3 = null;
                label7.Text = "Speler 3 heeft €" + playerarray[3].BetAmount + " op cheetah nummer " + playerarray[3].AnimalBet + " ingezet";
                this.label10.Text = "Fer heeft: €" + playerarray[3].TotalAmount;
            }
        }
    }
}
