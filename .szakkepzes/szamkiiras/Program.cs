using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkiiras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szam = "";
            var egyes = new string[] { "nulla", "egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc" };
            var tizes = new string[] { "tizen", "huszon", "harminc", "negyven", "ötven", "hatvan", "hetven", "nyolcvan", "kilencven", "száz" };

            Console.WriteLine("Kérem írjon be egy számot!");
            szam = Console.ReadLine();



            Console.ReadKey();
        }
    }
}
