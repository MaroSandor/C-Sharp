using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtable2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Két parancssori paraméter is megadható. Parancssori paraméterek száma lehet: 0, 1, 2 */
            int param = args.Length; // Paraméterek száma
            int szam1 = 0; // 1. paraméter értéke
            int szam2 = 0; // 2. paraméter értéke

            Random rnd = new Random();

            switch(param)
            {
                case 0:
                    szam1 = rnd.Next(1, 100);
                    szam2 = rnd.Next(1, 100);
                    break;
                case 1:
                    szam1 = int.Parse(args[0]);
                    szam2 = rnd.Next(1, 100);
                    break;
                case 2:
                    szam1 = int.Parse(args[0]);
                    szam2 = int.Parse(args[1]);
                    break;
            }

            // Kiíratom az eredményt
            Console.WriteLine(szam1 * szam2);
            Console.ReadKey();
        }
    }
}
