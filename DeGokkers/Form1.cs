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
        int GuyNumber = 1;
        public Form1()
        {
            InitializeComponent();
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
            switch (GuyNumber)
            {
                case 1:
                    label5.Text = "Sietse heeft gewed.";
                    break;

                case 2:
                    label6.Text = "Peter heeft gewed.";
                    break;

                case 3:
                    label7.Text = "Fer heeft gewed.";
                    break;

                default:
                    break;
            }
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
            int testtest = 5;           // dit is een test value!
            int testtest2 = 2;          // dit is een test value!
            label5.Text = "Sietse heeft " + testtest + " gewed op nummer " + testtest2 + "";
            label6.Text = "Peter heeft " + testtest + " gewed op nummer " + testtest2 + "";
            label7.Text = "Fer heeft " + testtest + " gewed op nummer " + testtest2 + "";

            int sietseamounttest = 95;  // dit is een test value!
            int peteramounttest = 95;   // dit is een test value!
            int feramounttest = 95;     // dit is een test value!
            label8.Text = "Sietse heeft €" + sietseamounttest + ",-";
            label9.Text = "Peter heeft €" + peteramounttest + ",-";
            label10.Text = "Fer heeft €" + feramounttest + ",-";













            radiobutton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;

            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            button1.Enabled = false;

            while (pictureBox2.Location.X <= 800 && pictureBox3.Location.X <= 800 && pictureBox4.Location.X <= 800 && pictureBox5.Location.X <= 800 && pictureBox1.Location.X <= 800 && pictureBox6.Location.X <= 800)
            {
                Random rnd = new Random();
                pictureBox2.Location = new Point(pictureBox2.Location.X + rnd.Next(1, 5), pictureBox2.Location.Y);
                pictureBox3.Location = new Point(pictureBox3.Location.X + rnd.Next(1, 5), pictureBox3.Location.Y);
                pictureBox4.Location = new Point(pictureBox4.Location.X + rnd.Next(1, 5), pictureBox4.Location.Y);
                pictureBox5.Location = new Point(pictureBox5.Location.X + rnd.Next(1, 5), pictureBox5.Location.Y);
                pictureBox1.Location = new Point(pictureBox1.Location.X + rnd.Next(1, 5), pictureBox1.Location.Y);
                pictureBox6.Location = new Point(pictureBox6.Location.X + rnd.Next(1, 5), pictureBox6.Location.Y);

                Thread.Sleep(10);
                this.Refresh();
            }

            if (pictureBox1.Location.X >= 700)
            {
                MessageBox.Show("Nummer 1 heeft gewonnen.");
            }

            if (pictureBox2.Location.X >= 700)
            {
                MessageBox.Show("Nummer 2 heeft gewonnen.");
            }

            if (pictureBox3.Location.X >= 700)
            {
                MessageBox.Show("Nummer 3 heeft gewonnen.");
            }

            if (pictureBox4.Location.X >= 700)
            {
                MessageBox.Show("Nummer 4 heeft gewonnen.");
            }

            if (pictureBox5.Location.X >= 700)
            {
                MessageBox.Show("Nummer 5 heeft gewonnen.");
            }

            if (pictureBox6.Location.X >= 700)
            {
                MessageBox.Show("Nummer 6 heeft gewonnen.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
