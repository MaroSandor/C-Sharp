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

            //Változók
            int alsoHatar = 1, //Véletlen szám alsó határa
                felsoHatar = 100, //Véletlen szám felső határa
                gondoltSzam,
                tipp,
                probal = 5; //Próbálkozások maximális száma

            Random rnd = new Random();

            //Játék ismétlése
            do
            {
                //Megkérdezem, hogy ki lesz a kitaláló
                Console.WriteLine("Leszel az aki gondol egy számra? (i/n)");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    //Ha a játékos a kitaláló
                    //Gép generálja a számot
                    gondoltSzam = rnd.Next(alsoHatar, felsoHatar);
                    //A gép gondol egy számot és a játékosnak kell kitalálni, max 5 próbálkozás.
                    for (int i = 0; i < probal+1; i++)
                    {
                        //tipp beírása
                        tipp = int.Parse(Console.ReadLine());
                        //ha nagyobb a tipp.
                        //Ha kisebb a tipp.
                        //ha pontos a tipp.
                    }
                    //ha k/n akkor uj tipp iras
                }
                else
                {
                    //Ha a gép a kitaláló
                    //A Játékos gondol egy számot és a játékosnak kell kitalálni, max 5 próbálkozás.
                    //szám meghatározása
                    //ha nagyobb a tipp.
                    //Ha kisebb a tipp.
                    //ha pontos a tipp.
                    //ha k/n akkor uj tipp kiertekeles
                }
                //kérdés h akarsz-e újra játszani
                Console.WriteLine("Folytatjuk a játékot? (i/n)");
            } while (Console.ReadKey(true).KeyChar == 'i');
            // sor kiirtekeles
            Console.ReadKey();

            //// Alapszerkezet
            //// Változók
            //int alsoHatar = 0, // Véletlenszám alsó határa
            //    felsoHatar = 100, // Véletlenszám felső határa
            //    probak = 5; // próbálkozások száma
            //string valasz = Console.ReadLine(); // deklarált változóhoz rendelt szöveg bekérése -> ReadLine() paranccsal

            //// Random szám generálása
            //Random pcSzam = new Random(); // Random [név] = new Random()

            //// Ismétlés
            //do
            //{
            //    // Kiiratás
            //    Console.WriteLine("Válassz a játkmódok közül!"); // Console.WriteLine(<- kurzor új sorba ugrik)([név, változó vagy amit ki szeretnénk íratni])
            //    Console.WriteLine("1 - Játékos mód (a játékos a kitaláló)"); // Console.WriteLine(<- kurzor új sorba ugrik)([név, változó vagy amit ki szeretnénk íratni])
            //    Console.WriteLine("2 - Gépi mód (a gép a kitaláló)"); // Console.WriteLine(<- kurzor új sorba ugrik)([név, változó vagy amit ki szeretnénk íratni])

            //    // Bekérés
            //    int mod = Console.ReadKey(true).KeyChar; // deklarált változóhoz rendelt karakterbekérés (ha ez igaz, akkor a bekért karakter nem jelenik meg a konzolban, csak rejtett marad)

            //    // Vizsgálat
            //    if (mod == '1')
            //    {

            //    }
            //    else if (mod == '2')
            //    {

            //    }
            //    else
            //    {
            //        Console.WriteLine("Ilyen játékmód nincs!");
            //    }
            //} while (valasz != "nem");

            //Console.ReadKey();
        }
    }
}
