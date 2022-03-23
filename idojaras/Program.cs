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
            min_homerseklet = 0,
            max_homerseklet = 0;
        private string honap,
            honapneve,
            evszak,
            evszakok;
        private int[,] azonosit = new int[12, 31];
        private int[,] azonosit2 = new int[12, 31];
        private string[] honapok = new string[] { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
        Random maxho = new Random();
        Random minho = new Random();

        public Idojaras()
        {
            this.evszak = evszakok;
            this.honap = honapneve;
            this.nap = napok;
        }

        public void datumBekeres()
        {
            Console.Write("Kérem adja meg az évet (ÉÉÉÉ): ");
            ev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a hónapot (név szerint pontosan): ");
            honapneve = Console.ReadLine();
            Console.Write("Kérem adja meg a napot (1-31): ");
            napok = Convert.ToInt32(Console.ReadLine());
        }

        public void feltoltesMin()
        {
            for (int i = 0; i < azonosit.GetLength(0); i++)
            {
                for (int j = 0; j < azonosit.GetLength(1); j++)
                {
                    switch (honapneve)
                    {
                        case "január": azonosit[i, j] = maxho.Next(-20, 0); break;
                        case "február": azonosit[i, j] = maxho.Next(-20, 0); break;
                        case "március": azonosit[i, j] = maxho.Next(0, 15); break;
                        case "április": azonosit[i, j] = maxho.Next(0, 15); break;
                        case "május": azonosit[i, j] = maxho.Next(0, 15); break;
                        case "június": azonosit[i, j] = maxho.Next(10, 20); break;
                        case "július": azonosit[i, j] = maxho.Next(10, 20); break;
                        case "augusztus": azonosit[i, j] = maxho.Next(10, 20); break;
                        case "szeptember": azonosit[i, j] = maxho.Next(20, 40); break;
                        case "október": azonosit[i, j] = maxho.Next(20, 40); break;
                        case "november": azonosit[i, j] = maxho.Next(20, 40); break;
                        case "december": azonosit[i, j] = maxho.Next(-20, 0); break;
                    }
                }
            }
        }

        public void feltoltesMax()
        {
            for (int i = 0; i < azonosit2.GetLength(0); i++)
            {
                for (int j = 0; j < azonosit2.GetLength(1); j++)
                {
                    switch (honapneve)
                    {
                        case "január": azonosit2[i, j] = minho.Next(0, 10); break;
                        case "február": azonosit2[i, i] = minho.Next(0, 10); break;
                        case "március": azonosit2[i, j] = minho.Next(15, 25); break;
                        case "április": azonosit2[i, j] = minho.Next(15, 25); break;
                        case "május": azonosit2[i, j] = minho.Next(15, 25); break;
                        case "június": azonosit2[i, j] = minho.Next(10, 20); break;
                        case "július": azonosit2[i, j] = minho.Next(10, 20); break;
                        case "augusztus": azonosit2[i, j] = minho.Next(10, 20); break;
                        case "szeptember": azonosit2[i, j] = minho.Next(5, 15); break;
                        case "október": azonosit2[i, j] = minho.Next(5, 15); break;
                        case "november": azonosit2[i, j] = minho.Next(5, 15); break;
                        case "december": azonosit2[i, j] = minho.Next(0, 10); break;
                    }
                }
            }
        }

        public void kiValasztasMin()
        {
            for (int i = 0; i < azonosit.GetLength(0);)
            {
                switch (honapneve)
                {
                    case "január": i = 0; break;
                    case "február": i = 1; break;
                    case "március": i = 2; break;
                    case "április": i = 3; break;
                    case "május": i = 4; break;
                    case "június": i = 5; break;
                    case "július": i = 6; break;
                    case "augusztus": i = 7; break;
                    case "szeptember": i = 8; break;
                    case "október": i = 9; break;
                    case "november": i = 10; break;
                    case "december": i = 11; break;
                }
                for (int j = 1; j < azonosit.GetLength(1);)
                {
                    napok = j;
                    Console.WriteLine("A minimum hőmérséklet: {0}", azonosit[j, i]);
                    break;
                }
            }
        }

        public void kiValasztasMax()
        {
            for (int i = 0; i < azonosit.GetLength(0);)
            {
                switch (honapneve)
                {
                    case "január": i = 0; break;
                    case "február": i = 1; break;
                    case "március": i = 2; break;
                    case "április": i = 3; break;
                    case "május": i = 4; break;
                    case "június": i = 5; break;
                    case "július": i = 6; break;
                    case "augusztus": i = 7; break;
                    case "szeptember": i = 8; break;
                    case "október": i = 9; break;
                    case "november": i = 10; break;
                    case "december": i = 11; break;
                }
                for (int j = 1; j < azonosit.GetLength(1);)
                {
                    j = napok;
                    Console.WriteLine("A maximum hőmérséklet: {0}", azonosit[j, i]);
                    break;
                }
            }

            //public void randomHo()
            //{
            //    if (honapneve == "december" || honapneve == "január" || honapneve == "február") {
            //        min_homerseklet = minho.Next(-20, 0);
            //        max_homerseklet = maxho.Next(0, 10);
            //    } else if (honapneve == "március" || honapneve == "április" || honapneve == "május")
            //    {
            //        min_homerseklet = minho.Next(0, 15);
            //        max_homerseklet = maxho.Next(15, 25);
            //    } else if (this.honapneve == "június" || this.honapneve == "július" || this.honapneve == "augusztus")
            //    {
            //        min_homerseklet = minho.Next(10, 20);
            //        max_homerseklet = maxho.Next(20, 40);
            //    } else if (this.honapneve == "szeptember" || this.honapneve == "október" || this.honapneve == "november")
            //    {
            //        min_homerseklet = minho.Next(5, 10);
            //        max_homerseklet = maxho.Next(10, 25);
            //    }
            //    Console.WriteLine("A dátum: {0}.{1}.{2}.", this.ev, this.honapneve, this.napok);
            //    Console.Write("A minimum hőmérséklet: {0}", min_homerseklet);
            //    Console.Write("\nA maximum hőmérséklet: {0}", max_homerseklet);
            //   }

            //public int getMinHom()
            //{
            //    return min_homerseklet;
            //}

            //public int getMaxHom()
            //{
            //    return max_homerseklet;
            //}
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Meghívások
                Idojaras osztaly = new Idojaras();
                osztaly.datumBekeres();
                osztaly.feltoltesMax();
                osztaly.feltoltesMin();
                osztaly.kiValasztasMax();
                osztaly.kiValasztasMin();
                Console.ReadKey();
            }
        }
    }
}