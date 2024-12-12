// Máró Sándor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto
    {
        private int bekertszam;

        Random lottoszamok = new Random();

        public Lotto() { }

        public void lottosorsolas()
        {
            Console.WriteLine("Adja meg hanyas lottó számait szeretné megtudni:");
            Console.WriteLine("5 - Ötös lottó");
            Console.WriteLine("6 - Hatos lottó");
            Console.WriteLine("7 - Hetes lottó");
            bekertszam = Convert.ToInt32(Console.ReadLine());

            int[] tomb = new int[bekertszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = lottoszamok.Next(1, 91);
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] == tomb[i])
                    {
                        --i;
                        break;
                    }
                }
            }

            Console.WriteLine("A nyerőszámok: ");

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0} ", tomb[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lotto a = new Lotto();
            a.lottosorsolas();
            Console.ReadKey();
        }
    }
}
