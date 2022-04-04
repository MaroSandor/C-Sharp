using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullak
{
    class Nullak
    {
        private int db_szam = 0;
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
                int a = szamok.Next(100000, 999999);
                Console.WriteLine("{0}", Convert.ToString(a));

                for (int j = 0; j < i; j++)
                {

                }
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
