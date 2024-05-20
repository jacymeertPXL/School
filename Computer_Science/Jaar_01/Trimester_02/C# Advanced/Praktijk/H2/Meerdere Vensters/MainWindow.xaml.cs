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

namespace Meerdere_Vensters
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

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            // met deze methode kan je met het eerste en tweede venster tegelijk interacten
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void BtnShowDialog_Click(object sender, RoutedEventArgs e)
        {
            // Dit venster moet eerst terug voor ja terug naar je eerste venster kan.
            Window2 dialog2 = new Window2();
            dialog2.ShowDialog();
        }
    }
}
