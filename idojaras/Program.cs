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
        private int napok;
        private string honapneve;
        private int[,] minHok = new int[12, 30];
        private int[,] maxHok = new int[12, 30];
        private string[] honapok = new string[] { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
        Random maxho = new Random();
        Random minho = new Random();

        public Idojaras() { }

        public void datumBekeres()
        {
            Console.Write("Kérem adja meg a hónapot (betűvel helyesen): ");
            honapneve = Console.ReadLine();
            Console.Write("Kérem adja meg a napot (1-31): ");
            napok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nA megadott dátum: {0} {1}.", honapneve, napok);
        }

        public void feltoltesMin()
        {
            for (int i = 0; i < minHok.GetLength(0); i++)
            {
                for (int j = 0; j < minHok.GetLength(1); j++)
                {
                    switch (honapok[i])
                    {
                        case "január": minHok[i, j] = maxho.Next(-20, 0); break;
                        case "február": minHok[i, j] = maxho.Next(-20, 0); break;
                        case "március": minHok[i, j] = maxho.Next(0, 15); break;
                        case "április": minHok[i, j] = maxho.Next(0, 15); break;
                        case "május": minHok[i, j] = maxho.Next(0, 15); break;
                        case "június": minHok[i, j] = maxho.Next(10, 20); break;
                        case "július": minHok[i, j] = maxho.Next(10, 20); break;
                        case "augusztus": minHok[i, j] = maxho.Next(10, 20); break;
                        case "szeptember": minHok[i, j] = maxho.Next(20, 40); break;
                        case "október": minHok[i, j] = maxho.Next(20, 40); break;
                        case "november": minHok[i, j] = maxho.Next(20, 40); break;
                        case "december": minHok[i, j] = maxho.Next(-20, 0); break;
                    }
                }
            }
        }

        public void feltoltesMax()
        {
            for (int i = 0; i < maxHok.GetLength(0); i++)
            {
                for (int j = 0; j < maxHok.GetLength(1); j++)
                {
                    switch (honapok[i])
                    {
                        case "január": maxHok[i, j] = minho.Next(0, 10); break;
                        case "február": maxHok[i, i] = minho.Next(0, 10); break;
                        case "március": maxHok[i, j] = minho.Next(15, 25); break;
                        case "április": maxHok[i, j] = minho.Next(15, 25); break;
                        case "május": maxHok[i, j] = minho.Next(15, 25); break;
                        case "június": maxHok[i, j] = minho.Next(10, 20); break;
                        case "július": maxHok[i, j] = minho.Next(10, 20); break;
                        case "augusztus": maxHok[i, j] = minho.Next(10, 20); break;
                        case "szeptember": maxHok[i, j] = minho.Next(5, 15); break;
                        case "október": maxHok[i, j] = minho.Next(5, 15); break;
                        case "november": maxHok[i, j] = minho.Next(5, 15); break;
                        case "december": maxHok[i, j] = minho.Next(0, 10); break;
                    }
                }
            }
        }

        public void kiValasztasMin()
        {
            int i = 0;
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
                    Console.WriteLine("A napi minimum hőmérséklet: {0} °C", minHok[i, napok-1]);
        }

        public void kiValasztasMax()
        {
            int i = 0;
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
                    Console.WriteLine("\nA napi maximum hőmérséklet: {0} °C", maxHok[i, napok-1]);
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