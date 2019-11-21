using System;
using Ch10CardLib;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Ch10CardClient
{  
    class Program
    {
        static void Main(string[] args)
        {
            Override @override = new override1();
            @override.Test();
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i=0;i<52;i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString ());
                if (i != 51)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine();
                }                
            }
            Console.ReadKey();
        }
    }
}
