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

namespace Proef_Examen_02 { 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<string> namen = new List<string>() { "Sander", "Quirino", "Thomas",
          "Cédric", "Jason", "Domenico", "Rickert", "Klaas", "Tom", "Stephan", "Alexander",
          "Michaël", "Bram", "Achraf", "Raf", "Sven", "Gerben", "Kevin", "Cem", "Steff", "Steven",
          "Rani", "Djordy", "Nick", "Mikail", "Konstantin", "Asad", "Viktor", "Antonio", "Senne",
          "Benjamin", "Stef", "Abdul", "Christiaan", "Abdurrahman", "Jurgen", "Kevin", "Silvio",
          "Nathan", "Stijn", "Bart", "Frank", "Steven", "Matty", "Arend", "Simon", "Ziggy",
          "Pascal", "Michaël", "Danny", "Robby", "Johan", "Vincent", "Wim", "Tuba", "Kristof",
          "Kenneth" };

        private string[,] lidgeldPerCat = { { "Preminiem", "150" }, { "Miniem", "150" }, {
          "Junior", "170" }, { "Kadet", "170" },{ "Senior", "200" } };

        private TextBox[] prognoseVakken = new TextBox[6];
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i  < namen.Count; i++)
            {
                CbNaam.Items.Add(namen[i]);
            }

            LbDate.Content = DateTime.Now.ToLongDateString();
            LbTijd.Content = DateTime.Now.TimeOfDay;
        }

        private void BtnAflsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtInformatie.Text = string.Empty;
            TxtRijd.Text = string.Empty;
            TxtRang.Text = string.Empty;

            SplInformatie.Children.Clear();

        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            Double Som = 0;
            int BasisBedrag = 0;
            if (RdbCompetitielid.IsChecked == true)
            {
                Som = +50;
            }

            double rang = (double)Convert.ToDouble(TxtRang.Text);
            Som = (100 * 0.05) * rang;

            for (int i = 0; i < 1; i++)
            {
                if (RdbCadet.Content.ToString() == lidgeldPerCat[i, 0])
                {
                    Som += 170;
                    BasisBedrag += 170;
                }
                if (RdbJunior.Content.ToString() == lidgeldPerCat[i, 0])
                {
                    Som += 170;
                    BasisBedrag += 170;
                }
                if (RdbMiniem.Content.ToString() == lidgeldPerCat[i, 0])
                {
                    Som += 150;
                    BasisBedrag += 150;
                }
                if (RdbSenior.Content.ToString() == lidgeldPerCat[i, 0])
                {
                    Som += 200;
                    BasisBedrag += 200;
                }
                if (RdbPreminiem.Content.ToString() == lidgeldPerCat[i, 0])
                {
                    Som += 150;
                    BasisBedrag += 150;
                }
            }

            StringBuilder Informatie = new StringBuilder();

            Informatie.AppendLine("InschrijvingBedrag Voor" + CbNaam.SelectionBoxItem.ToString());
            Informatie.AppendLine("");
            Informatie.AppendLine("BasisBedrag" + BasisBedrag);
            Informatie.Append("Te Betalen" + Som); ;
            TxtInformatie.Text = Informatie.ToString();

            ////// ////// ////// ////// ////// ////// ////// //////

            double Seconden = Convert.ToDouble(TxtRijd.Text);

            for (int j = 0; j < prognoseVakken.Length; j++)
            {
                prognoseVakken[j] = new TextBox
                {
                    Background = new SolidColorBrush(Colors.LightGreen),
                    IsReadOnly = true,
                    HorizontalAlignment = HorizontalAlignment.Left
                };
            }
       
            for (int i = 0; i < 6; i++)
            {
                prognoseVakken[i].Text = Seconden.ToString();

                Seconden = Seconden - (100 * 0.055 - 0.005 * i);

                int getal;
                if (int.TryParse(prognoseVakken[i].Text, out getal))
                {
                    prognoseVakken[i].Width = getal  * 10;
                }
            }

            for(int i = 0;i < 6;i++) {
                System.Windows.Controls.Label label = new System.Windows.Controls.Label { Content = "Over Jaar" + i };
                SplInformatie.Children.Add(label);
                SplInformatie.Children.Add(prognoseVakken[i]);
            }
            
            SplInformatie.Background = new SolidColorBrush(Colors.LightGray);
            LbInformatie.Content = "Gemiddelde Tijdsprognose in Sec: (Geldig voor nieuwe leden);";

        }
    }
}
