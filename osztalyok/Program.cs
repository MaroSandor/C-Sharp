using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok
{
    // Arial Rounded MT Bold
    // Polimorfizmus példa
    
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

        // Arial Rounded MT Bold

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

        // Arial Rounded MT Bold

        class Home
        {
            // Osztályváltozó
            List<Allat> szobak = new List<Allat>();
            Random r = new Random();

            public Home() { }

            public void allatAdd(Allat p)
            {
                this.szobak.Add(p);
            }

            public Allat getAllat()
            {
                return this.szobak[r.Next(0, this.szobak.Count - 1)];
            }
        }

        // Poliformizmus példa vége

        class Kutya : Allat
    {
        // Osztály változó
        private string gazda;

        public Kutya(string nev, string fajta, string szin) : base(nev, fajta, szin) // Konstruktor függvény
        {
            this.gazda = "ismeretlen";
            this.setNev("neve nincs");
            this.setSzin("ismeretlen");
            this.setKor(0);
            this.setFajta("ismeretlen");
            this.hang = "A nevem: "+ this.getNev() + "hangom: vau-vau";
        }

        public void setGazda(string gazda)
        {
            this.gazda = gazda;
        }

        public string getGazda()
        {
            return this.gazda;
        }
    }

    class Macska : Allat
    {
        // Konstruktor: 

        public Macska(string nev, string fajta, string szin) : base(nev, fajta, szin) // Konstruktor függvény
        {
            this.hang = "miau-miau";
        }

        public Macska() : base()
            {
                this.setNev("neve nincs");
                this.setSzin("ismeretlen");
                this.setKor(0);
                this.setFajta("ismeretlen");
                this.hang = "A nevem: {0}, hangom: miau-miau"; this.getNev();
            }
    }


        // Arial Rounded MT Bold

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

                Console.WriteLine("\n======================================= Származtatott =======================================");
                Kutya kutya1 = new Kutya("Bogár", "Puli", "Fekete");
                kutya1.setKor(6);
                kutya1.setGazda("Karcsi");
                Console.WriteLine("\nAz állat neve: {0} \nAz állat fajtája: {1} \nAz állat színe: {2} \nAz állat kora: {3}\nAz állat gazdája: {4}", kutya1.getNev(), kutya1.getKor(), kutya1.getFajta(), kutya1.getSzin(), kutya1.getGazda());
                Console.WriteLine("Hangja: {0}", kutya1.hangotAd());
                kutya1.hangotAd();

                Macska macska1 = new Macska("Cirmos", "sziámi", "Fekete");
                Console.WriteLine("\nAz állat neve: {0} \nAz állat fajtája: {1} \nAz állat színe: {2} \nAz állat kora: {3}", macska1.getNev(), macska1.getKor(), macska1.getFajta(), macska1.getSzin());
                Console.WriteLine("Hangja: {0}", macska1.hangotAd());
                macska1.hangotAd();

                // Poliformizmus példa
                Console.WriteLine("============================ Poliformizms példa ============================");

                // Példányosítjuk a Home-t
                Home sweetHome = new Home();

                for (int i = 0; 0 <  20; i++)
                {
                    sweetHome.allatAdd(new Macska());
                }

                // Kihívjuk az állatokat
                Allat a = new Allat();
                for (int i = 0; i < 20; i++)
                {
                    a = sweetHome.getAllat();
                    Console.WriteLine("Hangom: {0}", a.hangotAd());
                    Console.WriteLine("Színem: {0}", a.getSzin());
                    Console.WriteLine("Fajtám: {0}", a.getFajta());
                    Console.WriteLine("Korom: {0}", a.getKor());
                }

                Console.ReadKey();
            }
        }
    }
}
