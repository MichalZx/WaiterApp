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
            this.numerStolika=numerStolika;
            this.iloscGosci=iloscGosci;
            this.prio=prio;
            InitializeComponent();
        }
        public Dania()
        {
            InitializeComponent();
        }

        private void Priorytet_Initialized(object sender, EventArgs e)
        {
            if (prio == true)
                Priorytet.Text = "Priorytetowe!";
            else
                Priorytet.Text = "Normalne";

        }

        //Koncept jest taki, żeby zrobić button dla każdego dania, który będzie inicjował klasę Danie.cs (nazwa do zmiany) w której są
        //zawarte informajce o daniu.
    }
}
