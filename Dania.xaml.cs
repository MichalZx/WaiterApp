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
        string path;
        float kwota_zamowienia=0;
        public List<Danie> zamowienie = new List<Danie>();

        private void classicBurger_Click(object sender, RoutedEventArgs e)
        {
            Danie classicBurger = new Danie("Classic", "Burgery", 31.50);
            classicBurger.Dodaj_do_rachunku(path);
            zamowienie.Add(classicBurger);
        }

        private void texasBurger_Click(object sender, RoutedEventArgs e)
        {
            Danie texasBurger = new Danie("Texas", "Burgery", 37.00);
            texasBurger.Dodaj_do_rachunku(path);
            zamowienie.Add(texasBurger);
        }

        private void cheeseburger_Click(object sender, RoutedEventArgs e)
        {
            Danie cheeseBurger = new Danie("CheeseBurger", "Burgery", 35.00);
            cheeseBurger.Dodaj_do_rachunku(path);
            zamowienie.Add(cheeseBurger);
        }

        private void zupaCzosnkowa_Click(object sender, RoutedEventArgs e)
        {
            Danie zupaCzosnek = new Danie("Zupa Czosnkowa", "Zupy", 17.00);
            zupaCzosnek.Dodaj_do_rachunku(path);
            zamowienie.Add(zupaCzosnek);
        }

        private void kremKukurydza_Click(object sender, RoutedEventArgs e)
        {
            Danie kremKuk = new Danie("Zupa Krem z Kukurydzy", "Zupy", 16.00);
            kremKuk.Dodaj_do_rachunku(path);
            zamowienie.Add(kremKuk);
        }

        private void salatkaKurczak_Click(object sender, RoutedEventArgs e)
        {
            Danie salatkaKura = new Danie("Sałatka z Kurczakiem", "Dodatki", 34.00);
            salatkaKura.Dodaj_do_rachunku(path);
            zamowienie.Add(salatkaKura);
        }

        private void classicSteak_Click(object sender, RoutedEventArgs e)
        {
            Danie stekKlasyczny = new Danie("Classic Steak", "Steki", 65.00);
            stekKlasyczny.Dodaj_do_rachunku(path);
            zamowienie.Add(stekKlasyczny);
        }

        private void porkRibs_Click(object sender, RoutedEventArgs e)
        {
            Danie zeberkaWieprzowe = new Danie("Pork Ribs", "Steki", 55.00);
            zeberkaWieprzowe.Dodaj_do_rachunku(path);
            zamowienie.Add(zeberkaWieprzowe);
        }

        private void tomahawk_Click(object sender, RoutedEventArgs e)
        {
            Danie stekToma = new Danie("Tomahawk Steak", "Steki", 84.00);
            stekToma.Dodaj_do_rachunku(path);
            zamowienie.Add(stekToma);
        }

        private void powrot_do_menu_gl_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(numerStolika, iloscGosci, prio, zamowienie);
            main.Show();                                                  //do Jarka jakbyś chciał przeciążyc to tu masz wywołanie
            this.Close();
        }

        public Dania(int numerStolika, int iloscGosci, bool prio,string path)
        {
            InitializeComponent();
            priorytet.Content = (prio == true) ? "Priorytetowe!" : "Normalne";
            numer_stolika.Content = "Numer stolika: "+numerStolika;
            ilosc_gosci.Content = "Ilość Gości: "+iloscGosci;
            this.numerStolika=numerStolika;
            this.iloscGosci=iloscGosci;
            this.prio=prio;
            this.path = path;
        }
        //public Dania()
        //{
        //    InitializeComponent();
        //}


        //Koncept jest taki, żeby zrobić button dla każdego dania, który będzie inicjował klasę Danie.cs (nazwa do zmiany) w której są
        //zawarte informajce o daniu.
    }
}
