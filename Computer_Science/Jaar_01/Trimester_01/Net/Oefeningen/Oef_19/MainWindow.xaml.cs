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

namespace Oef_19
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

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtAantalPersonen.Text = string.Empty;
            TxtResultaat.Text = string.Empty;
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int aantal = (int)Convert.ToInt64(TxtAantalPersonen.Text);
            double resultaat = 1;

            for (int i = 0; i < aantal; i++)
            {
                resultaat *= 365.0 / (365.0 - i);
            }

            TxtResultaat.Text = resultaat.ToString();
        }
    }
}
