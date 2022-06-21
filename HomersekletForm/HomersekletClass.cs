using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomersekletForm
{
    internal class HomersekletClass
    {
        private string nev;
        private int kHom,
            minHom,
            maxHom;

        // Konstruktor
        public HomClass(string sor)
        {
            string[] d = sor.Split(';');
            nev = d[0];
            kHom = Convert.ToInt32(d[1]);
            maxHom = Convert.ToInt32(d[2]);
            minHom = kHom - (maxHom - kHom);
        }
    }
}
