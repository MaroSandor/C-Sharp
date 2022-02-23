using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            string konyvcim;
            int oldalszam;

            do
            {
                // Bekérés
                Console.WriteLine("Kérem a könyv címét!");
                konyvcim = Console.ReadLine();
                Console.WriteLine("Kérem a könyv oldalszámát!");
                oldalszam = int.Parse(Console.ReadLine());
                if (oldalszam < 150 && oldalszam > 0)
                {
                    Console.WriteLine("A könyv címe: {0}, oldalszáma: {1}. A könyv rövid terjedelmű.", konyvcim, oldalszam);
                }
                else
                {
                    Console.WriteLine("A könyv címe {0}, oldalszáma: {1}. A könyv hosszú terjedelmű!", konyvcim, oldalszam);
                }
            } while (konyvcim != "");
            Console.ReadKey();
        }
    }
}
