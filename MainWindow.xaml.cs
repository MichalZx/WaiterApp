using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WaiterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    

    public class KelnerzyDane
    {
        public KelnerzyDane() { }

        public static bool listaKelnerow(string sprawdzany)
        {
            List<string> kelnerzyID = new List<string>()
            {
                "kel01", "kelner01", "kelner", "KELNER", "", "login kelnera" //usprawnienie że nie trzeba podawać loginu, tylko domyslna wartość odpala
            };
            foreach (string s in kelnerzyID)
            {
                if (s.Equals(sprawdzany)) { return true; }
            }
            return false;

        }

    }
    public partial class MainWindow : Window
    {
        public int iloscrachunkow = 0;

        #region Main działający i zawsze wywoływany, tylko upiększyć graficznie
        public MainWindow()
        {
            InitializeComponent();
            tbZamowienie1.Visibility = Visibility.Hidden;
            tbZamowienie2.Visibility = Visibility.Hidden;
            tbZamowienie3.Visibility = Visibility.Hidden;
            tbZamowienie4.Visibility = Visibility.Hidden;

            string folderPath = @"..\..\..\Rachunki\";
            List<string> aktualneRachunki=new List<string>() ;
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.txt"))
            {
                aktualneRachunki.Add(File.ReadAllText(file));
            }


            if (aktualneRachunki.Count>=1)
            {
                tbZamowienie1.Visibility = Visibility.Visible;
                tbZamowienie1.Text = aktualneRachunki[0];
            }
            if(aktualneRachunki.Count>=2)
            {
                tbZamowienie2.Visibility = Visibility.Visible;
                tbZamowienie2.Text = aktualneRachunki[1];
            }
            if(aktualneRachunki.Count>=3)
            {
                tbZamowienie3.Visibility = Visibility.Visible;
                tbZamowienie3.Text = aktualneRachunki[2];
            }
            if(aktualneRachunki.Count>=4)
            {
                tbZamowienie4.Visibility = Visibility.Visible;
                tbZamowienie4.Text = aktualneRachunki[3];
            }

        }
        #endregion

        #region bezsensowny Main z użytecznymi metodami
        //Cały ten przeciążony main jest 
        public MainWindow(int numerStolika, int iloscGosci, bool prio, List<Danie> zamowienie, string kelnerID, DateTime czasotwarcia)
        {
            InitializeComponent();
            tbZamowienie1.Visibility = Visibility.Hidden;
            tbZamowienie2.Visibility = Visibility.Hidden;
            tbZamowienie3.Visibility = Visibility.Hidden;
            tbZamowienie4.Visibility = Visibility.Hidden;

            bool juzDodano = false; //gdyby nie ta zmienna to wszystkie rachunki wyglądałyby tak samo

            if (tbZamowienie1.Text == "")
            {
                //gridTBZamowienie1.Margin = new Thickness(20, 20, 405, 310);
                tbZamowienie1.Visibility = Visibility.Visible;
                //tbZamowienie1.Visibility.visi
                tbZamowienie1.Text = $"Nr stolika: {numerStolika,-4} Ilość gości: {iloscGosci,-4} {(prio ? "Priorytetowe" : "Zwykłe"),-20} {kelnerID} {czasotwarcia}\n\n";
                foreach (Danie item in zamowienie)
                {
                    tbZamowienie1.Text += item.ToString() + "\n";
                    tbZamowienie1.Height += 25;
                  //  gridTBZamowienie1.Margin = new Thickness(20, 20, 405, gridTBZamowienie1.Margin.Bottom - 25);
                }
                juzDodano = true;
                btZamknijZamowienie1.Visibility = Visibility.Visible;
                
            }

            if (tbZamowienie2.Text == "" & juzDodano == false)
            {
                tbZamowienie2.Visibility = Visibility.Visible;
                tbZamowienie2.Margin = new Thickness(400, 20, 0, 0);
                tbZamowienie2.Text = $"Nr stolika: {numerStolika,-4} Ilość gości: {iloscGosci,-4} {(prio ? "Priorytetowe" : "Zwykłe"),-20}  {kelnerID} {czasotwarcia} \n\n";
                foreach (Danie item in zamowienie)
                {
                    tbZamowienie2.Text += item.ToString() + "\n";
                    tbZamowienie2.Height += 30;
                }
                juzDodano = true;
            }
            if (tbZamowienie3.Text == "" & juzDodano == false)
            {
                tbZamowienie3.Visibility = Visibility.Visible;

                tbZamowienie3.Margin = new Thickness(20, tbZamowienie1.Height, 0, 0);
                tbZamowienie3.Text = $"Nr stolika: {numerStolika,-4} Ilość gości: {iloscGosci,-4} {(prio ? "Priorytetowe" : "Zwykłe"),-20} \n\n";
                foreach (Danie item in zamowienie)
                {
                    tbZamowienie3.Text += item.ToString() + "\n";
                    tbZamowienie3.Height += 30;
                }
                juzDodano = true;
            }
            if (tbZamowienie4.Text != "" & juzDodano == false)
            {
                tbZamowienie4.Visibility = Visibility.Visible;

                tbZamowienie4.Margin = new Thickness(20, tbZamowienie2.Height, 0, 0);
                tbZamowienie4.Text = $"Nr stolika: {numerStolika,-4} Ilość gości: {iloscGosci,-4} {(prio ? "Priorytetowe" : "Zwykłe"),-20} \n\n";
                foreach (Danie item in zamowienie)
                {
                    tbZamowienie4.Text += item.ToString() + "\n";
                    tbZamowienie4.Height += 30;
                }
                juzDodano = true;
            }

        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string idKelnera = tbNazwaKelnera.Text;
            KelnerzyDane p = new KelnerzyDane();

            if (KelnerzyDane.listaKelnerow(idKelnera))
            {
                DateTime teraz = DateTime.Now;
                CreateTable createTable = new CreateTable(idKelnera, teraz);
                createTable.Show();
            }
            else
            {
                MessageBox.Show("Kelner poza bazą danych", "UWAGA");
            }
            przycisk.Opacity = 0;
        }
        private void btZamknijZamowienie_Click(object sender, RoutedEventArgs e)
        {
            tbZamowienie1.Text = "";
        }

        private void tempPOkaRachunek_Click(object sender, RoutedEventArgs e)
        {
            string path= @"..\..\..\Rachunki\17122022_202854bill.txt";      // to jest przykladowy plik zeby zobaczyc czy dziala
            SzczegolyRachunku info = new SzczegolyRachunku(path);           // te 3 kolejne linijki sa dobrze i nic wiecej nie trezba
            info.WyswietlSzczegolyRachunku();
            rachunkiInfo.Content = info.lb_info.Content;
        }

    }
}