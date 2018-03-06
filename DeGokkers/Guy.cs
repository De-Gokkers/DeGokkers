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
        public int TotalAmount = 100;
        public int BetAmount;
        public int AnimalBet;


        public static object GuyTotalAmount
        { get; internal set;
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

        /*public bool PlaceBet(int amount, int dog)
        {
            
                //Plaats een nieuwe weddenschap en sla het op in de variabele MyBet.
                //Retourneer een true als de gokker genoeg geld heeft om te wedden.
                //Onderstaande regel staat er tijdelijk om foutmeldingen te voorkomen.
                //Haal deze regel later weg.
            return true;
        }*/

        public void ClearBet()
        {
            ClearBet();

        }

        public void Collect()
        {

            if (AnimalBet == Form1.AnimalWinner)
            {
                switch (Form1.AnimalWinner)
                {
                    case 1:
                        Form1.TotalBet /= Form1.AmountBedsnr1;
                        break;

                    case 2:
                        Form1.TotalBet /= Form1.AmountBedsnr2;
                        break;

                    case 3:
                        Form1.TotalBet /= Form1.AmountBedsnr3;
                        break;

                    case 4:
                        Form1.TotalBet /= Form1.AmountBedsnr4;
                        break;

                    case 5:
                        Form1.TotalBet /= Form1.AmountBedsnr5;
                        break;

                    case 6:
                        Form1.TotalBet /= Form1.AmountBedsnr6;
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

        public void guys()
        {
            //this.TotalAmount;
        }
    }
}
