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

namespace Overerving
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Werknemer Werknemer = new Werknemer();
        Persoon Persoon = new Persoon();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBasisKlasse_Click(object sender, RoutedEventArgs e)
        {
            Persoon.Voornaam = "Jacy";
            Persoon.Naam = "Meert";
            Persoon.Geboortedatum = DateTime.Parse("18/08/2003");

            MessageBox.Show(Persoon.Volledigenaam(), " Volledige naam", MessageBoxButton.OK, MessageBoxImage.Information);
            MessageBox.Show(Persoon.Gegevens(), " Persoonlijke Gegevens", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnOvererving_Click(object sender, RoutedEventArgs e)
        {
            Werknemer.Voornaam = "Jacy";
            Werknemer.Naam = "Meert";
            Werknemer.Geboortedatum = DateTime.Parse("18/08/2003");
            Werknemer.DatumInDienst = DateTime.Now;

            MessageBox.Show(Werknemer.Volledigenaam() + " In dienst sinds "+ Werknemer.DatumInDienst.ToShortTimeString(), " Persoonsgegeven", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnPolymorfisme_Click(object sender, RoutedEventArgs e)
        {
            Persoon persoon = new Persoon();
            persoon.Info("Jacy Meert" + "Geboren in Hasselt");
            Persoon.Geboortedatum = DateTime.Parse("18/08/2003");

            Werknemer werknemer = new Werknemer();
            werknemer.Info("Jacy Meer 2" + "In Dienst sinds 18-08-2004");
            Werknemer.Geboortedatum = DateTime.Parse("18/08/2004");

            MessageBox.Show("Gegevens uit basisklasse: " + persoon.Gegevens(), "Base");
            MessageBox.Show("Gegevens uit AfgeleideKalsse: " + werknemer.Gegevens(), "Base");
        }

        private void BtnConverteren_Click(object sender, RoutedEventArgs e)
        {
            // Niet belangrijk
        }
    }
}
