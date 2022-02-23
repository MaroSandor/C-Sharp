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
            int huszezer = 0,
                tizezer = 0,
                otezer = 0,
                ketezer = 0,
                ezer = 0,
                otszaz = 0,
                ketszaz = 0,
                szaz = 0,
                otven = 0,
                husz = 0,
                tiz = 0,
                ot = 0,
                penzertek;

            Console.WriteLine("Írja be az összeget!");
            penzertek = int.Parse(Console.ReadLine());

            switch (penzertek)
            {
                case 20000:
                    huszezer = penzertek / 20000;
                    break;
                case 10000:
                    tizezer = penzertek % 10000;
                    break;
            }

            Console.WriteLine("20000 forintos címletből {0} db kell!", huszezer);
            Console.ReadKey();
        }
    }
}
