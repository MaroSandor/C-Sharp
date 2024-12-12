using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtomegindex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók deklarálása
            double testsuly,
                testmagassag,
                testtomegindex;

            // Tömb létrehozása

            string[] testtomegosztaly = new string[] { "súlyos soványság", "mérsékelt soványság", "enyhe soványság", "normális testsúly", "túlsúlyos", "I. fokú elhízás", "II. fokú elhízás", "III. fokú elhízás" };

            // Adatok bekérése

            Console.WriteLine("Kérem adja meg a testsúlyát (kg)!");
            testsuly = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a testmagasságát (cm)!");
            testmagassag = int.Parse(Console.ReadLine());

            // Testtömeg-index kiszámítása

            testtomegindex = (testsuly / (testmagassag * testmagassag)) * 10000;

            // Vizsgálat

            if (testtomegindex < 16)
            {
                Console.WriteLine("A testtömeg indexe: {0}, {1}", testtomegindex, testtomegosztaly[0]);
            } else if (16 <= testtomegindex && testtomegindex <  16.99)
            {
                Console.WriteLine("A testtömeg indexe: {0}, {1}", testtomegindex, testtomegosztaly[1]);
            } else if (17 <= testtomegindex && testtomegindex < 18.49)
            {
                Console.WriteLine("A testtömeg indexe: {0}, {1}", testtomegindex, testtomegosztaly[2]);
            } else if (18.5 <= testtomegindex && testtomegindex < 25)
            {
                Console.WriteLine("A testtömeg indexe: {0}, {1}", testtomegindex, testtomegosztaly[3]);
            } else if (25 <= testtomegindex && testtomegindex < 30)
            {
                Console.WriteLine("A testtömeg indexe: {0}, {1}", testtomegindex, testtomegosztaly[4]);
            } else if (30 <= testtomegindex && testtomegindex < 35)
            {
                Console.WriteLine("A testtömeg indexe: {0}, {1}", testtomegindex, testtomegosztaly[5]);
            } else if (35 <= testtomegindex && testtomegindex < 40)
            {
                Console.WriteLine("A testtömeg indexe: {0}, {1}", testtomegindex, testtomegosztaly[6]);
            } else
            {
                Console.WriteLine("A testtömeg indexe: {0}, {1}", testtomegindex, testtomegosztaly[7]);
            }
            Console.ReadKey();
        }
    }
}
