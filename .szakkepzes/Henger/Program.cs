using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    public class Hengera
    {
        public double magassag { set; get; }

        public double sugar { set; get; }

        public Hengera(double magassag, double sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
        }

        public double setSugar()
        {
            sugar = Convert.ToDouble(Console.ReadLine());
            return this.sugar;
        }

        public double setMagassag()
        {
            magassag = Convert.ToDouble(Console.ReadLine());
            return this.magassag;
        }

        public double Kerulet()
        {
            return 2 * this.sugar * Math.PI;
        }

        public double Terulet()
        {
            return Math.Pow(this.sugar, 2) * Math.PI;
        }

        public double Terfogat()
        {
            return (Math.Pow(this.sugar, 2) * Math.PI) * this.magassag;
        }

        public double Felszin()
        {
            return 2 * (Math.Pow(this.sugar, 2) * Math.PI) + (2 * this.sugar * Math.PI) * this.magassag;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
