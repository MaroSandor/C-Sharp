using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oszthato
{
    class Program
    {
        static void Main(string[] args)
        {
            Osztas osztaly = new Osztas(10);
            osztaly.setSzam();
            osztaly.getSzam3();
            osztaly.getSzam5();
            Console.ReadKey();
        }
    }
}
