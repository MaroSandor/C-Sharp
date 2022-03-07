using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor
{
    class Vektor
    {
        // Osztályváltozók
        private int elemekszama,
            elemek,
            ertek;
        private int[] vektorhossz;

        // Random szám generálás

        Random rand = new Random();

        public Vektor() { }

        public void Feltoltes()
        {
            Console.WriteLine("Írja be a vektor hosszát:");
            elemekszama = int.Parse(Console.ReadLine());
            vektorhossz = new int[elemekszama];
            for (int i = 0; i < elemekszama; i++)
            {
                vektorhossz[i] = rand.Next(0, 100);
            }
        }

        public void setOsszeg()
        {
            int osszeg = 0;
            for (int i = 0; i < vektorhossz.Length; i++)
            {
                osszeg = osszeg + vektorhossz[i];
            }
            this.ertek = osszeg;
        }

        public int getOsszeg()
        {
            Console.WriteLine("Az összeg: {0}", this.ertek);
            return this.ertek;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Vektor a = new Vektor();
                a.Feltoltes();
                a.setOsszeg();
                a.getOsszeg();
                Console.ReadKey();
            }
        }
    }
}