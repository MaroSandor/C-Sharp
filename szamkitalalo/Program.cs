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
            //    int i = 0;
            //    Random randomszam = new Random();
            //    int szam = randomszam.Next(100);
            //START:

            //    Console.WriteLine("Válassz!");
            //    Console.WriteLine("1 - Játékosmód");
            //    Console.WriteLine("2- Számítógépmód");

            //    switch (Console.ReadKey(true).KeyChar)
            //    {
            //        case '1': goto PLAYER;
            //        case '2': goto PC;
            //    }

            //    PLAYER: goto JATEKOS;
            //    PC: goto AI;

            //JATEKOS:

            //    Console.WriteLine("Gondolj egy számra! (1-100)");
            //    int kitalalt = int.Parse(Console.ReadLine());

            //    int min = 0;
            //    int max = 100;

            //    while (i < 5) {
            //        Console.WriteLine("A számítógép szerint a szám: {0}", szam);
            //        Console.WriteLine("Kisebb, nagyobb vagy egyenlő? (k/n/e)");

            //        switch (Console.ReadKey().KeyChar)
            //        {
            //            case 'k':
            //                Console.WriteLine("A szám kisebb!");
            //                szam = randomszam.Next(min, kitalalt);
            //                break;
            //            case 'n':
            //                Console.WriteLine("A szám nagyobb!");
            //                szam = randomszam.Next(kitalalt, max);
            //                break;
            //            case 'e':
            //                Console.WriteLine("A gép eltalálta!");
            //                break;
            //        }
            //        i++;
            //    }

            //    Console.WriteLine("Akarsz még játszani? i/n");

            //    switch (Console.ReadKey(true).KeyChar)
            //    {
            //        case 'n': break;
            //        default: goto JATEKOS;
            //    }

            //    Console.ReadKey();

            //AI:

            //    Console.WriteLine("Gondoltam egy számra!");
            //    Console.WriteLine("A tipped:");
            //    int tipp = Console.ReadKey().KeyChar;

            //    if (tipp < szam)
            //    {
            //        Console.WriteLine("A szám nagyobb!");
            //    } else if (szam < tipp)
            //    {
            //        Console.WriteLine("A szám kisebb!");
            //    } else
            //    {
            //        Console.WriteLine("Találat!");
            //    }
            // Alapszerkezet

            int i = 0;
            Random pcSzam = new Random();

            Console.WriteLine("Válassz a játkmódok közül!");
            Console.WriteLine("1 - Játékos mód");
            Console.WriteLine("2 - Gépi mód");
            int mod = Console.ReadKey(true).KeyChar;

            if (mod == 1)
            {

            }
            else if (mod == 2)
            {

            }
            else
            {
                Console.WriteLine("Ilyen játékmód nincs!");
            }

            Console.ReadKey();
        }
    }
}
