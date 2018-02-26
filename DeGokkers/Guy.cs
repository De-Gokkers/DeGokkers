using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGokkers
{
    class Guy
    {
        public class GuyMain
        {
            public string Name; // De naam van de gokker
            public Bet MyBet; // Een instantie van Bet()
            public int Cash; // Het saldo van de gokker
                             //Deze twee velden zijn de gokkers GUI controls op het formulier
            //public RadioButton MyRadiobutton;
            //public Label MyLabel;
            // test
            public void UpdateLabels()
            {
                //Verander mijn label in de omschrijving van mijn weddenschap.
                //Verander de label op mijn radioknop zodat deze mijn saldo laat zien.
                //(Bijv. “Lidy heeft 43 euro.”)
            }
            public bool PlaceBet(int amount, int dog)
            {
                //Plaats een nieuwe weddenschap en sla het op in de variabele MyBet.
                //Retourneer een true als de gokker genoeg geld heeft om te wedden.
                //Onderstaande regel staat er tijdelijk om foutmeldingen te voorkomen.
                //Haal deze regel later weg.
                return true;
            }
            public void ClearBet()
            {
                ClearBet();

            }

            public void Collect(int Winner)
            {
                //Betaal mijn weddenschap uit.
                //Maak mijn weddenschap leeg.
                //Werk mijn labels bij.
            }

            public void guy()
            {
                String Name;
                int TotalAmount = 100; // Het bedrag dat de persoon heeft in €.
                int BetAmount;
                int AnimalBet;
            }
            public void guys()
            {
                //this.TotalAmount;
            }

            public void guyArray()
            {
                int[] guys = new int[5];

                guys[0] = 1;
                guys[1] = 1;
                guys[2] = 1;
            }



        }
    }
}
