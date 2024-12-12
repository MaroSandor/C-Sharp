using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipusellenorzes
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 100.1;
            Console.WriteLine(i.GetType().FullName);
            Console.WriteLine(typeof(int).Name);
            if (i.GetType() == typeof(int))
                Console.WriteLine("Both are same");
            else
                Console.WriteLine("Both are not same");
            Console.ReadKey();
        }
    }
}
