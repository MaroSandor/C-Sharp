﻿using System;
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
                felsoHatar = 50, //Véletlen szám felső határa
                gondoltSzam,
                tippAlsohatar,
                tippFelsohatar,
                tipp,
                probal = 5; //Próbálkozások maximális száma

            char valaszom; // A gép tippjére adott válaszom: következő értéket veheti fel: k (kisebbre gondoltam), n (nagyobbra gondoltam), t (eltaláltad)

            bool eltalalta = false;

            Random rnd = new Random();

            //Játék ismétlése
            do
            {
                //Megkérdezem, hogy ki lesz a kitaláló
                Console.WriteLine("Leszel az, aki gondol egy számra? (i/n)");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    //Ha a gép a kitaláló
                    //Gép generálja a számot
                    eltalalta = false;
                    gondoltSzam = rnd.Next(alsoHatar, felsoHatar);
                    //A gép gondol egy számot és a játékosnak kell kitalálni, max 5 próbálkozás.
                    for (int i = 0; i <= probal; i++)
                    {
                        //tipp beírása
                        Console.WriteLine("\nAdja meg a tippjét!");
                        tipp = int.Parse(Console.ReadLine());
                        //ha nagyobb a tipp.
                        if (tipp > gondoltSzam)
                        {
                            Console.WriteLine("\nA gondolt szám kisebb!");
                        }
                        //Ha kisebb a tipp.
                        else if (tipp < gondoltSzam)
                        {
                            Console.WriteLine("\nA gondolt szám nagyobb!");
                        }
                        //ha pontos a tipp.
                        else
                        {
                            eltalalta = true;
                            Console.WriteLine("\nA tipp helyes! Eltaláltad!");
                            break;
                        }
                    }
                    if (!eltalalta)
                    {
                        Console.WriteLine("Sajnos nem találtad el!");
                    }
                }
                else // Ha a játékos a kitaláló
                {
                    // Megadom a kezdeti értéket
                    eltalalta = false;

                    // Tippelési határok beállítása
                    tippAlsohatar = alsoHatar;
                    tippFelsohatar = felsoHatar;

                    // A gép max probal értékig tippel
                    for (int i = 0; i <= probal; i++)
                    {
                        // A gép tippjének meghatározása
                        Console.WriteLine("\nGondolj egy számra!");
                        tipp = tippAlsohatar + (tippFelsohatar - tippAlsohatar) / 2;
                        Console.WriteLine("Az én tippem: {0}", tipp);

                        // Kiértékelem a tippet, megadom a választ
                        valaszom = Console.ReadKey().KeyChar;
                        if (valaszom == 'n')
                        {
                            Console.WriteLine("\nNagyobbra gondoltam!");
                            tippAlsohatar = tipp;
                        } else if (valaszom == 'k')
                        {
                            Console.WriteLine("\nKisebbre gondoltam!");
                            tippFelsohatar = tipp;
                        } else
                        {
                            eltalalta = true;
                            Console.WriteLine("\nEltaláltad!");
                            break;
                        }
                    }

                    // Ha nem találta el, akkor ezt írom ki
                    if (!eltalalta)
                    {
                        Console.WriteLine("Sajnos nem találtad el!");
                    }
                }
                //kérdés h akarsz-e újra játszani
                Console.WriteLine("\nFolytatjuk a játékot? (i/n)");
            } while (Console.ReadKey(true).KeyChar == 'i');
        }
    }
}
