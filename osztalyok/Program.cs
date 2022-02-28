using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok
{
    class Allat
    {
        // Osztályváltozók (properties)
        private string nev,
            fajta,
            szin;
        private int kor;

        // (konstruktor)
        public Allat(string nev, string fajta, string szin)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
        }

        public string getNev()
        {
            return this.nev;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Példányosítunk objektumokat
            Allat allat1 = new Allat("Bodri", "Puli", "fekete");
            Console.WriteLine("Az állat neve: {0}", allat1.getNev());
            Allat allat2 = new Allat("Bolhás", "Komondor", "fehér");
            Console.WriteLine("Az állat neve: {0}", allat2.getNev());
            Console.ReadKey();
        }
    }
}
