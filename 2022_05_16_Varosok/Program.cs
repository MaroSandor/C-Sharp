using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_05_16_Varosok
{
    class Varos
    {
        int dbvaros = 0;
        List<string> varosok = new List<string>();
        string varosnev;

        public Varos() { }

        public void setDb()
        {
            Console.WriteLine("Adja meg a a tárolni kívánt városok számát!");
            dbvaros = Convert.ToInt32(Console.ReadLine());

            if (dbvaros == 0)
            {
                Console.WriteLine("Kérem adja meg a városok neveit!");

                do
                {
                    for (int i = 0; i <= dbvaros; i++)
                    {
                        varosnev = Console.ReadLine();
                        varosok.Add(varosnev);
                    }
                } while (varosnev != "");

                string utolso = varosok[varosok.Count - 1];

                varosok.Remove(utolso);
            }
        }

        public void setNevek()
        {
            Console.WriteLine("Kérem adja meg a városok neveit!");

                for (int i = 0; i < dbvaros; i++)
                {
                    varosnev = Console.ReadLine();
                    varosok.Add(varosnev);
                }
        }

        public void getNevek()
        {
            Console.WriteLine("\nA lista elemei:");

            foreach (var item in varosok)
            {
                Console.Write("{0}, ", item);
            }
        }

        public void getVan()
        {
            string bekertnev;

            Console.WriteLine();
            Console.WriteLine("\nAdja meg a város nevét!");
            bekertnev = Console.ReadLine();

            if (varosok.Contains(bekertnev))
            {
                Console.WriteLine("A megadott város szerepel a listában!");
            } else
            {
                Console.WriteLine("A megadott város nem szerepel a listában!");
            }

            Console.WriteLine();

            foreach (var item in varosok)
            {
                Console.WriteLine(item);
            }
        }

        public void delNev()
        {
            string bekertnev;

            Console.WriteLine();
            Console.WriteLine("Adja meg a város nevét!");
            bekertnev = Console.ReadLine();

            if (varosok.Contains(bekertnev))
            {
                Console.Write("\nA megadott város szerepel a listában. Törölve!");
                varosok.Remove(bekertnev);
            }
            else
            {
                Console.Write("\nA megadott város nem szerepel a listában. Hozzáadva!");
                varosok.Add(bekertnev);
            }

            Console.WriteLine("\nA lista elemei:");

            foreach (var item in varosok)
            {
                Console.WriteLine(item);
            }
        }

        public void delLast()
        {
            string utolso = varosok[varosok.Count - 1];

            varosok.Remove(utolso);

            Console.WriteLine("\nAz utolsó elem törölve lett!");

            foreach (var item in varosok)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Varos osztaly = new Varos();
            osztaly.setDb();
            osztaly.setNevek();
            osztaly.getNevek();
            osztaly.getVan();
            osztaly.delNev();
            osztaly.delLast();
            Console.ReadKey();
        }
    }
}
