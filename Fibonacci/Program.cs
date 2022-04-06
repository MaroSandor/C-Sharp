using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        public Fibonacci() { }

        private int szam,
            a = 0,
            b = 1;
        private int[] fibonacciszamok;

        public void feltoltes()
        {
            Console.Write("Kérem adja meg, hogy hány számot szeretne kiíratni: ");
            szam = Convert.ToInt32(Console.ReadLine());

            fibonacciszamok = new int[szam];

            Console.WriteLine("A Fibonacci-sorozat számai {0}-ig:", szam);
            Console.Write("{0} {1} ", a, b);

            for (int i = 1; i < szam; i++)
            {
                fibonacciszamok[i] += fibonacciszamok[i - 1] + fibonacciszamok[i];
            }

            foreach (var item in fibonacciszamok)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci osztaly = new Fibonacci();
            osztaly.feltoltes();
            Console.ReadKey();
        }
    }
}
