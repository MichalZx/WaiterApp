using System;
using System.IO;
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
        private string czas_otwarcia_rachunku;
        public CreateTable()
        {
            InitializeComponent();
        }
        public CreateTable(string kelner, DateTime czasotwarcia)    //Jaro tutaj przeladuj odpowiednio: ID kelnera i czas klikniecia BUTTONA np: CreateTable ct = new CreateTable("kel0001",DateTime.Now); ct.Show();
        {
            InitializeComponent();
            czas_otwarcia_rachunku = czasotwarcia.ToString();
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
            if (tb_ilosc_gosci.Text == "" | tb_nr_stolika.Text == "") MessageBox.Show("Wprowadź prawidłoą wartość następujących pól: \n- nrumer stolika \n- ilość gości", "Wykryto błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                string czas_pliku = czas_otwarcia_rachunku.Replace(".", "");
                czas_pliku = czas_pliku.Replace(":", "");
                czas_pliku = czas_pliku.Replace(" ", "_");
                StreamWriter sw = null;
                
                if (priorytet.IsChecked ?? true)    //priorytetowe
                {
                    string path = @"..\..\..\Rachunki\!_" + czas_pliku + "bill.txt";
                    try
                    {
                        if (File.Exists(path)) File.Delete(path);
                        else { FileStream fs = File.Create(path); fs.Close(); }
                        sw = new StreamWriter(path, false);
                        sw.WriteLine($"Dane o rachunku\tKelner: {lb_id_kelnera.Content}\tStolik: {tb_nr_stolika.Text}\tIlość gości: {tb_ilosc_gosci.Text}\tPriorytet: Wysoki");
                    }
                    catch (Exception error) { Console.WriteLine(error); }
                    finally { if (sw != null) sw.Close(); }
                    Dania daniaOkno = new Dania(Convert.ToInt32(tb_nr_stolika.Text), Convert.ToInt32(tb_ilosc_gosci.Text), true,path);
                    daniaOkno.Show();
                }   
                else                                // NOwrmalne
                {
                    string path = @"..\..\..\Rachunki\" + czas_pliku + "bill.txt";
                    try
                    {
                        if (File.Exists(path)) File.Delete(path);
                        else { FileStream fs = File.Create(path); fs.Close(); }
                        sw = new StreamWriter(path, false);
                        sw.WriteLine($"Dane o rachunku\tKelner: {lb_id_kelnera.Content}\tStolik: {tb_nr_stolika.Text}\tIlość gości: {tb_ilosc_gosci.Text}\tPriorytet: Normalny");
                    }
                    catch (Exception error) { Console.WriteLine(error); }
                    finally { if (sw != null) sw.Close(); }
                    Dania daniaOkno = new Dania(Convert.ToInt32(tb_nr_stolika.Text), Convert.ToInt32(tb_ilosc_gosci.Text), false,path);
                    daniaOkno.Show();
                }
                this.Close();
            }
        }

        private void Tb_check_input(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
