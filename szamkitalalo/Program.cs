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
            //Változók
            int alsoHatar = 1, //Véletlen szám alsó határa
                felsoHatar = 11, //Véletlen szám felső határa
                gondoltSzam,
                tipp,
                probal = 5; //Próbálkozások maximális száma

            Random rnd = new Random();

            //Játék ismétlése
            do
            {
                //Megkérdezem, hogy ki lesz a kitaláló
                Console.WriteLine("Leszel az, aki gondol egy számra? (i/n)");
                if (Console.ReadLine() == "n")
                {
                    //Ha a játékos a kitaláló
                    //Gép generálja a számot
                    gondoltSzam = rnd.Next(alsoHatar, felsoHatar);
                    //A gép gondol egy számot és a játékosnak kell kitalálni, max 5 próbálkozás.
                    for (int i = 0; i <= probal; i++)
                    {
                        //tipp beírása
                        Console.WriteLine("Adja meg a tippjét!");
                        tipp = int.Parse(Console.ReadLine());
                        //ha nagyobb a tipp.
                        if (tipp > gondoltSzam)
                        {
                            Console.WriteLine("A gondolt szám kisebb!");
                        }
                        //Ha kisebb a tipp.
                        else if (tipp < gondoltSzam)
                        {
                            Console.WriteLine("A gondolt szám nagyobb!");
                        }
                        //ha pontos a tipp.
                        else
                        {
                            Console.WriteLine("A tipp helyes! Eltaláltad!");
                            break;
                        }
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
        }
    }
}
