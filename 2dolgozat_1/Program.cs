using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dolgozat_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double paros = 0,
                paratlan = 0;

            Random rnd = new Random();

            N = rnd.Next(4, 11);

            int[] tomb = new int[N];

            Console.WriteLine("Kérem adjon meg {0} számot!", N);

            for (int i = 0; i < N; i++)
            {
                tomb[i] = int.Parse(Console.ReadLine());

                if (tomb[i] % 2 == 0)
                {
                    paros++;
                } else if (tomb[i] % 2 == 1)
                {
                    paratlan++;
                }
            }
            Console.WriteLine("A páratlan számok száma: {0}, a páros számok száma: {1}.", paratlan, paros);

            Console.ReadKey();
        }
    }
}
