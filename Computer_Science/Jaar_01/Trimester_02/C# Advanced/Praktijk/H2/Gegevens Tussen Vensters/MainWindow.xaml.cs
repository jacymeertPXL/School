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
using System.Data;
using System.Threading;

namespace Gegevens_Tussen_Vensters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Manier zonder class
        //public static TextBox txtwijzig = new TextBox();

        public MainWindow()
        {
            InitializeComponent();
            Data.Tekxt = TxtResultaat.Text;
        }

        private void BtnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            // Manier zonder class
            //txtwijzig = TxtResultaat;

            KeuzeVenster keuzeVenster = new KeuzeVenster();
            // Nog ins dat het zeker de juiste current iformatie doorgeeft
            Data.Tekxt = TxtResultaat.Text;
            keuzeVenster.Show();

            // Manier zonder class
            //keuzeVenster.ShowDialog();
            //if (keuzeVenster.DialogResult.HasValue && keuzeVenster.DialogResult.Value)
            //{
            //    MessageBox.Show("Knop Ok gedrukt.");
            //}
            //else
            //{
            //    MessageBox.Show("Knop cancel/sluiten gedrukt.");
            //}
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            // WIndows Actief Bij load en terug visible.
            TxtResultaat.Text = Data.Tekxt;
        }
    }
}
