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

                Console.WriteLine("A beírt szó: {0} ", szo);

                string fordit = szo.ToLower();
                szo = String.Concat(fordit.Where(x => !Char.IsWhiteSpace(x)));
                string tukorforditas = String.Empty;

                for (int i = szo.Length - 1; i > -1; i--)
                {
                    tukorforditas += szo[i];
                }

                //Console.WriteLine("A megadott szó: {0}", szo);
                //Console.WriteLine("A szó megfordítása: {0}", tukorforditas);

                if (szo == tukorforditas)
                {
                    Console.WriteLine("Palindrom típusú.");
                }
                else
                {
                    Console.WriteLine("Nem palindrom típusú.");
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
