using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGokkers
{
    class Bet
    {
        public class Betmain
        {
            public int Amount; //Het bedrag van de weddenschap.
            public int Dog; //Het nummer van de hond waarop weddenschap is afgesloten.
            public Guy Bettor; //De gokker die gewed heeft.
            public string GetDescription()
            {
                //Retourneer een string die aangeeft wie de weddenschap heeft gedaan,
                //voor welk bedrag er is gewed en op welke hond er is gewed.
                //Bijv. “Sietse wedt 8 euro op hond 4”.
                //Als het bedrag 0 is, is er geen weddenschap geplaatst.
                //De string die dan geretourneerd wordt is bijv.
                //“Sietse heeft geen weddenschap geplaatst.”)
            }

            public int PayOut(int Winner)
            {
                //De parameter van deze methode is de winnaar van de race.
                //Als de hond gewonnen heeft, retourneer dan het bedrag dat gewed is
                //Anders, retourneer het tegengestelde van het gewedde bedrag.
            }
        }
    }
}
