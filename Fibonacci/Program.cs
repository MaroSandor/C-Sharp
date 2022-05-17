using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonaci
    {
        private int szam,
            a = 0,
            b = 1,
            osszeg;
        private int[] fibonacciszamok;

        public Fibonaci()
        {
            this.szam = szam;
            this.osszeg = osszeg;
        }

        public int feltoltes(int szam)
        {
            Console.Write("Kérem adja meg, hogy hány számot szeretne kiíratni: ");
            szam = Convert.ToInt32(Console.ReadLine());

            fibonacciszamok = new int[this.szam];

            Console.WriteLine("A Fibonacci-sorozat számai {0}-ig:", this.szam);
            Console.Write("{0} {1} ", a, b);

            for (int i = 1; i < this.szam; i++)
            {
                fibonacciszamok[i] =+ fibonacciszamok[i - 1] + fibonacciszamok[i];
            }

            foreach (var item in fibonacciszamok)
            {
                Console.WriteLine(item);
            }

            foreach (var item in fibonacciszamok)
            {
                osszeg =+ item;
            }

            return this.osszeg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibonaci osztaly = new Fibonaci();
            osztaly.feltoltes(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
