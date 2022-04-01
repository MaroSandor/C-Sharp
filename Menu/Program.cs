using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        private int bekeres;

        public Menu() { }

        public void valasztas()
        {
            int vizs = 0;
            Console.WriteLine("Válasszon menüpontot!");
            Console.WriteLine("1 - Első menüpont");
            Console.WriteLine("2 - Második menüpont");
            Console.WriteLine("3 - Harmadik menüpont");
            Console.WriteLine("4 - Negyedik menüpont");
            Console.WriteLine("5 - Kilépés");

            do
            {
                bekeres = Convert.ToInt32(Console.ReadLine());
                switch (bekeres)
                {
                    case 1: Console.WriteLine("Első menüpont"); break;
                    case 2: Console.WriteLine("Második menüpont"); break;
                    case 3: Console.WriteLine("Harmadik menüpont"); break;
                    case 4: Console.WriteLine("Negyedik menüpont"); break;
                    case 5: vizs = 5; break;
                    default:
                        break;
                }
            } while (vizs != 5);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu a = new Menu();
            a.valasztas();
        }
    }
}
