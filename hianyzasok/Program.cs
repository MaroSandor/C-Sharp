using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hianyzasok
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók deklarálása
            int igazolatlan,
                magatartasjegy;
            DateTime szuletesidatum;
            int[] buntetesmertek = new int[] {1, 2, 3, 4, 5};

            Console.WriteLine("Kérem adja meg a tanuló hiányzásainak számát!");
            igazolatlan = int.Parse(Console.ReadLine());

            // Magatartás jegy meghatározása

            if (igazolatlan <= 1)
            {
                magatartasjegy = buntetesmertek[4];
            } else if (igazolatlan <= 3)
            {
                magatartasjegy = buntetesmertek[3];
            } else if (igazolatlan <= 5)
            {
                magatartasjegy = buntetesmertek[2];
            } else if (igazolatlan <= 7) {
                magatartasjegy = buntetesmertek[1];
            } else
            {
                magatartasjegy = buntetesmertek[0];
            }

            Console.WriteLine("A magatartásod jegye: {0}", magatartasjegy);

            // Igazolatlan hiányzások bekérése

            
            if (igazolatlan >= 10)
            {
                Console.WriteLine("Kérem adja meg a születési dátumát! (YYYY.MM.DD.)");
                szuletesidatum = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Az igazolatlan hiányzások száma: {0}. \nSzületési dátuma: {1}", igazolatlan, szuletesidatum);
            }
            Console.ReadKey();
        }
    }
}
