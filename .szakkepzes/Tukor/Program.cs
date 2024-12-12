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
        private string szo,
            bekertszo;

        public Tukor() 
        {
            this.bekertszo = szo;
        }

        public void bekeres()
        {
            Console.WriteLine("Adja meg a tükrözendő szót:");
            this.bekertszo = Console.ReadLine();

            Console.WriteLine("A beírt szó: {0}", this.bekertszo);
        }

        public void vizsgalat()
        {
            string tukrozes = "";
            string forgatott = String.Empty;

            for (int i = this.bekertszo.Length - 1; i > -1; i--)
            {
                char[] tarolas = this.bekertszo.ToCharArray();
                tukrozes = String.Empty;

                for (int j = tarolas.Length - 1; j > -1; j--)
                {
                    tukrozes += tarolas[j];
                }
            }
            Console.WriteLine("A tükrözött szó: {0}", tukrozes);
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
