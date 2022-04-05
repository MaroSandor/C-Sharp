using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezersakk
{
    class Sakk
    {
        private int[] xtengely = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
        private int[] ytengely = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
        private int pos_a,
            pos_b;

        public Sakk() { }

        public void elhelyezes()
        {
            for (int i = 0; i < xtengely.Length; i++)
            {
                for (int j = 0; j < ytengely.Length; j++)
                {
                    if (i == 0 && j == 0)
                    {

                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
