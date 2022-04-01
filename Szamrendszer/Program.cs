using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{
    class Szamrendszer
    {
        private int bekertszam,
            valasztas;
        private string atvaltott;
        private char valasz;

        public Szamrendszer() { }

        public void bekeres()
        {
            Console.WriteLine("Adja meg az átváltandó számot:");
            bekertszam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg, hogy hanyas számrendszerbe szeretné átváltani (2 / 8 / 16):");
            valasztas = Convert.ToInt32(Console.ReadLine());
        }

        public void atvaltas()
        {
            do
            {
                bekeres();
                switch (valasztas)
                {
                    case 2:
                        atvaltott = Convert.ToString(bekertszam, 2); break;
                    case 8:
                        atvaltott = Convert.ToString(bekertszam, 8); break;
                    case 16:
                        atvaltott = Convert.ToString(bekertszam, 16); break;
                    default:
                        Console.WriteLine("Nem tudom értelmezni a kérést!");
                        break;
                }

                if (valasztas == 2)
                {
                    Console.WriteLine("A kettes számrendszerbeli szám: {0}", atvaltott);
                }
                else if (valasztas == 8)
                {
                    Console.WriteLine("A nyolcas számrendszerbeli szám: {0}", atvaltott);
                }
                else if (valasztas == 16)
                {
                    Console.WriteLine("A tizenhatos számrendszerbeli szám: {0}", atvaltott);
                }
                else
                {
                    Console.WriteLine("Sajnos nem tudom átváltani!");
                }

                Console.WriteLine("Szeretnéd hogy átváltsak valamit még? ( i / n )");
                valasz = Convert.ToChar(Console.ReadLine());

            } while (valasz != 'n');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Szamrendszer a = new Szamrendszer();
            a.atvaltas();
        }
    }
}
