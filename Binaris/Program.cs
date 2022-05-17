// Máró Sándor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    public class Binarisok
    {
        public string szam;
        public int egyes = 0;

        public Binarisok(string szam)
        {
            this.szam = szam;
        }

        public int szamolas()
        {
            for (int i = 0; i < this.szam.Length; i++)
            {
                if (this.szam[i] == '1')
                {
                    egyes++;
                }
            }
            Console.WriteLine("Az egyesek száma: {0}", egyes);

            return egyes;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg egy bináris számot:");
            Binarisok osztaly = new Binarisok(Console.ReadLine());
            osztaly.szamolas();
            Console.ReadKey();
        }
    }
}
