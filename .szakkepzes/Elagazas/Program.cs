using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas
{
    class Elagazas
    {
        public Elagazas() { }

        Random szam = new Random();

        private int random = 0;
        private int a = 0;

        public void parosszamok()
        {
            Console.WriteLine("Kérem adja meg a lista hosszát:");
            a = Convert.ToInt32(Console.ReadLine());

            List<int> lista = new List<int>(a);

            for (int i = 0; i < a; i++)
            {
                random = szam.Next(10, 1000);

                lista.Add(random);
            }

            Console.WriteLine("A páros számok: ");

            foreach (var item in lista)
            {
                if (item % 2 == 0)
                {
                    Console.Write("{0} ", item);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Elagazas osztaly = new Elagazas();
            osztaly.parosszamok();
            Console.ReadKey();
        }
    }
}
