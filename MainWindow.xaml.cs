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

namespace WaiterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class KelnerzyDane
    {
        public KelnerzyDane() { }

        public static bool listaKelnerow(string sprawdzany)
        {
            List<string> kelnerzyID = new List<string>()
            {
                "kel01", "kelner01", "kelner", "KELNER", ""
            };
            foreach(string s in kelnerzyID)
            {
                if(s.Equals(sprawdzany)) { return true; }
            }
            return false;
        }
        
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string idKelnera= tbNazwaKelnera.Text;
            KelnerzyDane p = new KelnerzyDane();

            if(KelnerzyDane.listaKelnerow(idKelnera))
            {
                DateTime teraz = DateTime.Now;
                CreateTable createTable = new CreateTable(idKelnera, teraz);
                createTable.Show();
            }
            else
            {
                MessageBox.Show("Kelner poza bazą danych", "UWAGA");
            }

            
        }
    }
}
