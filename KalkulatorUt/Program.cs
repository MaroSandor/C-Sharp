using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorUt
{
    public class Calculator
    {
        private int szam1;
        private int szam2;
        private char muvelet;

        public Calculator() { }

        public int szamitas(int szam1, int szam2, char muvelet)
        {
            int ertek = 0;

            switch (muvelet)
            {
                case '+':
                    ertek = szam1 + szam2;
                    break;
                case '-':
                    ertek = szam1 - szam2;
                    break;
                case '*':
                    ertek = szam1 * szam2;
                    break;
                case '/':
                    if (szam2 == 0)
                    {
                        ertek = szam1 / szam2;
                        return ertek;
                    } else
                    {
                        ertek = szam1 / szam2;
                        break;
                    }
            }

            return ertek;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}