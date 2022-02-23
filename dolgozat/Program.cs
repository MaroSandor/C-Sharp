using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók deklarálása
            int egyikszam,
                masikszam;

            // Számok bekérése
            Console.WriteLine("Kérem adja meg az egyik számot! (0-tól eltérő)");
            egyikszam = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a második számot! (0-tól eltérő)");
            masikszam = int.Parse(Console.ReadLine());

            if (egyikszam > 0 && masikszam > 0)
            {
                Console.WriteLine("A két szám közül egyik sem negatív!");
            } else if (egyikszam < 0 && masikszam > 0)
            {
                Console.WriteLine("A két szám közül az első negatív!");
            } else if (egyikszam > 0 && masikszam < 0)
            {
                Console.WriteLine("A két szám közül a második negatív!");
            } else if (egyikszam < 0 && masikszam < 0)
            {
                Console.WriteLine("Mind a két szam negatív!");
            } else
            {
                Console.WriteLine("0-tól eltérő számot kértem!");
            }
            Console.ReadKey();
        }
    }
}
