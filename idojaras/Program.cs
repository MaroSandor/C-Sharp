using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idojaras
{
    class Idojaras
    {
        // Osztályváltozók
        private int ev,
            nap,
            napok,
            homerseklet;
        private string honap,
            honapneve,
            evszak,
            evszakok;
        private string[] honapok = new string[] {"január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december"};

        public Idojaras() {
            this.evszakok = evszak;
            this.honapneve = honap;
            this.napok = nap;
        }

        public void datumBekeres()
        {
            Console.Write("Kérem adja meg az évet: ");
            ev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a hónapot: ");
            honap = Console.ReadLine();
            Console.Write("Kérem adja meg a napot: ");
            nap = Convert.ToInt32(Console.ReadLine());
        }

        public int getHom()
        {
            return homerseklet;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Meghívások
            Idojaras osztaly = new Idojaras();
            osztaly.datumBekeres();
            Console.ReadKey();
        }
    }
}
