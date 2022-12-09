using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WaiterApp
{
    /// <summary>
    /// Logika interakcji dla klasy Dania.xaml
    /// </summary>
    public partial class Dania : Window
    {
        int numerStolika, iloscGosci;
        bool prio;

        private void classicBurger_Click(object sender, RoutedEventArgs e)
        {
            Danie classicBurger = new Danie("Classic", "Burgery", 31.50);
        }

        private void texasBurger_Click(object sender, RoutedEventArgs e)
        {
            Danie texasBurger = new Danie("Texas", "Burgery", 37.00);
        }

        private void cheeseburger_Click(object sender, RoutedEventArgs e)
        {
            Danie cheeseBurger = new Danie("CheeseBurger", "Burgery", 35.00);
        }

        private void zupaCzosnkowa_Click(object sender, RoutedEventArgs e)
        {
            Danie zupaCzosnek = new Danie("Zupa Czosnkowa", "Zupy", 17.00);
        }

        private void kremKukurydza_Click(object sender, RoutedEventArgs e)
        {
            Danie kremKuk = new Danie("Zupa Krem z Kukurydzy", "Zupy", 16.00);
        }

        private void salatkaKurczak_Click(object sender, RoutedEventArgs e)
        {
            Danie salatkaKura = new Danie("Sałatka z Kurczakiem", "Dodatki", 34.00);
        }

        private void classicSteak_Click(object sender, RoutedEventArgs e)
        {
            Danie stekKlasyczny = new Danie("Classic Steak", "Steki", 65.00);
        }

        private void porkRibs_Click(object sender, RoutedEventArgs e)
        {
            Danie stekKlasyczny = new Danie("Classic Steak", "Steki", 65.00);
        }

        private void tomahawk_Click(object sender, RoutedEventArgs e)
        {
            Danie stekToma = new Danie("Tomahawk Steak", "Steki", 84.00);
        }

        public Dania(int numerStolika, int iloscGosci, bool prio)
        {
            InitializeComponent();
            priorytet.Content = (prio == true) ? "Priorytetowe!" : "Normalne";
            numer_stolika.Content = "Numer stolika: "+numerStolika;
            ilosc_gosci.Content = "Ilość Gości: "+iloscGosci;
            this.numerStolika=numerStolika;
            this.iloscGosci=iloscGosci;
            this.prio=prio;
        }
        //public Dania()
        //{
        //    InitializeComponent();
        //}


        //Koncept jest taki, żeby zrobić button dla każdego dania, który będzie inicjował klasę Danie.cs (nazwa do zmiany) w której są
        //zawarte informajce o daniu.
    }
}
