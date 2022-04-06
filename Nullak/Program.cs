using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullak
{
    class Nullak
    {
        private int db_szam,
            nullak = 0;
        private int[] leghosszabb = new int[] { };
        Random szamok = new Random();

        public Nullak() { }

        public void eloallitas()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("   Adja meg a generálandó számok számát");
            Console.WriteLine("==========================================");
            db_szam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < db_szam; i++)
            {
                int a = szamok.Next(1000000, 9999999);

                string szam = Convert.ToString(a);

                Console.WriteLine("{0}", a);

                for (int j = 0; j < szam.Length - 1; j++)
                {
                    if (szam[j] == '0')
                    {
                        nullak++;
                    }                    
                }
                Console.WriteLine("A nullák száma: {0}", nullak);

                leghosszabb[i] = nullak;

                nullak = 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nullak osztaly = new Nullak();
            osztaly.eloallitas();
            Console.ReadKey();
        }
    }
}
