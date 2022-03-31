using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatok
{
    class Szamtani
    {
        private double a,
            b,
            c,
            d,
            diff;

        public Szamtani() { }

        public void bekeres()
        {
            Console.WriteLine("Adja meg a sorozat első négy tagját: (számtani vagy mértani sorozat legyen)");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
        }

        public void vizsgalat()
        {
            if (d > c && c > b && b > a) // Ha növekvő sorrendben adja meg a sorozat elemeit
            {
                diff = b - a;
            } else if (a < b && b < c && c < d) // Ha csökkenő sorrendben adja meg a sorozat elemeit
            {
                diff = a - b;
            } else if ()
            {
                diff = 
            }

            if (a - b == diff && b - c == diff && c - d == diff)
            {
                Console.WriteLine("A sorozat számtani sorozat!");
            } else if (d - c == diff && c - b == diff && b - a == diff)
            {
                Console.WriteLine("A sorozat számtani sorozat!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Szamtani a = new Szamtani();
            a.bekeres();
            a.vizsgalat();
            Console.ReadKey();
        }
    }
}
