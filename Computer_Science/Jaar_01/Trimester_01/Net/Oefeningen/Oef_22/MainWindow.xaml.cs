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

namespace Oef_22
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

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            int dobblesteen = 1;
            int i = 0;

            while (dobblesteen != 6)
            {
                i++;
                Random rnd = new Random();
                dobblesteen = rnd.Next(1, 7);
                TxtWorpen.Text += (Environment.NewLine) + "Worp" + i.ToString() + "geeft" + dobblesteen.ToString(); // Environment.NewLine Gaat alles onder elkaar weervgeven
            }
        }

        private void Btnopnieuwe_Click(object sender, RoutedEventArgs e)
        {
            TxtWorpen.Text = string.Empty;
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
