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
        public int BetAmount = 5;
        public int AnimalBet = 1;
        public int TotalBet;

        public static object GuyTotalAmount
        {
            get; internal set;
        }

        public void GuyMain()
        {

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

        }

        public void Collect()
        {

            if (AnimalBet == Form1.AnimalWinner)
            {
                switch (Form1.AnimalWinner)
                {
                    case 1:
                        this.TotalBet = Form1.TotalBet;
                        if(Form1.AmountBedsnr1 > 1)
                        {
                            this.TotalBet /= Form1.AmountBedsnr1;
                        }
                        TotalAmount += TotalBet;
                        break;

                    case 2:
                        this.TotalBet = Form1.TotalBet;
                        if (Form1.AmountBedsnr1 > 1)
                        {
                            this.TotalBet /= Form1.AmountBedsnr2;
                        }
                        TotalAmount += TotalBet;
                        break;

                    case 3:
                        this.TotalBet = Form1.TotalBet;
                        if (Form1.AmountBedsnr1 > 1)
                        {
                            this.TotalBet /= Form1.AmountBedsnr3;
                        }
                        TotalAmount += TotalBet;
                        break;

                    case 4:
                        this.TotalBet = Form1.TotalBet;
                        if (Form1.AmountBedsnr1 > 1)
                        {
                            this.TotalBet /= Form1.AmountBedsnr4;
                        }
                        TotalAmount += TotalBet;
                        break;

                    case 5:
                        this.TotalBet = Form1.TotalBet;
                        if (Form1.AmountBedsnr1 > 1)
                        {
                            this.TotalBet /= Form1.AmountBedsnr5;
                        }
                        TotalAmount += TotalBet;
                        break;

                    case 6:
                        this.TotalBet = Form1.TotalBet;
                        if (Form1.AmountBedsnr1 > 1)
                        {
                            this.TotalBet /= Form1.AmountBedsnr6;
                        }
                        TotalAmount += TotalBet;
                        break;
                }      
            }
            else
            {

            }
            //Betaal mijn weddenschap uit.
            //Maak mijn weddenschap leeg.
            //Werk mijn labels bij.
        }
    }
}
