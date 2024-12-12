using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szigetek
{
    public class Sziget
    {
        public Sziget() { }

        string data;

        public int szigetszam(string data)
        {
            Console.WriteLine("Adja meg a karaktersorozatot!");
            int islandCount = 0;
            int maxIslandLength = 0;
            int i = 0;
            while (i < data.Length)
            {
                if (data[i] == '1')
                {
                    ++islandCount;
                    int j = i;
                    int tmp = 0;
                    while (j < data.Length && data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > maxIslandLength) { maxIslandLength = tmp; }
                }
                else
                {
                    ++i;
                }
            }
            Console.WriteLine("A szigetek száma: {0}", islandCount);

            return islandCount;
        }

        public int szigethossz(string data)
        {
            Console.WriteLine("Adja meg a karaktersorozatot!");
            int islandCount = 0;
            int maxIslandLength = 0;
            int i = 0;
            while (i < data.Length)
            {
                if (data[i] == '1')
                {
                    ++islandCount;
                    int j = i;
                    int tmp = 0;
                    while (j < data.Length && data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > maxIslandLength) { maxIslandLength = tmp; }
                }
                else
                {
                    ++i;
                }
            }
            Console.WriteLine("A leghosszabb sziget hossza: {0} km", maxIslandLength);

            return maxIslandLength;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
