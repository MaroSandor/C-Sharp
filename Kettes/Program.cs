using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes
{
    class Kettes
    {
        private int bekertszam;
        private string atvaltott;

        public Kettes() { }

        public void atvalto()
        {
            Console.WriteLine("Adja meg az átváltandó tízes számrendszerbeli számot:");
            bekertszam = Convert.ToInt32(Console.ReadLine());
            atvaltott = Convert.ToString(bekertszam, 2);
            Console.WriteLine("A kettes számrendszerbeli szám:");
            Console.Write(atvaltott);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kettes a = new Kettes();
            a.atvalto();
            Console.ReadKey();
        }
    }
}
