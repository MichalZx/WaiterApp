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
using System.Diagnostics;

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
    public class FileItem
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
    }
    public partial class MainWindow : Window
    {
        public int iloscrachunkow = 0;

        #region Main działający i zawsze wywoływany, tylko upiększyć graficznie
        public MainWindow()
        {
            InitializeComponent();

            string closedFilePath = @"..\..\..\ZamknieteRachunki\";
            if (!Directory.Exists(closedFilePath))
            {
                Directory.CreateDirectory(closedFilePath);
            }


        }
        #endregion
        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            string folderPath = @"..\..\..\Rachunki\"; // ścieżka do folderu z plikami .txt
            string[] txtFiles = Directory.GetFiles(folderPath, "*.txt");
            foreach (string file in txtFiles)
            {
                FileItem item = new FileItem();
                item.Name = System.IO.Path.GetFileName(file);
                item.FullPath = file;
                cbFiles.Items.Add(item);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FileItem selectedItem = (FileItem)cbFiles.SelectedItem;
            if (selectedItem != null)
            {
                string content = File.ReadAllText(selectedItem.FullPath);
                tbContent.Text = content;
            }
        }

        private void MoveButton_Click(object sender, RoutedEventArgs e)
        {
            FileItem selectedItem = (FileItem)cbFiles.SelectedItem;
            if (selectedItem != null)
            {
                string sourcePath = selectedItem.FullPath;
                string targetPath = @"..\..\..\ZamknieteRachunki\" + selectedItem.Name;

                File.Move(sourcePath, targetPath);
            }
        }



        private void Button_Click1(object sender, RoutedEventArgs e)
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


        private void tempPOkaRachunek_Click(object sender, RoutedEventArgs e)
        {
            string path= @"..\..\..\Rachunki\17122022_202854bill.txt";      // to jest przykladowy plik zeby zobaczyc czy dziala
            SzczegolyRachunku info = new SzczegolyRachunku(path);           // te 3 kolejne linijki sa dobrze i nic wiecej nie trezba
            info.WyswietlSzczegolyRachunku();
            //rachunkiInfo.Content = info.lb_info.Content;
        }

    }
}