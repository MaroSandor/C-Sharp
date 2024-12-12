using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oszthato
{
    public class Osztas
    {
        public int bekertSzam,
            bekertErtek;

        public int Szam { get; set; }

        public Osztas(int bekertSzam)
        {
            this.bekertErtek = bekertSzam;
        }

        public int setSzam()
        {
            do
            {
                Console.WriteLine("Kérem adja meg az osztandó számot!");
                this.bekertErtek = Convert.ToInt32(Console.ReadLine());
                if (this.bekertErtek.GetType() == typeof(int))
                {
                    break;
                } else
                {
                    Console.WriteLine("-------------------- HIBA --------------------");
                    Console.WriteLine("----- Kérem számot adjon meg! -----");
                    Console.WriteLine("-------------------------------------------------");
                }
            } while (this.bekertErtek.GetType() == typeof(int));
            return this.bekertErtek;
        }

        public string getSzam3()
        {
            if (this.bekertErtek % 3 == 0)
            {
                Console.WriteLine("három");
            }
            return "három";
        }

        public string getSzam5()
        {
            if (this.bekertErtek % 5 == 0)
            {
                Console.WriteLine("öt");
            } else
            {
                Console.WriteLine(this.bekertErtek);
                return Convert.ToString(this.bekertErtek);
            }
            return "öt";
        }
    }
}
