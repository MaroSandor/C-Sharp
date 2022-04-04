using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tukor
{
    class Tukor
    {
        // Osztályváltozók
        private char szo;

        public Tukor() { }

        public void bekeres()
        {
            Console.WriteLine("Adja meg a tükrözendő szót:");
            szo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("A beírt szó: {0}", szo);
        }

        public void vizsgalat()
        {
            for (int i = szo.Length - 1; i > -1; i--)
            {
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tukor osztaly = new Tukor();
            osztaly.bekeres();
            osztaly.vizsgalat();
            Console.ReadKey();
        }
    }
}
