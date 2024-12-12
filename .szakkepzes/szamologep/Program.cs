using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1;
            int szam2;
            char muvelet;

            if (args.Length == 0)
            {
                Console.WriteLine("Adja meg az első számot!");
                szam1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Adja meg a műveleti jelet!");
                muvelet = Convert.ToChar(Console.Read());
                Console.WriteLine("Adja meg a második számot!");
                szam2 = int.Parse(Console.ReadLine());
            }
            else
            {
                if (args.Length != 3)
                {
                    Console.WriteLine("Túl kevés a paraméter!");
                    return;
                }
                else
                {
                    szam1 = int.Parse(args[0]);
                    szam2 = int.Parse(args[1]);
                    muvelet = Convert.ToChar(args[2]);
                }
            }

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
                    ertek = szam1 / szam2;
                    break;
                default:
                    Console.WriteLine("Hibás műveleti jel.");
                    break;
            }
            Console.WriteLine("Az eredmény: {0}", ertek);

            Console.ReadKey();
        }
    }
}
