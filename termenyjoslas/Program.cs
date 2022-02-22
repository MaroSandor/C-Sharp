using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termenyjoslas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók deklarálása
            int mennyiseg = 0,
                hozam,
                random;
            string[] elorejelzes = new string[] { "Átlag alatti", "Átlagos", "Átlag feletti" };
            string eloreertek = "";

            // Random szám generálása
            Random szam = new Random();
            random = szam.Next(5, 15);

            // Feladat fő része
            // Termény mennyiségének bekérése
            Console.WriteLine("Kérem az elvetett búza mennyiségét!");
            mennyiseg = int.Parse(Console.ReadLine());
            hozam = mennyiseg * random;

            if (hozam < 10 && hozam > 0)
            {
                eloreertek = elorejelzes[0];
            } else if (hozam >= 10 && hozam < 20)
            {
                eloreertek = elorejelzes[1];
            } else if (hozam >= 20)
            {
                eloreertek = elorejelzes[2];
            } else
            {
                Console.WriteLine("Ilyen nem lehetséges.");
            }

            Console.WriteLine("A termény hozama: {0} tonna.", hozam);
            Console.WriteLine("{0} év várható.", eloreertek);

            Console.ReadKey();
        }
    }
}
