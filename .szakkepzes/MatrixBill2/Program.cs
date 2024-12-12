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
            oszlop;
        private int[,] tomb;

        public Matrix() { }

        public void bekeres()
        {
            Console.WriteLine("Adja meg a mátrix sorainak számát:");
            sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a mátrix oszlopainak számát:");
            oszlop = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adja meg az elemeket:");

            tomb = new int[sor, oszlop];

            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    tomb[i, j] = Convert.ToInt32(Console.ReadLine());
                }

                for (int d = 0; d < tomb.GetLength(1); d++)
                {
                    Console.Write(tomb[i, d] + " ");
                }
                Console.WriteLine();
            }
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