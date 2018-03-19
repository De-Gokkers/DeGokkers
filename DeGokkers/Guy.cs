using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGokkers
{
    class Guy
    {
        public string Name; // De naam van de gokker
        public Bet MyBet; // Een instantie van Bet()
        public int TotalAmount;
        public int BetAmount;
        public int AnimalBet;
        public int TotalBet;

        public static object GuyTotalAmount
        {
            get; internal set;
        }

        public void GuyMain()
        {
            this.Name = "name";
            this.TotalAmount = 100;
            this.BetAmount = 5;
            this.AnimalBet = 1;
        }

            //Deze twee velden zijn de gokkers GUI controls op het formulier
            //public RadioButton MyRadiobutton;
            //public Label MyLabel;
            // test
        public void NumberOfBets()
        {
            switch (AnimalBet)
            {
                case 1:
                    Form1.AmountBedsnr1++;
                    break;

                case 2:
                    Form1.AmountBedsnr2++;
                    break;

                case 3:
                    Form1.AmountBedsnr3++;
                    break;

                case 4:
                    Form1.AmountBedsnr4++;
                    break;

                case 5:
                    Form1.AmountBedsnr5++;
                    break;

                case 6:
                    Form1.AmountBedsnr6++;
                    break;

            }
                //Verander mijn label in de omschrijving van mijn weddenschap.
                //Verander de label op mijn radioknop zodat deze mijn saldo laat zien.
                //(Bijv. “Lidy heeft 43 euro.”)
        }

        public void Collect()
        {

            if (AnimalBet == Form1.AnimalWinner)
            {
                switch (Form1.AnimalWinner)
                {
                    case 1:
                        TotalAmount -= BetAmount;
                        this.TotalBet = Form1.TotalBet;
                        this.TotalBet /= Form1.AmountBedsnr1;
                        TotalAmount += TotalBet;
                        break;

                    case 2:
                        TotalAmount -= BetAmount;
                        this.TotalBet = Form1.TotalBet;
                        this.TotalBet /= Form1.AmountBedsnr2;
                        TotalAmount += TotalBet;
                        break;

                    case 3:
                        TotalAmount -= BetAmount;
                        this.TotalBet = Form1.TotalBet;
                        this.TotalBet /= Form1.AmountBedsnr3;
                        TotalAmount += TotalBet;
                        break;

                    case 4:
                        TotalAmount -= BetAmount;
                        this.TotalBet = Form1.TotalBet;
                        this.TotalBet /= Form1.AmountBedsnr4;
                        TotalAmount += TotalBet;
                        break;

                    case 5:
                        TotalAmount -= BetAmount;
                        this.TotalBet = Form1.TotalBet;
                        this.TotalBet /= Form1.AmountBedsnr5;
                        TotalAmount += TotalBet;
                        break;

                    case 6:
                        TotalAmount -= BetAmount;
                        this.TotalBet = Form1.TotalBet;
                        this.TotalBet /= Form1.AmountBedsnr6;
                        TotalAmount += TotalBet;
                        break;

                }
                 
            }
            else
            {
                TotalAmount -= BetAmount;
            }
            //Betaal mijn weddenschap uit.
            //Maak mijn weddenschap leeg.
            //Werk mijn labels bij.
        }
    }
}
