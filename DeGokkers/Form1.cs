using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkers
{
    public partial class Form1 : Form
    {
        int GuyNumber = 0;
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
    }
}
