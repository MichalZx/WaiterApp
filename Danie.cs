using System;
using System.Collections.Generic;
using System.Text;

namespace WaiterApp
{
    internal class Danie
    {
        string danie, kategoria;
        int cena;

        public Danie(string danie, string kategoria, int cena)
        {
            this.danie = danie;
            this.kategoria = kategoria;
            this.cena = cena;
        }
    }
}
