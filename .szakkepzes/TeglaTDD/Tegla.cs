﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeglaTDD
{
    public class Tegla
    {
        private int szel,
            hossz,
            mag;

        public void setTegla(int szel, int hossz, int mag)
        {
            this.szel = szel;
            this.hossz = hossz;
            this.mag = mag;
        }

        public Tegla()
        {
            // Konstruktor
        }

        public int getTerfogat()
        {
            return szel * hossz * mag;
        }

        public int getFelszin()
        {
            return 2 * (szel * hossz + szel * mag + hossz * mag);
        }
    }
}
