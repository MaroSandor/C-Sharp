using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimletezes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int[,] cimletek = new int[,] { { 20000, 0 }, { 10000, 0 }, { 5000, 0 }, { 2000, 0 }, { 1000, 0 }, { 500, 0 }, { 200, 0 }, { 100, 0 }, { 50, 0 }, { 20, 0 }, { 10, 0 }, { 5, 0 } };
            int penzertek;

            Console.WriteLine("Írja be az összeget!");
            penzertek = int.Parse(Console.ReadLine());

            for (int i = 0; i < cimletek.GetLength(0); i++)
            {
                if (penzertek >= cimletek[i, 0])
                {
                    if (penzertek != 0)
                    {
                        cimletek[i, 1] = penzertek / cimletek[i, 0];
                        penzertek = penzertek % cimletek[i, 0];
                    } else
                    {
                        break;
                    }
                }

                Console.WriteLine("{0} forintos címletből {1} db kell!", cimletek[i, 0], cimletek[i, 1]);
            }

            
            Console.ReadKey();
        }
    }
}
