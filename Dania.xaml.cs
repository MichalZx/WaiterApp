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
        public Dania(int numerStolika, int iloscGosci, bool prio)
        {
            InitializeComponent();
            priorytet.Content = (prio == true) ? "Priorytetowe!" : "Normalne";
            this.numerStolika=numerStolika;
            this.iloscGosci=iloscGosci;
            this.prio=prio;
        }
        //public Dania()
        //{
        //    InitializeComponent();
        //}

        private void danie1_Click(object sender, RoutedEventArgs e)
        {
            Danie dn = new Danie("Rosół", "Zupy", 21);
        }

        private void danie2_Click(object sender, RoutedEventArgs e)
        {
            //W każdym przycisku ma być inne danie które zrobi obiekt jak wyżej
        }

        private void danie3_Click(object sender, RoutedEventArgs e)
        {
            
        }


        //Koncept jest taki, żeby zrobić button dla każdego dania, który będzie inicjował klasę Danie.cs (nazwa do zmiany) w której są
        //zawarte informajce o daniu.
    }
}
