using System;
using System.IO;
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
        public void Dodaj_do_rachunku(string plik)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(plik,true);
                sw.WriteLine($"Danie\t{kategoria}\t{danie}\t{cena}\t|");
            }
            catch(Exception error) { Console.WriteLine(error); }
            finally { if(sw!=null) sw.Close(); }
        }
    }
}
