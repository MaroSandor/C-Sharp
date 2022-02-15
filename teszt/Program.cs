using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 10;
            long nagyszam = 1550;
            nagyszam = szam;
            szam = (int)nagyszam;
        }
    }
}
