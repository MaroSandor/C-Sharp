using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dolgozat_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,
                b,
                ertek = 0;

            Console.WriteLine("Adja meg az intervallum kezdőértékét!");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg az intervallum végőértékét!");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("5-tel osztható számok: ");

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(" {0}", i);
                }
            }
            

            Console.ReadKey();

        }
    }
}
