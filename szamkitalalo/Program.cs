using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
        START:

            Console.WriteLine("Válassz!");
            Console.WriteLine("1 - Játékosmód");
            Console.WriteLine("2- Számítógépmód");

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': goto PLAYER;
                case '2': goto PC;
            }

        PLAYER: goto JATEKOS;
        PC: goto PC;

        JATEKOS:

            Console.WriteLine("Akarsz még játszani? i/n");

            switch (Console.ReadKey(true).KeyChar)
            {
                case 'n': break;
                default: goto JATEKOS;
            }

            Console.WriteLine("Gondolj egy számra! (1-100)");
            int kitalalt = int.Parse(Console.ReadLine());

            Random r = new Random();

            int min = 0;
            int max = 100;
            int i = 0;
            int szam = r.Next(100);

            while (i < 5) {
                Console.WriteLine("A számítógép szerint a szám: {0}", szam);
                Console.WriteLine("Kisebb, nagyobb vagy egyenlő? (k/n/e)");
                
                switch (Console.ReadKey().KeyChar)
                {
                    case 'k':
                        Console.WriteLine("A szám kisebb!");
                        szam = r.Next(min, kitalalt);
                        break;
                    case 'n':
                        Console.WriteLine("A szám nagyobb!");
                        szam = r.Next(kitalalt, max);
                        break;
                    case 'e':
                        Console.WriteLine("A gép eltalálta!");
                        break;
                }
                i++;
                Console.ReadKey();
            }
            
        }
    }
}
