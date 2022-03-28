using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetelkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            do
            {
                try
                {
                    Console.WriteLine("Adj egy számot!");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException a)
                {
                    Console.WriteLine("Számot kérek!", a);
                }
            } while ();
        }
    }
}
