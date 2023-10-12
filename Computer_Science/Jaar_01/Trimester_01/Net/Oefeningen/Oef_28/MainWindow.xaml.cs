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

namespace Oef_28
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

        private void BtnInkomen_Click(object sender, RoutedEventArgs e)
        {
            int salaris = (int)Convert.ToInt64(TxtJaarSalaris.Text);
            int aantal = (int)Convert.ToInt64(TxtAantal_Jaren.Text);
            tooninkomen(salaris, aantal);
        }

        public void tooninkomen(int salaris, int aantal)
        {
            int TotaalInkomen = salaris * aantal;
            TxtInkomen.Text = TotaalInkomen.ToString();
        }
    }
}
