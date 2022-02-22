using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponthatarok
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int pontszam = 0;

            // Feladat fő része
            // Pontszám bekérése
            Console.WriteLine("Kérem a pontszámot!");
            pontszam = int.Parse(Console.ReadLine());

            if (pontszam > 100 || pontszam < 0)
            {
                Console.WriteLine("Hibás adat!");
            } else if (pontszam <= 100 && pontszam >= 90)
            {
                Console.WriteLine("A pontszáma: {0}, a dolgozat értékelése: jeles.", pontszam);
            } else if (pontszam < 90 && pontszam >= 80)
            {
                Console.WriteLine("A pontszáma: {0}, a dolgozat értékelése: jó.", pontszam);
            } else if (pontszam < 80 && pontszam >= 65)
            {
                Console.WriteLine("A pontszáma: {0}, a dolgozat értékelése: közepes.", pontszam);
            } else if (pontszam < 65 && pontszam >= 50)
            {
                Console.WriteLine("A pontszáma: {0}, a dolgozat értékelése: elégséges.", pontszam);
            } else
            {
                Console.WriteLine("A pontszáma: {0}, a dolgozat értékelése: elégtelen.", pontszam);
            }
            Console.ReadKey();
        }
    }
}
