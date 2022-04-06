using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForeach
{
    class ForAndForeach
    {
        private int hossz = 0;
        private int[] tomb;

        private Random rnd = new Random();

        public ForAndForeach() { }

        public void forciklus()
        {
            Console.WriteLine("Adja meg a lista hosszát:");
            hossz = Convert.ToInt32(Console.ReadLine());

            tomb = new int[hossz];

            Console.WriteLine("A tömb elemei:");

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(100);

                Console.Write("{0}", tomb[i]);
            }
        }

        public void foreachciklus()
        {
            forciklus();

            Console.WriteLine("\nA tömb elemei:");

            foreach (var item in tomb)
            {
                Console.Write("{0} ", item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ForAndForeach osztaly = new ForAndForeach();
            osztaly.foreachciklus();
            Console.ReadKey();
        }
    }
}
