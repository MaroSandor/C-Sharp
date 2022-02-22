using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempezes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            double szel,
                mely,
                terulet,
                darabszam,
                csempemeret;

            Console.WriteLine("Kérem a szoba szélességét!");
            szel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a szoba mélységét!");
            mely = Convert.ToDouble(Console.ReadLine());

            csempemeret = Math.Pow(0.2, 2);

            terulet = szel * mely;

            darabszam = terulet / csempemeret;

            Console.WriteLine("A szükséges csempék száma: {0}", darabszam);
            Console.ReadKey();
        }
    }
}
