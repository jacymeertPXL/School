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

namespace Oef_29
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

        private void LeesGetallen(String getal1, String getal2)
        {
           
        }

        private void berkenen(char waarde)
        {

        }

        private void BtnDelen_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMaal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtGetal1.Text = string.Empty;
            TxtGetal2.Text = string.Empty;
            TxtResultaat.Text = string.Empty;
        }
    }
}
