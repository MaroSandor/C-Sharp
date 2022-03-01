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
        protected string hang;

        // (konstruktor)
        public Allat(string nev, string fajta, string szin)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
        }

        public Allat()
        {
            this.nev = "anonim";
            this.fajta = "ismeretlen";
            this.szin = "lila";
            this.kor = 0;
        }

        // Meghívások
        public string getNev()
        {
            return this.nev;
        }

        public void setNev(string nev)
        {
            if (nev != "")
            {
                this.nev = nev;
            }
        }

        public int getKor()
        {
            return this.kor;
        }

        public void setKor(int p)
        {
            if (p > 0 && p <= 50)
            {
                this.kor = p;
            }
        }

        public string getFajta()
        {
            return this.fajta;
        }

        public void setFajta(string fajta)
        {
            if (fajta != "")
            {
                this.fajta = fajta;
            }
        }

        public string getSzin()
        {
            return this.szin;
        }

        public void setSzin(string szin)
        {
            if (szin != "")
            {
                this.szin = szin;
            }
        }

        public string hangotAd() // get
        {
            return this.hang;
        }

        public void setHang(string hang)
        {
            if (hang != "")
            {
                this.hang = hang;
            }
        }
    }

    // Arial Rounded MT Bold

    class Kutya : Allat
    {
        // Osztály változó
        private string gazda;

        public Kutya(string nev, string fajta, string szin) : base(nev, fajta, szin) // Konstruktor függvény
        {
            this.gazda = "ismeretlen";
            this.hang = "vau-vau";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Példányosítunk objektumokat
            Allat allat1 = new Allat("Bodri", "Puli", "fekete");
            allat1.setKor(2);
            Console.WriteLine("Az állat neve: {0}, fajtája: {2}, színe: {3}, kora: {1} éves", allat1.getNev(), allat1.getKor(), allat1.getFajta(), allat1.getSzin());

            Allat allat2 = new Allat("Bolhás", "Komondor", "fehér");
            allat2.setKor(5);
            Console.WriteLine("Az állat neve: {0}, fajtája: {2}, színe: {3}, kora: {1} éves", allat2.getNev(), allat2.getKor(), allat2.getFajta(), allat2.getSzin());

            Allat allat3 = new Allat();
            allat3.setNev("Bambi"); allat3.setFajta("Német-juhász"); allat3.setSzin("zöld"); allat3.setKor(14);
            Console.WriteLine("\nAz állat neve: {0}, \nAz állat fajtája: {2}, \nAz állat színe: {3}, \nAz állat kora: {1} éves", allat3.getNev(), allat3.getKor(), allat3.getFajta(), allat3.getSzin());

            Console.WriteLine("\n============= Származtatott =============");
            Kutya kutya1 = new Kutya("Bogár", "Puli", "Fekete");
            Console.WriteLine("\nHangja: {0}", kutya1.hangotAd());
            kutya1.setHang("vau-vau");

            Console.ReadKey();
        }
    }
}
