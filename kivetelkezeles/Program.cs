using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetelkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool vizs = true;

            do
            {
                try
                {
                    int szam = 0;
                    Console.WriteLine("Adjon meg egy számot:");
                    a = int.Parse(Console.ReadLine());
                    szam = a / szam;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ez nem egy szám!");
                    vizs = false;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Nullával való osztás értelmetlen!");
                }
                Console.ReadKey();
            } while (vizs);
        }
    }
}
