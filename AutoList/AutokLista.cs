using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoList
{
    class AutokLista
    {
        class Auto
        {
            private string rendszam,
            gyartmany,
            tipus,
            tulajnev;
            private int gyartasiev;
            private DateTime muszakivizsga;

            public Auto(string rendszam, string gyartmany, string tipus, string tulajnev, int gyartasiev, DateTime muszakivizsga)
            {
                this.rendszam = rendszam;
                this.gyartmany = gyartmany;
                this.tipus = tipus;
                this.tulajnev = tulajnev;
                this.gyartasiev = gyartasiev;
                this.muszakivizsga = muszakivizsga;
            }

            public void printAutok()
            {
                Console.WriteLine("{0,-20} {1,10} {2,1} {3} {4}", rendszam, muszakivizsga.ToShortDateString(), gyartmany, tipus, gyartasiev, tulajnev);
            }
        }

        private List<Auto> autoLista;
        private string fajlNev;

        public AutokLista()
        {
            autoLista = new List<Auto>(); // Létrehozzuk a listát
        }

        public void Beolvas()
        {
            string sor; // Egy sor beolvasására
            string[] mezok; // Sor szétbontásához

            // Fájlnév beolvasása
            Console.WriteLine("Adja meg a szövegfájl nevét elérési úttal!");
            fajlNev = Console.ReadLine();

            // Ha hiányzik a .txt kiterjesztés, kiegészítjük
            if (fajlNev.EndsWith("")) fajlNev += ".txt";

            // Beolvasás fájlból
            using (StreamReader sr = new StreamReader(fajlNev, Encoding.Default))
                while (sr.EndOfStream == false)
                {
                    sor = sr.ReadLine();
                    if (sor.Trim().Length == 0) continue; // Ha üres a sor, akkor léptetünk

                    mezok = sor.Split(','); // Szétbontás

                    // Hozzáadás a listához
                    autoLista.Add(new Auto(
                        mezok[0],
                        mezok[1],
                        mezok[2],
                        mezok[3],
                        int.Parse(mezok[4]),
                        DateTime.Parse(mezok[5])));
                }
        }

        public void Kiir()
        {
            foreach (Auto p in autoLista)
            {
                p.printAutok();
            }
            Console.ReadKey();
        }
    }
}
