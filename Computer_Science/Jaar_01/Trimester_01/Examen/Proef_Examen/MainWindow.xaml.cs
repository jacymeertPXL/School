using System.Linq.Expressions;
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

namespace Proef_Examen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int AntwoordId;
        List<string> Vragenlist = new List<string>();
        String Vraag01, Vraag02, Vraag03, Vraag04;
        Boolean check = false;

        private string[,] vragen = new string[,]
        {
            { "100", "In the UK, the abbreviation NHS stands for National what Service?", "Humanity", "Health", "Honour", "Household", "2" },
            { "200", "Which Disney character famously leaves a glass slipper behind at a royal ball?", "Pocahontas", "Sleeping Beauty", "Cinderella", "Elsa", "3" },
            { "300", "What name is given to the revolving belt machinery in an airport that delivers checked luggage from the plane to baggage reclaim?", "Hangar", "Terminal", "Concourse", "Carousel", "4" },
            { "500", "Which of these brands was chiefly associated with the manufacture of household locks?" , "Phillips", "Flymo", "Chubb", "Ronseal", "3" },
            { "1000", "The hammer and sickle is one of the most recognisable symbols of which political ideology?", "Republicanism", "Communism", "Conservatism", "Liberalism", "2" },
            { "2000", "Which toys have been marketed with the phrase 'robots in disguise'?", "Bratz Dolls", "Sylvanian Families", "Hatchimals", "Transformers" , "4" },
            { "4000", "What does the word loquacious mean?", "Angry", "Chatty", "Beautiful", "Shy", "2" },
            { "8000", "Obstetrics is a branch of medicine particularly concerned with what?", "Childbirth", "Broken bones", "Heart conditions", "Old age", "1" },
            { "16000", "In Doctor Who, what was the signature look of the fourth Doctor, as portrayed by Tom Baker?", "Bow-tie, braces and tweed jacket", "Wide-brimmed hat and extra long scarf", "Pinstripe suit and trainers", "Cape, velvet jacket and frilly shirt", "2" },
            { "32000", "Which of these religious observances lasts for the shortest period of time during the calendar year?", "Ramadan", "Diwali", "Lent", "Hanukkah", "2" },
            { "64000", "At the closest point, which island group is only 50 miles south-east of the coast of Florida?", "Bahamas", "US Virgin Islands", "Turks and Caicos Islands", "Bermuda", "1"},
            { "125000", "Construction of which of these famous landmarks was completed first?" , "Empire State Building", "Royal Albert Hall", "Eiffel Tower", "Big Ben Clock Tower", "4" },
            { "250000", "Which of these cetaceans is classified as a 'toothed whale'?", "Gray whale", "Minke whale", "Sperm whale", "Humpback whale", "3" },
            { "500000", "Who is the only British politician to have held all four 'Great Offices of State' at some point during their career?" , "David Lloyd George", "Harold Wilson", "James Callaghan", "John Major", "3" },
            { "1 million", "In 1718, which pirate died in battle off the coast of what is now North Carolina?" , "Calico Jack", "Blackbeard", "Bartholomew Roberts", "Captain Kidd", "2" }
        };
        public MainWindow()
        {
            InitializeComponent();
            Opstarten();
            vraginlist();
        }
        private void vraginlist()
        {
            Vragenlist.Add(Vraag01);
            Vragenlist.Add(Vraag02);
            Vragenlist.Add(Vraag03);
            Vragenlist.Add(Vraag04);
        }
        private void hint()
        {
            int Nummer = 0;

            for (int i = 0; i < 2; i++)
            {
                int randomNummer02;
                do
                {
                    randomNummer02 = new Random().Next(1, Vragenlist.Count);
                } while (randomNummer02 == AntwoordId || randomNummer02 == Nummer);

                Nummer = randomNummer02;
                LstHint.Items.Add(Vragenlist[randomNummer02 -1]);
            }
        }
        private void RdbEen_Checked(object sender, RoutedEventArgs e)
        {
            RdbEen.IsEnabled = false;
            hint();
        }

        private void RbdTwee_Checked(object sender, RoutedEventArgs e)
        {
            RbdTwee.IsEnabled = false;
            hint();
        }

        private void RdbDrie_Checked(object sender, RoutedEventArgs e)
        {
            RdbDrie.IsEnabled = false;
            hint();
        }

        public void Opstarten()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    LbPrijs.Content = vragen[i, 0];
                    TxtWeergaven.Text = vragen[i, 1].ToString();
                    RdbAnswerOne.Content = vragen[i, 2].ToString();
                    RdbAnswerTwo.Content = vragen[i, 3].ToString();
                    RdbAnswerThree.Content = vragen[i, 4].ToString();
                    RdbAnswerFour.Content = vragen[i, 5].ToString();

                    Vraag01 = vragen[i, 2].ToString();
                    Vraag02 = vragen[i, 3].ToString();
                    Vraag03 = vragen[i, 4].ToString();
                    Vraag04 = vragen[i, 5].ToString();
                    AntwoordId = (int)Convert.ToInt64(vragen[i, 6]);

                    if (check == false)
                    {
                        break;
                    }
                    if (check == true)
                    {
                        continue;
                    }
                }

                if (check == false)
                {
                    break;
                }
                if (check == true)
                {
                    continue;
                }
            }
        }

        private void CbWeergaven_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CbWeergaven.SelectedItem != null)
            {
                if (CbWeergaven.SelectedItem == CbTijd)
                {
                    LbTijd.Content = DateTime.Now.TimeOfDay;
                }
                else if (CbWeergaven.SelectedItem == CbDag)
                {
                    LbTijd.Content = DateTime.Now.Date;
                }
                else if (CbWeergaven.SelectedItem == CbTijdEnDag)
                {
                    LbTijd.Content = DateTime.Now;
                }
            }
        }

        private void Verloren()
        {
            LbPrijs.Content = "Verloren";
            TxtWeergaven.Text = "Helaas,  Je bent al het geld Kwijt!";
            Grid.Background = new SolidColorBrush(Colors.Red);
            Grid.IsEnabled = false;

            // nieuwe Window maken
            string Verloren = "Verloren";
            Window window = new Window
            {
                Title = Verloren,
                Width = 250,
                Height = 100,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.CanResize
            };
            StackPanel stackPanel = new StackPanel();
            Button button = new Button { Content = "Ok" };
            System.Windows.Controls.Label label = new System.Windows.Controls.Label { Content = "Fout antwoord" };
            stackPanel.Children.Add(label);
            stackPanel.Children.Add(button);
            window.Content = stackPanel;

            button.Click += (sender, e) => window.Close();
            window.ShowDialog();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (RdbAnswerOne.IsChecked == true)
            {
                if( 1 == AntwoordId)
                {
                    check = true;
                    Opstarten();
                    check = false;
                }
                else
                {
                    Verloren();
                }
            }
            else if (RdbAnswerTwo.IsChecked == true)
            {
                if (2 == AntwoordId)
                {
                    check = true;
                    Opstarten();
                    check = false;
                }
                else
                {
                    Verloren(); 
                }
            }
            else if (RdbAnswerThree.IsChecked == true)
            {
                if (3 == AntwoordId)
                {
                    check = true;
                    Opstarten();
                    check = false;
                }
                else
                {
                    Verloren();
                }  
            }
            else if (RdbAnswerFour.IsChecked == true)
            {
                if (4 == AntwoordId)
                {
                    check = true;
                    Opstarten();
                    check = false;
                }
                else
                {
                    Verloren();
                }   
            }
        }
    }
}