using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dolgozat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int szam = 0,
                szam2 = 0;

            do
            {
                Console.WriteLine("Kérek egy számot!");
                szam = int.Parse(Console.ReadLine());
                if (szam > szam2)
                {
                    szam2 = szam;
                } else
                {
                    Console.WriteLine("A legnagyobb szám amit beírtál a: {0}.", szam2);
                }
            } while (szam != 0);

            Console.ReadKey();
        }
    }
}
