// Máró Sándor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes
{
    public class Ketteske
    {
        private int bekertszam;
        private string atvaltott;

        public Ketteske()
        {
            this.bekertszam = bekertszam;
        }

        public string atvalto(int bekertszam)
        {
            Console.WriteLine("Adja meg az átváltandó tízes számrendszerbeli számot:");
            atvaltott = Convert.ToString(bekertszam, 2);
            Console.WriteLine("A kettes számrendszerbeli szám: {0}", atvaltott);

            return this.atvaltott;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ketteske a = new Ketteske();
            a.atvalto(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
