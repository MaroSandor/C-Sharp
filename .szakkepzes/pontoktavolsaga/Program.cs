using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pontoktavolsaga
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int a1,
                a2,
                b1,
                b2;
            double tavolsag;

            // Feladat fő része
            Console.WriteLine("Kérem az első pont koordinátáit!");
            a1 = int.Parse(Console.ReadLine());
            a2 = int.Parse(Console.ReadLine());
            b1 = int.Parse(Console.ReadLine());
            b2 = int.Parse(Console.ReadLine());

            tavolsag = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2));

            Console.WriteLine("A két pont távolsága: {0}", tavolsag);
            Console.ReadKey();
        }
    }
}
