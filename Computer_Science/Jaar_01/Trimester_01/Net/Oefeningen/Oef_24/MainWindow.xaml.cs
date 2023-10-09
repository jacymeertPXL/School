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

namespace Oef_24
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

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double Resultaat = 0;
            int teller = 1;

            double weekgeld = (double)Convert.ToDouble(TxtWeekgeld.Text);
            double verhoging = (double)Convert.ToDouble(TxtVerhoging.Text);
            int Spaarbadrag = (int)Convert.ToInt64(TxtSpaarBedrag.Text);

            while (Spaarbadrag > Resultaat)
            {
                teller++;
                Resultaat += weekgeld + (verhoging * teller);
            }

            double som = Resultaat + weekgeld;
            double som2 = verhoging * teller;
            TxtWeergaven.Text = "Spaarbedrag na " + teller.ToString() + "weken " + Resultaat.ToString() +
                "Extra weekgeld op date moment " + som2 + 
                "Totaal spaargeld " + som;
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaarBedrag.Text = string.Empty;
            TxtVerhoging.Text = string.Empty;
            TxtWeekgeld.Text = string.Empty;
            TxtWeergaven.Text = string.Empty;
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
