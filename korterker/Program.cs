using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korterker
{
    class Kor
    {
        // Osztályváltozók
        private int r;
        private double terulet,
            kerulet;

        public Kor() { }

        public Kor(int r, double terulet, double kerulet)
        {
            this.r = r;
            this.terulet = terulet;
            this.kerulet = kerulet;
        }

        public double terszamitas()
        {
            this.terulet = Math.Pow(getBekeres(), 2) * Math.PI;
            return this.terulet;
        }

        public double kerszamitas ()
        {
            this.kerulet = 2 * getBekeres() * Math.PI;
            return this.kerulet;
        }

        public void setBekeres()
        {
            int ertek = Convert.ToInt32(Console.ReadLine());
            if (ertek != 0)
            {
                this.r = ertek;
            }
        }

        public double getBekeres()
        {
            return this.r;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a sugarat: ");
            Kor a = new Kor();
            a.setBekeres();
            Console.WriteLine("A kör sugara: {0}, területe: {1}, a kör kerülete: {2}.", a.getBekeres(), a.terszamitas(), a. kerszamitas());
            Console.ReadKey();
        }
    }
}
