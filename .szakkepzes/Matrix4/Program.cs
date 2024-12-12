using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix4
{
    class Matrix
    {
        private int sor,
            oszlop,
            sorindex,
            oszlopindex,
            szam;
        private int[,] tomb;
        private bool[,] vizsgal;
        private string beolvasas;
        private string[] beolvasott;

        public Matrix() { }

        public void bekeres()
        {
            Console.WriteLine("Adja meg a mátrix sorainak számát:");
            sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a mátrix oszlopainak számát:");
            oszlop = Convert.ToInt32(Console.ReadLine());

            tomb = new int[sor, oszlop];

            do
            {
                Console.WriteLine("Adja meg az elemeket így: sor index, oszlop index, szám");

                beolvasas = Console.ReadLine();

                if (beolvasas == "")
                {
                    Console.WriteLine("A hely nem lehet üres!");
                } else {
                string[] beolvasott = beolvasas.Split(',');

                sorindex = Convert.ToInt32(beolvasott[0].ToString()) - 1;
                oszlopindex = Convert.ToInt32(beolvasott[1].ToString()) - 1;
                szam = Convert.ToInt32(beolvasott[2]);
                }
            } while (beolvasas != "");
        }

        public void kiiratas()
        {
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    Console.Write("{0, 4} ", tomb[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Matrix osztaly = new Matrix();
            osztaly.bekeres();
            osztaly.kiiratas();
            Console.ReadKey();
        }
    }
}
