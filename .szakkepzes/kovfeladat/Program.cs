using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kopapirollo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            bool valasz = true;

            string player = "";
            string ai = "";

            int playerScore = 0;
            int aiScore = 0;

            Random ertek = new Random();

            do
            {
               Console.WriteLine("Válassz! (K/P/O)");

            switch (Console.ReadKey(true).KeyChar)
            {
                case 'k':
                    player = "kő";
                    break;
                case 'o':
                    player = "olló";
                    break;
                case 'p':
                    player = "papír";
                    break;
                default:
                    Console.WriteLine("Nincs ilyen elem!");
                    break;
            }

            switch (ertek.Next(0, 3))
            {
                case 0:
                    ai = "kő";
                    break;
                case 1:
                    ai = "olló";
                    break;
                case 2:
                    ai = "papír";
                    break;
            }

            if ((player == "kő" && ai == "papír") || (player == "papír" && ai == "olló") || (player == "olló" && ai == "kő"))
            {
                Console.WriteLine("Vesztettél! Állás: Számítógép: {0} Játékos: {1}", ++aiScore, playerScore);
            }
            else if ((player == ai))
            {
                Console.WriteLine("Döntetlen! Állás: Számítógép: {0} Játékos: {1}", aiScore, playerScore);
            }
            else
            {
                Console.WriteLine("Nyertél! Állás: Számítógép: {0} Játékos: {1}", aiScore, ++playerScore);
            }

            Console.WriteLine("Akarod folytatni? (I/N)");

                if (Console.ReadKey(true).KeyChar == 'n')
                    valasz = false;
            } while (valasz);
            
        }
    }
}
