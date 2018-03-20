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

            //hier word de go knop uitgeschakeld zodat de wedstrijd niet kan beginnen zonder dat er gegokt is
            GoButton.Enabled = false;


            //hier worden 3 speler aangemaakt
            playerarray = new Guy[3];
            playerarray[0] = new Guy();
            playerarray[1] = new Guy();
            playerarray[2] = new Guy();

            //hierdoor word het totale geldbedrag van elke gokker weergegeven
            Changeplayerstatus();
        }

        public void UpdateTotalamount()
        {
            for (int i = 0; i < playerarray.Length; i++)
            {
                playerarray[i].TotalAmount -= playerarray[i].BetAmount;
            }
        }

        public void UpdateTotalbet()
        {
            for (int i = 0; i < playerarray.Length; i++)
            {
                TotalBet += playerarray[i].BetAmount;
            }
        }


        //deze methode zorgt er voor dat het totale geldbedrag van elke gokker weergegeven
        public void Changeplayerstatus()
        {
            Player1Money.Text = "Sietse has: €" + playerarray[0].TotalAmount;
            Player2Money.Text = "Peter has: €" + playerarray[1].TotalAmount;
            Player3Money.Text = "Fer has: €" + playerarray[2].TotalAmount;
        }

        //deze methode zorgt ervoor dat alle dieren op hun start posities terug worden gezet als de race geeindigd is, 
        //een popup komt dat de race is afgelopen,
        //de gok statussen worden terug gezet naar niet gewed
        //ook word er hie gecheckt of de gene die ingezet hebben hebben gewonnen of niet
        //de radiobuttons van de gokker worden op niet klikbaar gezet als de gokker minder dan 5 euro heeft
        //het geldbedrag word geüpdate van elke gokker
        //het totale ingezette gok bedrag word terug gezet op 0
        //het wed bedrag word na de wedstrijd van elke gokker op 0 terug gezet
        //en als de speler van dit programme besluit om niet verder te spelen en dus als de message box verschijnt en er op no word gedrukt
        //dat het programme afsluit
        public void Resetanimals()
        {
            string message = "The race has ended, do you want to start another round?";
            string caption = "Race ended, number " + AnimalWinner + " has won.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            Player1Status.Text = "Sietse hasn't placed a bet yet.";
            Player2Status.Text = "Peter hasn't placed a bet yet.";
            Player3Status.Text = "Fer hasn't placed a bet yet.";

            Changeplayerstatus();

            //deze if statement zorgt ervoor dat alle dieren op hun start posities terug worden gezet als de race geeindigd is, 
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

                for (int i = 0; i < playerarray.Length; i++)
                {
                    playerarray[i].NumberOfBets();
                }

                for (int i = 0; i < playerarray.Length; i++)
                {
                    playerarray[i].Collect();
                }

                if (playerarray[0].TotalAmount <= 4)
                {
                    Player1.Enabled = false;
                }

                if (playerarray[1].TotalAmount <= 4)
                {
                    Player2.Enabled = false;
                }

                if (playerarray[2].TotalAmount <= 4)
                {
                    Player3.Enabled = false;
                }

                Changeplayerstatus();

                TotalBet = 0;

                label5.Text = "Total bet = €" + TotalBet;

                for (int i = 0; i < playerarray.Length; i++)
                {
                    playerarray[i].BetAmount = 0;
                }
            }

            else if (result == System.Windows.Forms.DialogResult.No)
            {
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < playerarray.Length; i++)
            {
                playerarray[i].Collect(winnerAnimal);
            }
        }

        //in de onderstaande 3 methodes word bijgehouden op welke speler is gedukt om mee te gokken
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


        //in deze methode:
        //worden de radiiobuttons van elke speler op niet klikbaar gezet
        //even als het vakje waar je het gewenste geld bedrag dat je wilt wedden en het vakje van het gewenste wed dier nummer kan invoeren
        //dat de dieren radom tussen 1 en 5 pixels gaan bewegen als er op go word gedrukt
        //dat de wedstrijd tussen de 20 en 30 seconden duurt
        //en er een message box word weergegeven van het die dat heeft gewonnen
        //en dat alle dieren worden terug gezet
        private void button2_Click(object sender, EventArgs e)
        {
            UpdateTotalamount();

            Changeplayerstatus();

            UpdateTotalbet();

            Player1.Enabled = false;
            Player2.Enabled = false;
            Player3.Enabled = false;

            MoneyBet.Enabled = false;
            Animalbet.Enabled = false;
            BetButton.Enabled = false;

            int GuyNumber = 1;
            int go = 1;

            label5.Text = "Total bet = €" + TotalBet;

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
                MessageBox.Show("Number 1 has won.");
                AnimalWinner = 1;
                Resetanimals();
            }

            if (pictureBox2.Location.X >= 800)
            {
                MessageBox.Show("Number 2 has won.");
                AnimalWinner = 2;
                Resetanimals();
            }

            if (pictureBox3.Location.X >= 800)
            {
                MessageBox.Show("Number 3 has won.");
                AnimalWinner = 3;
                Resetanimals();
            }

            if (pictureBox4.Location.X >= 800)
            {
                MessageBox.Show("Number 4 has won.");
                AnimalWinner = 4;
                Resetanimals();
            }

            if (pictureBox5.Location.X >= 800)
            {
                MessageBox.Show("Number 5 has won.");
                AnimalWinner = 5;

                Resetanimals();
            }

            if (pictureBox6.Location.X >= 800)
            {
                MessageBox.Show("Number 6 has won.");
                AnimalWinner = 6;

                Resetanimals();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoButton.Enabled = true;

            //geen idee wat deze drie booleans doen maar ik ben bang om ze weg te halen
            bool radiobutton1_CheckedChanged = true;
            bool radioButton2_CheckedChanged = true;
            bool radioButton3_CheckedChanged = true;

            if (Player1.Checked)
            {
                playerarray[0].BetAmount = (int)MoneyBet.Value;
                if (playerarray[0].BetAmount > playerarray[0].TotalAmount)
                {
                    playerarray[0].BetAmount = playerarray[0].TotalAmount;
                }
                playerarray[0].AnimalBet = Convert.ToInt32(Animalbet.Value);
                Player1Status.Text = "Sietse has placed €" + playerarray[0].BetAmount + " on cheetah number " + playerarray[0].AnimalBet;
                Player1Money.Text = "Sietse has: €" + playerarray[0].TotalAmount;
            }

            if (Player2.Checked)
            {
                playerarray[1].BetAmount = (int)MoneyBet.Value;
                if (playerarray[1].BetAmount > playerarray[1].TotalAmount)
                {
                    playerarray[1].BetAmount = playerarray[1].TotalAmount;
                }
                playerarray[1].AnimalBet = Convert.ToInt32(Animalbet.Value);
                Player2Status.Text = "Peter has placed €" + playerarray[1].BetAmount + " on cheetah number " + playerarray[1].AnimalBet;
                this.Player2Money.Text = "Peter has: €" + playerarray[1].TotalAmount;
            }

            if (Player3.Checked)
            {
                playerarray[2].BetAmount = (int)MoneyBet.Value;
                if (playerarray[2].BetAmount > playerarray[2].TotalAmount)
                {
                    playerarray[2].BetAmount = playerarray[2].TotalAmount;
                }
                playerarray[2].AnimalBet = Convert.ToInt32(Animalbet.Value);
                Player3Status.Text = "Fer has placed €" + playerarray[2].BetAmount + " on cheetah number " + playerarray[2].AnimalBet;
                this.Player3Money.Text = "Fer has: €" + playerarray[2].TotalAmount;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
