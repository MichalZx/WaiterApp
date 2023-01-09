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
        public List<Danie> zamowienie = new List<Danie>();
        string kelnerID;
        DateTime czasotwarcia;


        public void naleznosc(Danie potrawa)
        {
            double naleznosc = potrawa.ZwrotCeny() + double.Parse((string)lbCenaCalosci.Content);
            lbCenaCalosci.Content = naleznosc.ToString();
        }

        private void classicBurger_Click(object sender, RoutedEventArgs e)
        {
            Danie classicBurger = new Danie("Classic", "Burgery", 31.50);
            classicBurger.Dodaj_do_rachunku(path);
            zamowienie.Add(classicBurger);
            naleznosc(classicBurger);
        }

        private void texasBurger_Click(object sender, RoutedEventArgs e)
        {
            Danie texasBurger = new Danie("Texas", "Burgery", 37.00);
            texasBurger.Dodaj_do_rachunku(path);
            zamowienie.Add(texasBurger);
            naleznosc(texasBurger);

        }

        private void cheeseburger_Click(object sender, RoutedEventArgs e)
        {
            Danie cheeseBurger = new Danie("CheeseBurger", "Burgery", 35.00);
            cheeseBurger.Dodaj_do_rachunku(path);
            zamowienie.Add(cheeseBurger);
            naleznosc(cheeseBurger);
        }

        private void zupaCzosnkowa_Click(object sender, RoutedEventArgs e)
        {
            Danie zupaCzosnek = new Danie("Zupa Czosnkowa", "Zupy", 17.00);
            zupaCzosnek.Dodaj_do_rachunku(path);
            zamowienie.Add(zupaCzosnek);
            naleznosc(zupaCzosnek);
        }

        private void kremKukurydza_Click(object sender, RoutedEventArgs e)
        {
            Danie kremKuk = new Danie("Zupa Krem z Kukurydzy", "Zupy", 16.00);
            kremKuk.Dodaj_do_rachunku(path);
            zamowienie.Add(kremKuk);
            naleznosc(kremKuk);
        }

        private void salatkaKurczak_Click(object sender, RoutedEventArgs e)
        {
            Danie salatkaKura = new Danie("Sałatka z Kurczakiem", "Przekąski", 34.00);
            salatkaKura.Dodaj_do_rachunku(path);
            zamowienie.Add(salatkaKura);
            naleznosc(salatkaKura);
        }

        private void classicSteak_Click(object sender, RoutedEventArgs e)
        {
            Danie stekKlasyczny = new Danie("Classic Steak", "Steki", 65.00);
            stekKlasyczny.Dodaj_do_rachunku(path);
            zamowienie.Add(stekKlasyczny);
            naleznosc(stekKlasyczny);
        }

        private void porkRibs_Click(object sender, RoutedEventArgs e)
        {
            Danie zeberkaWieprzowe = new Danie("Pork Ribs", "Steki", 55.00);
            zeberkaWieprzowe.Dodaj_do_rachunku(path);
            zamowienie.Add(zeberkaWieprzowe);
            naleznosc(zeberkaWieprzowe);
        }

        private void tomahawk_Click(object sender, RoutedEventArgs e)
        {
            Danie stekToma = new Danie("Tomahawk Steak", "Steki", 84.00);
            stekToma.Dodaj_do_rachunku(path);
            zamowienie.Add(stekToma);
            naleznosc(stekToma);
        }

        private void porkRibSandwich_Click(object sender, RoutedEventArgs e)
        {
            Danie cheeseBurger = new Danie("Porkrib Sandwich", "Burgery", 29.00);
            cheeseBurger.Dodaj_do_rachunku(path);
            zamowienie.Add(cheeseBurger);
            naleznosc(cheeseBurger);
        }

        private void pulledPorkSandwich_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Pulled Pork Sandwich", "Burgery", 29.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void alCaponeBurger_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Al Capone Burger", "Burgery", 38.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void peperonata_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Peperonata", "Zupy", 17.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void rosol_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Rosół", "Zupy", 12.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void pomidorowa_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Pomidorowa", "Zupy", 14.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void barszcz_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Barszcz", "Zupy", 10.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void partyNachos_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Party Nachos", "Przekąski", 20.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void beefTartare_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Beef Tartare", "Przekąski", 30.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void bigComboPlate_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Big Combo Plate", "Przekąski", 50.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void louisianaWings_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Louisiana Bufallo Wings", "Przekąski", 29.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void ribeye_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Ribeye Steak", "Mięsa", 89.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void newyork_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("New York Steak", "Mięsa", 65.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void porkNeck_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("New York Steak", "Mięsa", 35.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void chickenBreasts_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Chicken Breast", "Mięsa", 28.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void pepsi_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Pepsi", "Napoje", 7.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void mirinda_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Mirinda", "Napoje", 8.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void shweppes_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Shweppes", "Napoje", 8.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void lipton_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Lipton", "Napoje", 5.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void woda_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Woda", "Napoje", 3.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void sok_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Sok", "Napoje", 16.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void redBull_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Red Bull", "Napoje", 14.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void wino_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Wino", "Napoje", 12.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void prosecco_Click(object sender, RoutedEventArgs e)
        {
            Danie d = new Danie("Prosecco", "Napoje", 11.00);
            d.Dodaj_do_rachunku(path);
            zamowienie.Add(d);
            naleznosc(d);
        }

        private void powrot_do_menu_gl_Click(object sender, RoutedEventArgs e)
        {
            // MainWindow main = new MainWindow(numerStolika, iloscGosci, prio, zamowienie, kelnerID, czasotwarcia);
            MainWindow main = new MainWindow();
            main.Show();
            //Rachunki.dodaj(path);
            //Rachunki.wywolajMain();
            


            //MainWindow main2 = new MainWindow(path); //eksperymentalna ścieżka main na podstawie ścieżki do pliku .txt
            //main.Show();                                                  //do Jarka jakbyś chciał przeciążyc to tu masz wywołanie
            //main2.Show();                                                  //do Jarka jakbyś chciał przeciążyc to tu masz wywołanie
            this.Close();
        }

        private void kategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBoxItem = kategorie.Items[kategorie.SelectedIndex] as ComboBoxItem;
            if (comboBoxItem != null)
            {
                string selectedcmb = comboBoxItem.Content.ToString();
                if (selectedcmb == "Burgery")
                {
                    zupy.Visibility = Visibility.Collapsed;
                    napoje.Visibility = Visibility.Collapsed;
                    miesa.Visibility = Visibility.Collapsed;
                    przekaski.Visibility = Visibility.Collapsed;
                    burgery.Visibility = Visibility.Visible;
                }
                else if (selectedcmb == "Zupy")
                {
                    burgery.Visibility = Visibility.Collapsed;
                    napoje.Visibility = Visibility.Collapsed;
                    miesa.Visibility = Visibility.Collapsed;
                    przekaski.Visibility = Visibility.Collapsed;
                    zupy.Visibility = Visibility.Visible;
                }
                else if (selectedcmb == "Przekąski")
                {
                    burgery.Visibility = Visibility.Collapsed;
                    zupy.Visibility = Visibility.Collapsed;
                    napoje.Visibility = Visibility.Collapsed;
                    miesa.Visibility = Visibility.Collapsed;
                    przekaski.Visibility = Visibility.Visible;
                }
                else if (selectedcmb == "Mięsa")
                {
                    burgery.Visibility = Visibility.Collapsed;
                    zupy.Visibility = Visibility.Collapsed;
                    napoje.Visibility = Visibility.Collapsed;
                    przekaski.Visibility = Visibility.Collapsed;
                    miesa.Visibility = Visibility.Visible;
                }
                else if (selectedcmb == "Napoje")
                {
                    burgery.Visibility = Visibility.Collapsed;
                    zupy.Visibility = Visibility.Collapsed;
                    miesa.Visibility = Visibility.Collapsed;
                    przekaski.Visibility = Visibility.Collapsed;
                    napoje.Visibility = Visibility.Visible;
                }
            }

        }

        

        public Dania(int numerStolika, int iloscGosci, bool prio, string path, string kelnerID, DateTime czasotwarcia)
        {
            InitializeComponent();
            priorytet.Content = (prio == true) ? "Priorytetowe!" : "Normalne";
            numer_stolika.Content = "Numer stolika: "+numerStolika;
            ilosc_gosci.Content = "Ilość Gości: "+iloscGosci;
            this.numerStolika = numerStolika;
            this.iloscGosci = iloscGosci;
            this.prio = prio;
            this.path = path;
            this.czasotwarcia = czasotwarcia;
            this.kelnerID = kelnerID;
            burgery.Visibility = Visibility.Collapsed;
            przekaski.Visibility = Visibility.Collapsed;
            zupy.Visibility= Visibility.Collapsed;
            miesa.Visibility = Visibility.Collapsed;
            napoje.Visibility = Visibility.Collapsed;
        }
        //public Dania()
        //{
        //    InitializeComponent();
        //}


        //Koncept jest taki, żeby zrobić button dla każdego dania, który będzie inicjował klasę Danie.cs (nazwa do zmiany) w której są
        //zawarte informajce o daniu.
    }
}
