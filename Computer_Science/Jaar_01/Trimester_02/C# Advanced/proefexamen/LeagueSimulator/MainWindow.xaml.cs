using LeagueClassLibrary.DataAccess;
using LeagueClassLibrary.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Threading;

namespace LeagueSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer timer = new DispatcherTimer();

        private Match currentMatch;

        public MainWindow()
        {
            InitializeComponent();
            InitializePositions();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CheckBoxLaadChamionData.IsChecked == true && CheckBoxLaadAbilityData.IsChecked == true)
            {
                TabItemSimuleerMatch.IsEnabled = true;
                TabItemOverzichtMatches.IsEnabled = true;
                //DataGridChampions.ItemsSource = ChampionData.GetDataViewChampion();
                //DataGridMatches.ItemsSource = MatchData.GetDataViewMatches();
            }
        }

        private void InitializePositions()
        {
            var positions = new List<string> { "sup", "mid", "bot", "jung", "top" };
            ComboBoxPositions.ItemsSource = positions;
        }

        private void LaadChampionDataButton_Click(object sender, RoutedEventArgs e)
        {
            ChampionData.LoadCSV("C:\\Users\\Gebruiker\\Documents\\GitHub\\jacymeertPXL\\Computer_Science\\Jaar_01\\Trimester_02\\C# Advanced\\proefexamen\\LeagueSimulator\\csv\\leagueOfLegendsChampions.csv");
            DataGridChampions.ItemsSource = ChampionData.GetDataViewChampion();
            if (DataGridChampions.ItemsSource != null)
            {
                CheckBoxLaadChamionData.IsChecked = true;
            }
        }

        private void LaadAbilityDataButton_Click(object sender, RoutedEventArgs e)
        {
            //AbilityData.LoadCSV("C:\\Users\\Gebruiker\\Documents\\GitHub\\jacymeertPXL\\Computer_Science\\Jaar_01\\Trimester_02\\C# Advanced\\proefexamen\\LeagueSimulator\\csv\\leagueOfLegendsAbilities.csv");
            CheckBoxLaadAbilityData.IsChecked = true;
        }

        private void ComboBoxPositions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxPositions.SelectedItem != null)
            {
                string selectedPosition = ComboBoxPositions.SelectedItem.ToString();
                DataGridChampions.ItemsSource = ChampionData.GetDataViewChampionsByPosition(selectedPosition);
            }
        }

        private void BestToWorstButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridChampions.ItemsSource = ChampionData.GetDataViewChampionsBestToWorst();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridChampions.ItemsSource = ChampionData.GetDataViewChampion();
        }

        private void DataGridChampions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGridChampions.SelectedItem != null)
            {
                if (DataGridChampions.SelectedItem is Champion)
                {
                    // Als het geselecteerde item een Champion object is
                    Champion selectedChampion = (Champion)DataGridChampions.SelectedItem;
                    TextBlockChampionTitle.Text = $"{selectedChampion.Name} - {selectedChampion.Title}";
                    ImageChampion.Source = new BitmapImage(new Uri(selectedChampion.IconSource, UriKind.Relative));
                }
                else if (DataGridChampions.SelectedItem is DataRowView)
                {
                    // Als het geselecteerde item een DataRowView object is
                    DataRowView selectedDataRow = (DataRowView)DataGridChampions.SelectedItem;
                    string name = selectedDataRow["ChampionName"].ToString();
                    string title = selectedDataRow["ChampionTitle"].ToString();
                    string iconSource = selectedDataRow["ChampionIcon"].ToString();
                    TextBlockChampionTitle.Text = $"{name} - {title}";
                    ImageChampion.Source = new BitmapImage(new Uri(iconSource, UriKind.Relative));
                }
            }

        }

        private void LaadChampion(int indexChampion, int team)
        {
            Champion champion = (team == 1) ? currentMatch.Team1Champions[indexChampion] : currentMatch.Team2Champions[indexChampion];
            ImageBanner.Source = new BitmapImage(new Uri(champion.BannerSource, UriKind.Relative));
            TextBlockChampion.Text = $"{champion.Name} - {champion.Title}";
            TextBlockClass.Text = champion.Class;
            TextBlockCost.Text = champion.Getcost();
            ListBoxChampionAbilities.ItemsSource = champion.Abilities;
        }

        private void ImageIconChampion1Team1_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(0, 1);
        }

        private void ImageIconChampion2Team1_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(1, 1);
        }

        private void ImageIconChampion3Team1_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(2, 1);
        }

        private void ImageIconChampion4Team1_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(3, 1);
        }

        private void ImageIconChampion5Team1_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(4, 1);
        }

        private void ImageIconChampion1Team2_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(0, 2);
        }

        private void ImageIconChampion2Team2_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(1, 2);
        }

        private void ImageIconChampion3Team2_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(2, 2);
        }

        private void ImageIconChampion4Team2_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(3,2);
        }

        private void ImageIconChampion5Team2_MouseEnter(object sender, MouseEventArgs e)
        {
            LaadChampion(4, 2);
        }

        private void Genereer5v5Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordBoxMatchCode.Password))
            {
                MessageBox.Show("Geen code ingegeven.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //if (MatchData.isUniquecode(PasswordBoxMatchCode.Password))
            //{
            //    currentMatch = new SummonersRif(PasswordBoxMatchCode.Password);
            //    currentMatch.GenerateTeams();
            //    LoadTeamsToUI();
            //}
            else
            {
                MessageBox.Show("Code is niet uniek.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Genereer3v3Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordBoxMatchCode.Password))
            {
                MessageBox.Show("Geen code ingegeven.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //if (MatchData.isUniquecode(PasswordBoxMatchCode.Password));
            //{
            //    currentMatch = new TwistedTreeline(PasswordBoxMatchCode.Password);
            //    currentMatch.GenerateTeams();
            //    LoadTeamsToUI();
            //}
            else
            {
                MessageBox.Show("Code is niet uniek.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadTeamsToUI()
        {
            // Update UI with team data
            for (int i = 0; i < currentMatch.Team1Champions.Count; i++)
            {
                string imageControlName = $"ImageIconChampion{i + 1}Team1";
                Image imgControl = (Image)this.FindName(imageControlName);
                imgControl.Source = new BitmapImage(new Uri(currentMatch.Team1Champions[i].IconSource, UriKind.Relative));
            }

            for (int i = 0; i < currentMatch.Team2Champions.Count; i++)
            {
                string imageControlName = $"ImageIconChampion{i + 1}Team2";
                Image imgControl = (Image)this.FindName(imageControlName);
                imgControl.Source = new BitmapImage(new Uri(currentMatch.Team2Champions[i].IconSource, UriKind.Relative));
            }
        }

        private void ExportToXMLButton_Click(object sender, RoutedEventArgs e)
        {
            MatchData.ExportToXML();
        }

        private void BeslisWinnaarButton_Click(object sender, RoutedEventArgs e)
        {
            currentMatch.DecideWinner();
            MatchData.AddFinishedMatch(currentMatch);
            ClearSimulatieTab();
        }

        private void ClearSimulatieTab()
        {
            for (int i = 1; i <= 5; i++)
            {
                Image imgControl1 = (Image)this.FindName($"ImageIconChampion{i}Team1");
                Image imgControl2 = (Image)this.FindName($"ImageIconChampion{i}Team2");
                imgControl1.Source = new BitmapImage(new Uri("images/icons/empty_icon.png", UriKind.Relative));
                imgControl2.Source = new BitmapImage(new Uri("images/icons/empty_icon.png", UriKind.Relative));
            }
            TextBlockChampion.Text = string.Empty;
            TextBlockClass.Text = string.Empty;
            TextBlockCost.Text = string.Empty;
            ListBoxChampionAbilities.ItemsSource = null;
        }
    }
}
