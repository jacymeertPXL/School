using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;

namespace Examen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[,] Uitslagen = new string[,]
        {
            { "Padel Hasselt", "Padel Genk", "3-2", "N", "P200" },
            { "Padel Leuven", "Padel Diepenbeek", "3-2", "J", "P300" }

        };

        private DispatcherTimer timer;
        private DispatcherTimer timerfoto;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            timerfoto = new DispatcherTimer();
            timerfoto.Interval = TimeSpan.FromMilliseconds(01);
            timerfoto.Tick += Timer_Tick02;
            timerfoto.Start();

            //Methods
            VulArray();
            VulListObject();
            VulDictionary();
            VulCombo();
            VulListbox();
            VulDatumEnTijd();
            TextBox();

            SkpLinks.Visibility = Visibility.Hidden;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            VulDatumEnTijd();
        }
        private void Timer_Tick02(object sender, EventArgs e)
        {
           
            if (RdbP100.IsChecked == true)
            {
                ImgPadel.Source = new BitmapImage(new Uri("/Img/padelP100.jpg", UriKind.Relative));
                
            }
            else if (RdbP300.IsChecked == true)
            {
                ImgPadel.Source = new BitmapImage(new Uri("/Img/padelP200.jpg", UriKind.Relative));
            }
            else if (RdbP200.IsChecked == true)
            {
                ImgPadel.Source = new BitmapImage(new Uri("/Img/padelP300.jpg", UriKind.Relative));
            }
        }
        public void VulDatumEnTijd()
        {
            LbTijd.Content = DateTime.Now;
        }
        public void VulArray()
        {
            // heb een private array van boven aan het programma gemaakt met de nodige informatie dat ik die kan gebruiken over heel mijn code
            Array TweeDimArray = Array.CreateInstance(typeof(short), 2, 5); // zo maak je een nieuwe 2d array
        }
        public void VulListObject()
        {
            List<String> Padel = new List<string>();
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    Padel.Add(Uitslagen[i, j].ToString());
                }
            }
        }
        public void VulDictionary()
        {
            Dictionary<string, double> totaleKostPerClub = new Dictionary<string, double>()
            {
                { "Padel Hasselt", 12.5},
                { "Padel Genk", 0},
                { "Padel Leuven", 7.5},
                { "Padel Diepenbeek", 0}
            };


        }
        public void VulCombo()
        {
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    CbBezoekers.Items.Add(Uitslagen[i, j].ToString());
                    CbTeams.Items.Add(Uitslagen[i, j ].ToString());
                    CbThuisPloeg.Items.Add(Uitslagen[i, j ].ToString());
                }
            }
        }
        public void VulListbox()
        {
            LstUitslagen.Items.Clear();
            StringBuilder Informatie = new StringBuilder();

            for (int i = 0; i <= 1; i++)
            {
                Informatie.Append(Uitslagen[i, 0].ToString());
                Informatie.Append("          ");
                Informatie.Append(Uitslagen[i, 1].ToString());
                Informatie.Append("          ");
                Informatie.Append(Uitslagen[i, 2].ToString());
                LstUitslagen.Items.Add(Informatie.ToString());
                Informatie.Clear();
            }
        }

        private string PrijsPerKlassement(string klassement)
        {
            double prijs = 0;
            double Korting = 0;
            double TotalePrijs = 0;

            if (string.IsNullOrEmpty(klassement)) { return ""; }
            else if (klassement == "P100")
            {
                prijs = 10;
            }
            else if (klassement == "P200")
            {
                prijs = 12.50;
            }
            else if (klassement == "P300")
            {
                prijs = 15;
            }

            if (ChkHandicap.IsChecked == true) {
                Korting = prijs - (100 / 50);
            }

            TotalePrijs = prijs - Korting;

            StringBuilder TextBox = new StringBuilder();
            TextBox.AppendLine("Prijs: $ " + prijs);
            TextBox.AppendLine("Korting: $ " + Korting);
            TextBox.AppendLine("Totalke kostprijs voor de wedstrijd: " + TotalePrijs);

            string text = TextBox.ToString();
            return text;
        }
        public void TextBox()
        {
            StringBuilder TextBox = new StringBuilder();
            TextBox.AppendLine("KostPrijs Wedstrijd");
            TextBox.AppendLine(LstUitslagen.SelectedItem.ToString().Trim());

            if (LstUitslagen.SelectedIndex.Equals("P100"))
            {
                TextBox.AppendLine("Klassement: P100");
                TextBox.Append(PrijsPerKlassement("P100"));
             
            }
            else if (LstUitslagen.SelectedIndex.Equals("P200"))
            {
                TextBox.AppendLine("Klassement: P200");
                TextBox.Append(PrijsPerKlassement("P200"));
            }
            else if (LstUitslagen.SelectedIndex.Equals("P300"))
            {
                TextBox.AppendLine("Klassement: P300");
                TextBox.Append(PrijsPerKlassement("P300"));
            }

            TxtKostPrijs.Text = TextBox.ToString();
        }
        private void LstUitslagen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBox();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string NieuwePadel = NieuwePadelClub.Show("WpfPadel", "Geef de naam van de nieuwe club?:");

            if (!string.IsNullOrWhiteSpace(NieuwePadel))
            {
                CbTeams.Items.Add(NieuwePadel);
                CbBezoekers.Items.Add(NieuwePadel);
                CbThuisPloeg.Items.Add(NieuwePadel);
            }
        }

        public static class NieuwePadelClub
        {
            public static string Show(string title, string prompt)
            {

                Window window = new Window
                {
                    Title = title,
                    Width = 450,
                    Height = 250,
                    WindowStartupLocation = WindowStartupLocation.CenterScreen,
                    ResizeMode = ResizeMode.CanResize
                };

                StackPanel stackPanel = new StackPanel();

                System.Windows.Controls.Label label = new System.Windows.Controls.Label { Content = prompt };
                TextBox textBox = new TextBox { Margin = new Thickness(0, 15, 0, 15) };
                Button button = new Button { Content = "Opslaan" };
                Button Annuleren = new Button { Content = "Annuleren" };

                button.Click += (sender, e) => window.Close();
                Annuleren.Click += (sender, e) => window.Close();

                stackPanel.Children.Add(label);
                stackPanel.Children.Add(textBox);
                stackPanel.Children.Add(button);
                stackPanel.Children.Add(Annuleren);

                window.Content = stackPanel;

                window.ShowDialog();

                return textBox.Text;
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) // nieuwe wedstrijd
        {
            SkpLinks.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            string rdbP100 = "";
            string Thuisploeg = "";
            string Bezoekers = "";
            string Uitslag = "";
            string Handicap = "";

            if (RdbP100.IsChecked == false && RdbP200.IsChecked == false && RdbP300.IsChecked == false)
            {
                MessageBox.Show("Geen klasssement geselecteerd!");
            }else if (RdbP100.IsChecked == true)
            {
                 rdbP100 = "P100";
            }
            else if (RdbP200.IsChecked == true)
            {
                 rdbP100 = "P200";
            }
            else if (RdbP300.IsChecked == true)
            {
                 rdbP100 = "P300";
            }

            if (CbThuisPloeg.SelectedIndex == null
                && CbBezoekers.SelectedIndex == null)
            {
                MessageBox.Show("Team van thuis en bewoekers moet geselecteerd zijn!");
            }
            else
            {
                 Thuisploeg = CbThuisPloeg.SelectedItem.ToString();
                 Bezoekers = CbBezoekers.SelectedItem.ToString();
            }

            if(CbBezoekers.SelectedItem.ToString() == CbThuisPloeg.SelectedItem.ToString())
            {
                MessageBox.Show("Thuisploeg en boezoekers moeten verschillende zijn!");
            }

            if(TxtUitslag.Text.Length == 0) {
                MessageBox.Show("Uitslag is neit correct");
            }
            else
            {
                 Uitslag = TxtUitslag.Text;
            }

            if(ChkHandicap.IsChecked == true)
            {
                 Handicap = "J";
            }
            else
            {
                 Handicap = "N";
            }

            string[,] Nieuwe = { { Thuisploeg, Bezoekers, Uitslag, Handicap, rdbP100 } };

            Array.Copy(Nieuwe, 0, Uitslagen, 2, 5);

            VulListbox();
        }

        private void BtnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            SkpLinks.Children.Clear();
            SkpLinks.Visibility = Visibility.Hidden;

        }

        private void CbTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("De totale Kostprijs voor " + CbTeams.SelectedItem.ToString() + " Bedgraaat: $ " + PrijsPerKlassementTeams(CbTeams.SelectedItem.ToString()));
        }

        private string PrijsPerKlassementTeams(string TeamNaam)
        {
            double prijs = 0;

            if (string.IsNullOrEmpty(TeamNaam)) { return ""; }
            else if (TeamNaam == "Padel Hasselt" || TeamNaam == "Padel Hasselt")
            {
                prijs = 12.50;
            }
            else
            {
                prijs = 15;
            }


            return prijs.ToString();
        }

    }
}