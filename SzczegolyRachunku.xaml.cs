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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WaiterApp
{
    /// <summary>
    /// Logika interakcji dla klasy SzczegolyRachunku.xaml
    /// </summary>
    public partial class SzczegolyRachunku : Page
    {
        private string path = "";
        public SzczegolyRachunku()
        {
            InitializeComponent();
        }
        public SzczegolyRachunku(string path)
        {
            InitializeComponent();
            this.path = path;
        }
        public void WyswietlSzczegolyRachunku()
        {
            string[] txt = File.ReadAllLines(path);
            string[] linijka = txt[0].Split("\t");
            lb_info.Content = $"Rachunek dla {linijka[2]}\n\n";
            double suma = 0;
            for(int i = 1; i < txt.Length-1; i++)
            {
                linijka = txt[i].Split("\t");
                lb_info.Content += $"\t{linijka[2],-27}"+ String.Format($"\t{Convert.ToDouble(linijka[3]):N2}")+"zł\n";
                suma += Convert.ToDouble(linijka[3]);
            }
            lb_info.Content += $"\n{"Kwota łącznie: ",50}{suma:N2}zł";
        }
    }
}
