using System;
using System.Collections.Generic;
using System.Text;

namespace WaiterApp
{
    internal class Danie
    {
        string danie, kategoria;
        double cena;

        public Danie(string danie, string kategoria, double cena)
        {
            this.danie = danie;
            this.kategoria = kategoria;
            this.cena = cena;
        }
    }
}
