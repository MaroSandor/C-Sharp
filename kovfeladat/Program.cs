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
                Console.WriteLine("Akarod folytatni? (I/N)");

                if (Console.ReadKey(true).KeyChar == 'N')
                    valasz = false;
            } while (valasz);

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
                    Console.WriteLine("Szar vagy");
                    break;
            }
        }
    }
}
