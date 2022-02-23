using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nev,
                foglalkozas;
            char nem;
            int szerencse;

            Random rnd = new Random();

            

            do
            {
                Console.Write("Add meg a nevet! ");
                nev = Console.ReadLine();
                Console.Write("Add meg a foglalkozását! ");
                foglalkozas = Console.ReadLine();
                Console.Write("Add meg a nemét! (f/n) ");
                nem = Convert.ToChar(Console.ReadLine());

                szerencse = rnd.Next(1, 50);

                if (nem == 'f')
                {
                    Console.WriteLine("{0} egy {1} férfi volt, szerencse száma a {2}.", nev, foglalkozas, szerencse);
                } else if (nem == 'n')
                {
                    Console.WriteLine("{0} egy {1} nő volt, szerencse száma a {2}.", nev, foglalkozas, szerencse);
                }
            } while (nev != "");
            

            Console.ReadKey();
        }
    }
}
