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

namespace Oef_06
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
            // hoort een default value te zijn maar dit is makkelijker om te testen
            TxtAantalUren.Text = string.Empty;
            TxtUurloon.Text = string.Empty;
            TxtPersooneelslid.Text = string.Empty;
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            string Naam = TxtPersooneelslid.Text;
            double Uurloon = Convert.ToDouble(TxtUurloon.Text);
            int AantalUren = int.Parse(TxtAantalUren.Text);

            double Bruto = Uurloon * AantalUren;

            // echte bereking moet nog gedaan worden
            double Neto = Uurloon * AantalUren;
            double Belastingen = Uurloon * AantalUren;

            // formating van gegevens ingeven 
            TxtResultaat.Text = string.Empty;
        }
    }
}
