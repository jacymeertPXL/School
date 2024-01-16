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

namespace Proef_Examen_02 { 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<string> namen = new List<string>() { "Sander", "Quirino", "Thomas",
          "Cédric", "Jason", "Domenico", "Rickert", "Klaas", "Tom", "Stephan", "Alexander",
          "Michaël", "Bram", "Achraf", "Raf", "Sven", "Gerben", "Kevin", "Cem", "Steff", "Steven",
          "Rani", "Djordy", "Nick", "Mikail", "Konstantin", "Asad", "Viktor", "Antonio", "Senne",
          "Benjamin", "Stef", "Abdul", "Christiaan", "Abdurrahman", "Jurgen", "Kevin", "Silvio",
          "Nathan", "Stijn", "Bart", "Frank", "Steven", "Matty", "Arend", "Simon", "Ziggy",
          "Pascal", "Michaël", "Danny", "Robby", "Johan", "Vincent", "Wim", "Tuba", "Kristof",
          "Kenneth" };

        private string[,] lidgeldPerCat = { { "Preminiem", "150" }, { "Miniem", "150" }, {
          "Junior", "170" }, { "Kadet", "170" },{ "Senior", "200" } };

        private TextBox[] prognoseVakken = new TextBox[6];
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i  < namen.Count; i++)
            {
                CbNaam.Items.Add(namen[i]);
            }

            LbDate.Content = DateTime.Now.ToLongDateString();
            LbTijd.Content = DateTime.Now.TimeOfDay;
        }

        private void BtnAflsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtInformatie.Text = string.Empty;
            TxtRijd.Text = string.Empty;
            TxtRang.Text = string.Empty;

            SplInformatie.Children.Clear();

        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
