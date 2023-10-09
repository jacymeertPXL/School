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

namespace Oef_14
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
            string ingevoerdeDatumTekst = TxtGeboorteDatum.Text;

            if (DateTime.TryParseExact(ingevoerdeDatumTekst, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ingevoerdeDatum))
            {
                DateTime huidigeDatum = DateTime.Now;
                TimeSpan verschil = huidigeDatum - ingevoerdeDatum;

                int jaren = verschil.Days / 365;
                int maanden = (verschil.Days % 365) / 30;
                int dagen = (verschil.Days % 365) % 30;

                TxtDagen.Text = dagen.ToString();
                TxtMaanden.Text = maanden.ToString();
                TxtJaren.Text = jaren.ToString();
            }
            else
            {
                MessageBox.Show("Ongeldige datum. Voer een geldige datum in het formaat dd/mm/jjjj in.");
            }
        }
    }
}
