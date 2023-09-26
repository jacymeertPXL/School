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

namespace Oef_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Berekenen_Click(object sender, RoutedEventArgs e)
        {
            double PI = 3.14;

            double Straal = Convert.ToDouble(TxtStraal.Text);
            double Omtrek = Convert.ToDouble(TxtOmtrek.Text);

            double oppervalkte = (Straal * Straal) * PI;
            Omtrek = (Straal * Straal) * PI;

            TxtOmtrek.Text = Omtrek.ToString();
            TxtOpp.Text = oppervalkte.ToString();

            LblOpp.Content = "Oppervlakte in cm"; // veranderen van de content van de label 

        }

        private void Verwijderen_Click(object sender, RoutedEventArgs e)
        {
            // verwijdert de content van de textboxten
            TxtOmtrek.Text = string.Empty;
            TxtOpp.Text = string.Empty;
            TxtStraal.Text = string.Empty;
        }
    }
}
