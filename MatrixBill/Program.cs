// Máró Sándor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill
{
    class Matrix
    {
        private int sor,
            oszlop,
            elemek;
        private int[,] tomb;

        public Matrix() { }

        public void bekeres()
        {
            Console.WriteLine("Adja meg a mátrix sorainak számát:");
            sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a mátrix oszlopainak számát:");
            oszlop = Convert.ToInt32(Console.ReadLine());

            int[,] tomb = new int[sor, oszlop];

            Console.WriteLine("Adja meg az elemeket:");

            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    elemek = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void kiiratas()
        {
            int
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.WriteLine("{0, 4} ", tomb[i, j]);
                }
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
