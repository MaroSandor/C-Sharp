using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Listak
    {
        Random szam = new Random();

        private int random = 0;
        private int a = 0;

        public Listak() { }

        public void feltoltes()
        {
            Console.WriteLine("Kérem adja meg a lista hosszát:");
            a = Convert.ToInt32(Console.ReadLine());

            List<int> lista = new List<int>(a);

            for (int i = 0; i < a; i++)
            {
                random = szam.Next(10, 100);

                lista.Add(random);
            }

            Console.WriteLine("A lista elemei: ");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Listak osztaly = new Listak();
            osztaly.feltoltes();
            Console.ReadKey();
        }
    }
}
