using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friendsData
{
    internal class BaratLista // ??? Mit jelent az internal? ???
    {
        private class Barat
        {
            public string nev;
            public char nem;
            public DateTime szuletett;
            public int bulhajlam;

            public Barat() { }

            public Barat(string nev, char nem, DateTime szuletett, int bulhajlam)
            {
                this.nev = nev;
                this.nem = nem;
                this.szuletett = szuletett;
                this.bulhajlam = bulhajlam;
            }

            public void printBarat()
            {
                Console.WriteLine("{0,-20} {1,10} {2,1} {3}", nev, szuletett.ToShortDateString(), nem, bulhajlam);
            }
        }

        private List<Barat> baratLista; // Ebben tároljuk a barát objektumokat
        private string fajlNev;

        public BaratLista()
        {
            baratLista = new List<Barat>(); // Létrehozzuk a listát
        }

        public void Beolvas()
        {
            string sor; // Egy sor beolvasására
            string[] mezok; // Sor szétbontásához

            // Fájlnév beolvasása
            Console.WriteLine("Adja meg a szövegfájl nevét elérési úttal!");
            fajlNev = Console.ReadLine();

            // Ha hiányzik a .txt kiterjesztés, kiegészítjük
            if (fajlNev.EndsWith(".txt")) fajlNev += ".txt";

            // Beolvasás fájlból
            using (StreamReader sr = new StreamReader(fajlNev, Encoding.Default))
                while (sr.EndOfStream == false)
                {
                    sor = sr.ReadLine();
                    if (sor.Trim().Length == 0) continue; // Ha üres a sor, akkor léptetünk

                    mezok = sor.Split(','); // Szétbontás

                    // Hozzáadás a listához
                    baratLista.Add(new Barat (
                        mezok[0],
                        char.Parse(mezok[1]),
                        DateTime.Parse(mezok[2]),
                        int.Parse(mezok[3])));
                }
        }

        public void Kiir()
        {
            foreach (Barat p in baratLista)
            {
                p.printBarat();
            }
            Console.ReadKey();
        }
    }
}
