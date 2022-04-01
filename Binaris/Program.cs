using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    class Binaris
    {
        public Binaris() { }

        public void szamolas()
        {
            string szam;
            int egyes = 0;
            
            Console.WriteLine("Kérem adjon meg egy bináris számot:");
            szam = Console.ReadLine();

            for (int i = 0; i < szam.Length; i++)
            {
                if (szam[i] == '1')
                {
                    egyes++;
                }
            }
            Console.WriteLine("Az egyesek száma: {0}", egyes);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Binaris a = new Binaris();
            a.szamolas();
            Console.ReadKey();
        }
    }
}
