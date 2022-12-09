using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;


namespace WaiterApp
{
    /// <summary>
    /// Logika interakcji dla klasy CreateTable.xaml
    /// </summary>
    public partial class CreateTable : Window
    {
        public CreateTable()
        {
            InitializeComponent();
        }
        public CreateTable(string kelner, DateTime czasotwarcia)    //Jaro tutaj przeladuj odpowiednio: ID kelnera i czas klikniecia BUTTONA np: CreateTable ct = new CreateTable("kel0001",DateTime.Now); ct.Show();
        {
            InitializeComponent();
            lb_czas_otwarcia.Content = czasotwarcia.ToString("HH:mm:ss");
            lb_id_kelnera.Content = kelner;
        }

        private void Click_anuluj(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Click_zatwierdz(object sender, RoutedEventArgs e)  //Szymon tutaj ty, Otwieranie twojego okienka z przeładowaniem i przesłaniem danych,
        {                                                            // przeslane dane przydadza sie w pozniejszym sprincie do tworzenia zamowienia, a narazie niech beda jako stale globalne
            // NAzwa_okna_Szymona skrót = new NAzwa_okna_Szymona(tb_nr_stolika.Text/*int*/, tb_ilosc_gosci.Text /*int*/, priorytet/* bool type */);
            // sprót.Show()

            if(priorytet.IsChecked ?? true)
            {
                Dania daniaOkno = new Dania(Convert.ToInt32(tb_nr_stolika.Text), Convert.ToInt32(tb_ilosc_gosci.Text), true);
                daniaOkno.Show();
            }
            else
            {
                Dania daniaOkno = new Dania(Convert.ToInt32(tb_nr_stolika.Text), Convert.ToInt32(tb_ilosc_gosci.Text), false);
                daniaOkno.Show();
            }
            this.Close();
        }

        private void Tb_check_input(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
