using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Palindrom
    {
        private string szo,
            tukorforditas;
        private char valasz;

        public Palindrom() { }

        public void ReverseString()
        {
            do
            {
                Console.WriteLine("Adja meg a vizsgálandó szót:");
                szo = Console.ReadLine();

                char[] megfordit = szo.ToCharArray();
                string tukorforditas = String.Empty;

                for (int i = megfordit.Length - 1; i > -1; i--)
                {

                    // Append each character to the reversedstring.
                    tukorforditas += megfordit[i];
                }

                Console.WriteLine("A megadott szó: {0}", szo);
                Console.WriteLine("A szó megfordítása: {0}", tukorforditas);

                if (szo == tukorforditas)
                {
                    Console.WriteLine("A szó palindrom típusú.");
                }
                else
                {
                    Console.WriteLine("A szó nem palindrom típusú.");
                }

                Console.WriteLine("Szeretnél még valamit megvizsgálni?");
                valasz = Convert.ToChar(Console.ReadLine());

            } while (valasz != 'n');
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Palindrom a = new Palindrom();
            a.ReverseString();
        }
    }
}
