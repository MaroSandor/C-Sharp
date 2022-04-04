using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        private int generalando,
            szam;
        private List<ulong> fibonacci = new List<ulong> ();

        public Fibonacci()
        {
            this.szam = generalando;
        }

        public void bekeres()
        {
            Console.WriteLine("Adja meg, hogy hány Fibonacci számot szeretne kiírni:");
            generalando = Convert.ToInt32(Console.ReadLine());
        }

        public void sorozat()
        {
            ulong kezdo = 0;
            for (int i = 0; i < this.szam; i++)
            {
                fibonacci.Add();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci osztaly = new Fibonacci();
            osztaly.bekeres();
            osztaly.sorozat();
            Console.ReadKey();
        }
    }
}
