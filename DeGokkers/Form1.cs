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

            pictureBox1.Parent = pictureBoxMain;
            pictureBox1.BackColor = Color.Transparent;

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
            int numberofplayers = 3;
            Guy[] playerarray = new Guy[numberofplayers];

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
        {
            bool radiobutton1_CheckedChanged = true;
            bool radioButton2_CheckedChanged = true;
            bool radioButton3_CheckedChanged = true;

            if (radiobutton1.Checked)
            {
                
                object nmr_inzet = null;
                int inzet1 = (int)numericUpDown1.Value;
                int wed1 = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed1 = null;
                label5.Text = "Speler 1 heeft €" + inzet1 + " op cheetah nummer " + wed1 + " ingezet";
                //label8.Text = "Sietse heeft: € " + Guy.GuyArray.playerarray[1]

                //guyArray[1].Totalamount;

            }

            if (radioButton2.Checked)
            {
                object nmr_inzet2 = null;
                int inzet2 = (int)numericUpDown1.Value;
                int wed2 = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed2 = null;
                label6.Text = "Speler 2 heeft €" + inzet2 + " op cheetah nummer " + wed2 + " ingezet";
                this.label9.Text = "Peter heeft: €...";
            }

            if (radioButton3.Checked)
            {
                object nmr_inzet3 = null;
                int inzet3 = (int)numericUpDown1.Value;
                int wed3 = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed3 = null;
                label7.Text = "Speler 3 heeft €" + inzet3 + " op cheetah nummer " + wed3 + " ingezet";
                this.label10.Text = "Fer heeft: €...";
            }

            

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

                object nmr_inzet = null;
                int inzet1 = (int)numericUpDown1.Value;
                int wed1 = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed1 = null;
                label5.Text = "Speler 1 heeft €" + inzet1 + " op cheetah nummer " + wed1 + " ingezet";
                //label8.Text = "Sietse heeft: € " + Guy.GuyMain();
            }

            if (radioButton2.Checked)
            {
                object nmr_inzet2 = null;
                int inzet2 = (int)numericUpDown1.Value;
                int wed2 = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed2 = null;
                label6.Text = "Speler 2 heeft €" + inzet2 + " op cheetah nummer " + wed2 + " ingezet";
                //this.label9.Text = "Peter heeft: €. " +;
            }

            if (radioButton3.Checked)
            {
                object nmr_inzet3 = null;
                int inzet3 = (int)numericUpDown1.Value;
                int wed3 = Convert.ToInt32(numericUpDown2.Value);
                object lbl_wed3 = null;
                label7.Text = "Speler 3 heeft €" + inzet3 + " op cheetah nummer " + wed3 + " ingezet";
                //this.label10.Text = "Fer heeft: € " +;
            }
        }
    }
}
