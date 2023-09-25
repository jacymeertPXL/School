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

namespace Oef_01_Euro_Omzetten_Naar_Dollar
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

        private void Berekenen(object sender, RoutedEventArgs e)
        {
            int dollar;
            int euro;

            euro = int.Parse(TxtEuro.Text);

            if (euro == 0)
            {
                euro = 1;
            }
            else
            {
                euro = (int)(euro * 1.06810);
            }
            TxtDollar.Text = Convert.ToString(euro);
        }

        private void WIssen(object sender, RoutedEventArgs e)
        {
           TxtDollar.Text = string.Empty;
           TxtEuro.Text = string.Empty;
        }

    }
}
