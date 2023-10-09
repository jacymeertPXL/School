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

namespace Oef_03
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

        private void WIssen_Click(object sender, RoutedEventArgs e)
        {
            TxtGetal01.Text = string.Empty;
            TxtGetal02.Text = string.Empty;
            TxtResultaat.Text = string.Empty;
        }

        private void Optellen(object sender, RoutedEventArgs e)
        {
            double Getal01 = Convert.ToDouble(TxtGetal01.Text);
            double Getal02 = Convert.ToDouble(TxtGetal02.Text);     

            double som = Getal01 + Getal02;

            TxtResultaat.Text = som.ToString();
        }

        private void Aftellen(object sender, RoutedEventArgs e)
        {
            double Getal01 = Convert.ToDouble(TxtGetal01.Text);
            double Getal02 = Convert.ToDouble(TxtGetal02.Text);

            double som = Getal01 - Getal02;

            TxtResultaat.Text = som.ToString();
        }

        private void Maal(object sender, RoutedEventArgs e)
        {
            double Getal01 = Convert.ToDouble(TxtGetal01.Text);
            double Getal02 = Convert.ToDouble(TxtGetal02.Text);

            double som = Getal01 * Getal02;

            TxtResultaat.Text = som.ToString();
        }

        private void Delen(object sender, RoutedEventArgs e)
        {
            double Getal01 = Convert.ToDouble(TxtGetal01.Text);
            double Getal02 = Convert.ToDouble(TxtGetal02.Text);

            double som = Getal01 / Getal02;
         
            TxtResultaat.Text = som.ToString();

        }
    }
}
