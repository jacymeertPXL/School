using Coockie_Clicker.Classes;
using Coockie_Clicker.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;
using System.Reflection;

namespace Coockie_Clicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Achievements Bools
        bool Grandma_Gekocht_25 = false;
        bool Grandma_Gekocht_100 = false;
        bool Income_100 = false;
        bool Cursor_Gekocht_10 = false;
        bool Temple_Gekocht = false;
        bool Cookies_Clicked_100 = false;
        bool Cookies_Clicked_100000 = false;
        bool Cookies_Clicked_1000000 = false;
        bool Upgrades_Gekocht_100 = false;
        bool Farm_Gekocht_50 = false;


        // Classes, Models
        Models.Cursor CursorClass = new Models.Cursor();
        Farm FarmClass = new Farm();
        Grandma GrandmaClass = new Grandma();
        Factory FactoryClass = new Factory();
        Mine MineClass = new Mine();
        Bank BankClass = new Bank();
        Temple TempleClass = new Temple();

        // Variable
        private double Score, Income, Clicked, Bought, Used;

        // Timers
        /// <summary>
        /// Timer voor layout-updates en klassen.
        /// </summary>
        private DispatcherTimer timer;
        /// <summary>
        /// Timer voor het verschijnen van het gouden koekje.
        /// </summary>
        private DispatcherTimer goldenCookieTimer;

        public MainWindow()
        {
            InitializeComponent();
            ButtonHidden();

            // Timer Tick voor de rest van het programma
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);

            timer.Tick += Timer_Tick;
            timer.Start();

            // Timer Tick voor Golden Cookie
            goldenCookieTimer = new DispatcherTimer();
            goldenCookieTimer.Interval = TimeSpan.FromMinutes(1);

            goldenCookieTimer.Tick += GoldenCookieTimer_Tick;
            goldenCookieTimer.Start();
        }

        private void ButtonHidden() 
        {
            // Normale Store Buttons
            BtnCursor.Visibility = Visibility.Hidden;
            BtnGrandma.Visibility = Visibility.Hidden;
            BtnFarm.Visibility = Visibility.Hidden;
            BtnMine.Visibility = Visibility.Hidden;
            BtnFactory.Visibility = Visibility.Hidden;
            BtnBank.Visibility = Visibility.Hidden;
            BtnTemple.Visibility = Visibility.Hidden;

            //Bonus Buttons
            BtnCursorBonus.Visibility = Visibility.Hidden;
            BtnFactoryBonus.Visibility = Visibility.Hidden;
            BtnFarmBonus.Visibility = Visibility.Hidden;
            BtnGrandmaBonus.Visibility = Visibility.Hidden;
            BtnMineBonus.Visibility = Visibility.Hidden;
            BtnTempleBonus.Visibility = Visibility.Hidden;
            BtnBankBonus.Visibility = Visibility.Hidden;
        }

        private void Timer_Tick(object sender, EventArgs e) 
        {
            // gaat elke 10 miliseconden alles visual updaten van de client.
            UpdateCounterText();
            UpdateScoreText();
            UpdateInvestmentButtonVisibility(); 
            ControleerAchievements();
            UpdateButtonEnabledState(BtnCursor, CursorClass.Prijs);
            UpdateButtonEnabledState(BtnCursorBonus, CursorClass.PrijsBonus);
            UpdateButtonEnabledState(BtnGrandma, GrandmaClass.Prijs);
            UpdateButtonEnabledState(BtnGrandmaBonus, GrandmaClass.PrijsBonus);
            UpdateButtonEnabledState(BtnFarm, FarmClass.Prijs);
            UpdateButtonEnabledState(BtnFarmBonus, FarmClass.PrijsBonus);
            UpdateButtonEnabledState(BtnMine, MineClass.Prijs);
            UpdateButtonEnabledState(BtnMineBonus, MineClass.PrijsBonus);
            UpdateButtonEnabledState(BtnFactory, FactoryClass.Prijs);
            UpdateButtonEnabledState(BtnFactoryBonus, FactoryClass.PrijsBonus);
            UpdateButtonEnabledState(BtnBank, BankClass.Prijs);
            UpdateButtonEnabledState(BtnBankBonus, BankClass.PrijsBonus);
            UpdateButtonEnabledState(BtnTemple, TempleClass.Prijs);
            UpdateButtonEnabledState(BtnTempleBonus, TempleClass.PrijsBonus);
        }

        private void GoldenCookieTimer_Tick(object sender, EventArgs e) 
        {
            if (new Random().Next(100) < 30) // 30 procent kans
            {
                ShowGoldenCookie();
            }
        }

        /// <summary>
        /// Controleert en geeft achievements weer.
        /// </summary>
        private void ControleerAchievements() // Werkt moet optimized worden met classes?
        {

            // achievements Coockie Clicked
            if (Clicked == 100 && !Cookies_Clicked_100)
            {
                MessageBox.Show("Yippie je hebt de; Klik 100 keer op de cookie; Achievement");
                Cookies_Clicked_100 = true;
            }
            if (Clicked == 100000 && !Cookies_Clicked_100000)
            {
                MessageBox.Show("Yippie je hebt de; Klik 100 000 keer op de cookie; Achievement");
                Cookies_Clicked_100000 = true;
            }
            if (Clicked == 1000000 && !Cookies_Clicked_1000000)
            {
                MessageBox.Show("Yippie je hebt de; Klik 1 000 000 keer op de cookie; Achievement");
                Cookies_Clicked_1000000 = true;
            }
            if(Bought == 100 && !Upgrades_Gekocht_100)
            {
                MessageBox.Show("Yippie je hebt de; Kloop 100 upgrades; Achievement");
                Upgrades_Gekocht_100 = true;
            }
            if (Income == 100 && !Income_100)
            {
                MessageBox.Show("Yippie je hebt de; Je hebt een income van 100 behaalt; Achievement");
                Income_100 = true;
            }
            if (GrandmaClass.Gekocht == 25 && !Grandma_Gekocht_25)
            {
                MessageBox.Show("Yippie je hebt de; Je hebt een 25 grandmas gekocht; Achievement");
                Grandma_Gekocht_25 = true;
            }
            if (GrandmaClass.Gekocht == 100 && !Grandma_Gekocht_100)
            {
                MessageBox.Show("Yippie je hebt de; Je hebt een 100 grandmas gekocht; Achievement");
                Grandma_Gekocht_100 = true;
            }
            if (TempleClass.Gekocht == 1 && !Temple_Gekocht)
            {
                MessageBox.Show("Yippie je hebt de; Je hebt een Temple gekocht; Achievement");
                Temple_Gekocht = true;
            }
            if (CursorClass.Gekocht == 10 && !Cursor_Gekocht_10)
            {
                MessageBox.Show("Yippie je hebt de; Je hebt een 10 Cursors gekocht; Achievement");
                Cursor_Gekocht_10 = true;
            }
            if (FarmClass.Gekocht == 100 && !Farm_Gekocht_50)
            {
                MessageBox.Show("Yippie je hebt de; Je hebt een 50 farms gekocht; Achievement");
                Farm_Gekocht_50 = true;
            }
        }

        private void ShowGoldenCookie() 
        {
            // Code om een gouden koekje weer te geven
            double left = new Random().Next((int)ActualWidth);
            double top = new Random().Next((int)ActualHeight);

            // aanmaken van golden cookie
            Image Goldencookie = new Image
            {   
                Source = new BitmapImage(new Uri("/img/Golden_cookie.png", UriKind.Relative)),
                Width = 20,
                Height = 20,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(left, top, 0, 0)
            };

            Goldencookie.MouseDown += Goldencookie_MouseDown;

            // Voeg het gouden koekje toe aan het scherm
            cookie_Grid.Children.Add(Goldencookie);

            // animatie 
            DoubleAnimation animation = new DoubleAnimation(1.0, 0.0, TimeSpan.FromSeconds(5));
            Goldencookie.BeginAnimation(OpacityProperty, animation);
        }

        private void Goldencookie_MouseDown(object sender, MouseButtonEventArgs e) 
        {
            double cookieValue = CalculateCookieValue();

            Score += cookieValue; // nieuwe scoren
            cookie_Grid.Children.Remove(sender as UIElement); // delete golden cookie
        }

        private double CalculateCookieValue() 
        {
            double Totaalincome = Convert.ToDouble(LbIncome.Content); // Huidige hoeveelheid

            double TotaalincomeNa15Min = Totaalincome * 15 * 60; // Bereken het bedrag na 15 minuten
            return TotaalincomeNa15Min;
        }

        private void UpdateCounterText()
        {
            if (Income >= 0)
            {
                if(Score >= 0)
                {
                    double newScore = Score + Income;
                    Score = Math.Max(0, newScore); // Zorg ervoor dat de Score nooit onder nul komt
                    LbCounter.Content = Score;
                }
            }
        }

        private void UpdateScoreText()
        {
            // Lables correct houden met de juiste format en 10 mil update
            // Labels Extras
            LbIncome.Content = FormaatGrootGetal(Income);
            LbCounter.Content = FormaatGrootGetal(Score);
            LbClicked_Text.Content = FormaatLeesbaar_018_short(Clicked);
            LbUpgrades_Text.Content = FormaatLeesbaar_018_short(Bought);
            LbUsed_Text.Content = FormaatLeesbaar_018(Used);

            // labels Prijs Normale Store
            LbPrijsCursor.Content = FormaatGrootGetal_Prijs(CursorClass.Prijs);
            LbPrijsFactory.Content = FormaatGrootGetal_Prijs(FactoryClass.Prijs);
            LbPrijsFarm.Content = FormaatGrootGetal_Prijs(FarmClass.Prijs);
            LbPrijsGrandma.Content = FormaatGrootGetal_Prijs(GrandmaClass.Prijs);
            LbPrijsMine.Content = FormaatGrootGetal_Prijs(MineClass.Prijs);
            LbPrijsBank.Content = FormaatGrootGetal_Prijs(BankClass.Prijs);
            LbPrijsTemple.Content = FormaatGrootGetal_Prijs(TempleClass.Prijs);

            // Labels Prijs Bonus Store
            LbPrijsCursorBonus.Content = FormaatGrootGetal_Prijs(CursorClass.PrijsBonus);
            LbPrijsGrandmaBonus.Content = FormaatGrootGetal_Prijs(GrandmaClass.PrijsBonus);
            LbPrijsFarmBonus.Content = FormaatGrootGetal_Prijs(FarmClass.PrijsBonus);
            LbPrijsMineBonus.Content = FormaatGrootGetal_Prijs(MineClass.PrijsBonus);
            LbPrijsFactoryBonus.Content = FormaatGrootGetal_Prijs(FactoryClass.PrijsBonus);
            LbPrijsBankBonus.Content = FormaatGrootGetal_Prijs(BankClass.PrijsBonus);
            LbPrijsTempleBonus.Content = FormaatGrootGetal_Prijs(TempleClass.PrijsBonus);

            // Labels Multi Bonus Store
            LbCursorMulti.Content = CursorClass.Teller;
            LbGrandmaMulti.Content = GrandmaClass.Teller;
            LbFarmMulti.Content = FarmClass.Teller;
            LbMineMulti.Content = MineClass.Teller;
            LbFactoryMulti.Content = FactoryClass.Teller;
            LbBankMulti.Content = BankClass.Teller;
            LbTempelMulti.Content = TempleClass.Teller;
        }

        /// <summary>
        /// Numbers tussen 1000 en 10000 krijgen Human Readable voor short numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string FormaatLeesbaar_018_short(double number) 
        {
            if (number < 1000 || number >= 1000000) // controleer als tussen deze waarden 
            {
                return number.ToString();
            }

            string formattedNumber = number.ToString("### ###.00");

            return formattedNumber;
        }

        /// <summary>
        /// Numbers tussen 1000 en 10000 krijgen Human Readable.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string FormaatLeesbaar_018(double number) 
        {
            if (number < 1000 || number >= 1000000) // controleer als tussen deze waarden 
            {
                return number.ToString("0.00");
            }

            string formattedNumber = number.ToString("### ###.00");

            return formattedNumber;
        }

        /// <summary>
        /// Getallen boven 1000 worden Human Readable.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string FormaatGrootGetal(double number) 
        {
            // Human Readable voor alles boven 1000
            string[] terms = { "", "Duizend", "Miljoen", "Miljard", "Biljoen", "Biljard", "Triljoen" };

            int index = 0;
            while (number >= 1000)
            {
                number /= 1000;
                index++;
            }

            return $"{number:F3} {terms[index]}";
        }
        /// <summary>
        /// Getallen boven 1000 worden Human Readable voor prijs
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string FormaatGrootGetal_Prijs(double number) 
        {
            // Human Readable voor alles boven 1000
            string[] terms = { "", "Duizend", "Miljoen", "Miljard", "Biljoen", "Biljard", "Triljoen" };

            int index = 0;
            while (number >= 1000)
            {
                number /= 1000;
                index++;
            }

            // Prijs van de items gaat nooit een koma getal moeten voorstellen andere formating
            return $"{number:F1} {terms[index]}";
        }

        private void UpdateButtonEnabledState(Button button, double Value) 
        {
            // als de button clickable is voor de client op de juiste waarde 
            button.IsEnabled = Score >= Value;
        }

        private void UpdateInvestmentButtonVisibility() 
        {
            double totalCookies = Score + Used;

            object[] classes = new object[7] { CursorClass, GrandmaClass, FarmClass, MineClass, FactoryClass, BankClass, TempleClass };

            foreach (object obj in classes)
            {
                if (obj != null)
                {
                    if (obj == CursorClass && totalCookies >= CursorClass.Prijs && !CursorClass.CursorButtonVisible)
                    {
                        BtnCursor.Visibility = Visibility.Visible;
                        BtnCursorBonus.Visibility = Visibility.Visible;
                        CursorClass.CursorButtonVisible = true;

                    }
                    if (obj == GrandmaClass && totalCookies >= GrandmaClass.Prijs && !GrandmaClass.CursorButtonVisible)
                    {
                        BtnGrandma.Visibility = Visibility.Visible;
                        BtnGrandmaBonus.Visibility = Visibility.Visible;
                        GrandmaClass.CursorButtonVisible = true;
                    }
                    if (obj == FarmClass && totalCookies >= FarmClass.Prijs && !FarmClass.CursorButtonVisible)
                    {
                        BtnFarm.Visibility = Visibility.Visible;
                        BtnFactoryBonus.Visibility = Visibility.Visible;
                        CursorClass.CursorButtonVisible = true;
                    }
                    if (obj == FarmClass && totalCookies >= FarmClass.Prijs && !CursorClass.CursorButtonVisible)
                    {
                        BtnMine.Visibility = Visibility.Visible;
                        BtnMineBonus.Visibility = Visibility.Visible;
                        FarmClass.CursorButtonVisible = true;
                    }
                    if (obj == FactoryClass && totalCookies >= FactoryClass.Prijs && !FactoryClass.CursorButtonVisible)
                    {
                        BtnFactory.Visibility = Visibility.Visible;
                        BtnFactoryBonus.Visibility = Visibility.Visible;   
                        FactoryClass.CursorButtonVisible = true;
                    }
                    if (obj == BankClass && totalCookies >= BankClass.Prijs && !BankClass.CursorButtonVisible)
                    {
                        BtnBank.Visibility = Visibility.Visible;
                        BtnBankBonus.Visibility = Visibility.Visible;
                        BankClass.CursorButtonVisible = true;
                    }
                    if (obj == TempleClass && totalCookies >= TempleClass.Prijs && !TempleClass.CursorButtonVisible)
                    {
                        BtnTemple.Visibility = Visibility.Visible;
                        BtnTempleBonus.Visibility = Visibility.Visible; 
                        TempleClass.CursorButtonVisible = true;
                    }
                }
            }
        }

        private void UpdateLabelContent(double Value, double income) 
        {
            double newScore = Score - Value;
            if (newScore >= 0)
            {
                Score = newScore;
                Income += income;
                Used += Value;
                Bought++;

                UpdateScoreText();
                UpdateInvestmentButtonVisibility();
            }
            else
            {
                MessageBox.Show("Onvoldoende cookies beschikbaar voor deze aankoop.");
            }
        }

        private void UpdateLabelContent(double Value) 
        {
            double newScore = Score - Value;
            if (newScore >= 0)
            {
                Score = newScore;
                Used += Value;
                Bought++;

                UpdateScoreText();
                UpdateInvestmentButtonVisibility();
            }
            else
            {
                MessageBox.Show("Onvoldoende cookies beschikbaar voor deze aankoop.");
            }
        }

        private void LbName_MouseDown(object sender, MouseButtonEventArgs e) 
        {
            // gebruik maken van window maken functie
            string NieuweNaam = WijzigNaamCookieClicker.Show("Bakkerij Naam wijzigen", "Voer de nieuwe bakkerij naam in:");

            // controleren als de jusite waarde is ingegeven
            if (!string.IsNullOrWhiteSpace(NieuweNaam))
            {
                LbName.Content = NieuweNaam;
            }
            else
            {
                MessageBox.Show("Ongeldige naam. De naam mag niet leeg zijn of alleen uit witruimte bestaan.");
            }
        }

        public static class WijzigNaamCookieClicker 
        {
            public static string Show(string title, string prompt)
            {

                // nieuwe Window maken
                Window window = new Window
                {
                    Title = title,
                    Width = 350,
                    Height = 250,
                    WindowStartupLocation = WindowStartupLocation.CenterScreen,
                    ResizeMode = ResizeMode.CanResize
                };

                //stackpanel voor de content van de label op te vullen met de juiste elementen voor de name change.
                StackPanel stackPanel = new StackPanel();

                System.Windows.Controls.Label label = new System.Windows.Controls.Label { Content = prompt };
                TextBox textBox = new TextBox { Margin = new Thickness(0, 15, 0, 15) };
                Button button = new Button { Content = "Opslaan" };

                button.Click += (sender, e) => window.Close();

                stackPanel.Children.Add(label);
                stackPanel.Children.Add(textBox);
                stackPanel.Children.Add(button);

                window.Content = stackPanel;

                window.ShowDialog();

                return textBox.Text;
            }
        }

        private void stackpanelImage(StackPanel stackPanel, string imageSource) // Beter Maken
        {
            Image Img = new Image();
            Img.Source = new BitmapImage(new Uri(imageSource, UriKind.Relative));
            Img.Height = 32;
            Img.Width = 37;
            stackPanel.Children.Add(Img);
        }

        private void Cookie_MouseDown(object sender, RoutedEventArgs e) 
        {
            Score++;
            Clicked++;
            UpdateScoreText();

            // mousedown op image voor COOKIECLICKER-03
            if (sender is Image image)
            {
                // animatie voor COOKIECLICKER-04 en COOKIECLICKER-05.
                ScaleTransform scaleTransform = new ScaleTransform(1.0, 1.0);
                image.RenderTransform = scaleTransform;

                DoubleAnimation animation = new DoubleAnimation(1.2, 1.0, TimeSpan.FromSeconds(0.3));
                scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, animation);
                scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, animation);
            }
        }

        public void UpdateIncome(double income, double teller, double gekocht)
        {
            double nieuweIncome = teller * (gekocht * income);
            double nieuweIncomeAfnemen = gekocht * income;

            Income -= nieuweIncomeAfnemen;
            Income += nieuweIncome;
        }

        //private void Class_Button_Click(object obj, Button button, double income)
        //{
        //    var prijsProperty = obj.GetType().GetProperty("Prijs");
        //    var tellerProperty = obj.GetType().GetProperty("Teller");
        //    double prijs = (double)prijsProperty.GetValue(obj);
        //    int teller = (int)tellerProperty.GetValue(obj);

        //    obj.GetType().GetMethod("GekockteUpgrade");
        //    obj.GetType().GetMethod("PrijsVerhogen");

        //    //if (button == BtnCursor) LbCursor.Content = teller.ToString();
        //    //else if (button == BtnGrandma) LbGrandma.Content = teller.ToString();
        //    //else if (button == BtnFarm) LbFarm.Content = teller.ToString();
        //    //else if (button == BtnMine) LbMine.Content = teller.ToString();
        //    //else if (button == BtnFactory) LbFactory.Content = teller.ToString();

        //    UpdateButtonEnabledState(button, prijs);
        //    UpdateLabelContent(prijs, income);
        //}

        private void BtnCursor_Click(object sender, RoutedEventArgs e)
        {

            //Class_Button_Click(CursorClass, BtnCursor, 0.001);

            double Prijs = (double)CursorClass.Prijs;
            double Income = 0.001;

            CursorClass.Gekocht++;
            CursorClass.PrijsVerhogen();

            stackpanelImage(SkpCursor, "/img/Cursor.png");
            UpdateButtonEnabledState(BtnCursor, Prijs);
            UpdateLabelContent(Prijs, Income);
        }

        private void BtnCursorBonus_Click(object sender, RoutedEventArgs e)
        {
            double BonusPrijs = (double)CursorClass.PrijsBonus;

            UpdateIncome(0.001, CursorClass.Teller, CursorClass.Gekocht);

            CursorClass.PrijsVerhogenBonus();
            CursorClass.GekockteBonusCursor();

            UpdateButtonEnabledState(BtnCursorBonus, BonusPrijs);
            UpdateLabelContent(BonusPrijs);
        }

        private void BtnGrandma_Click(object sender, RoutedEventArgs e)
        {

            double Prijs = (double)GrandmaClass.Prijs;
            double Income = 0.01;

            GrandmaClass.Gekocht++;
            GrandmaClass.PrijsVerhogen();

            stackpanelImage(SkpGrandma, "/img/Grandma.png");
            UpdateButtonEnabledState(BtnGrandma, Prijs);
            UpdateLabelContent(Prijs, Income);
        }

        private void BtnGrandmaBonus_Click(object sender, RoutedEventArgs e)
        {
            double BonusPrijs = (double)GrandmaClass.PrijsBonus;

            UpdateIncome(0.01, GrandmaClass.Teller, GrandmaClass.Gekocht);

            GrandmaClass.PrijsVerhogenBonus();
            GrandmaClass.GekockteBonusGrandma();

            UpdateButtonEnabledState(BtnGrandmaBonus, BonusPrijs);
            UpdateLabelContent(BonusPrijs);
        }

        private void BtnFarm_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)FarmClass.Prijs;
            double Income = 0.08;

            FarmClass.Gekocht++;
            FarmClass.PrijsVerhogen();

            stackpanelImage(SkpFarm, "/img/Farm.png");
            UpdateButtonEnabledState(BtnFactory, Prijs);
            UpdateLabelContent(Prijs, Income);

        }

        private void BtnFarmBonus_Click(object sender, RoutedEventArgs e)
        {
            double BonusPrijs = (double)FarmClass.PrijsBonus;

            UpdateIncome(0.08, FarmClass.Teller, FarmClass.Gekocht);

            FarmClass.PrijsVerhogenBonus();
            FarmClass.GekockteBonusFarm();

            UpdateButtonEnabledState(BtnFactoryBonus, BonusPrijs);
            UpdateLabelContent(BonusPrijs);
        }
        private void BtnMine_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)MineClass.Prijs;
            double Income = 0.47;

            MineClass.Gekocht++;
            MineClass.PrijsVerhogen();

            stackpanelImage(SkpMine, "/img/Mine.png");
            UpdateButtonEnabledState(BtnFarm, Prijs);
            UpdateLabelContent(Prijs, Income);
        }

        private void BtnMineBonus_Click(object sender, RoutedEventArgs e)
        {
            double BonusPrijs = (double)MineClass.PrijsBonus;

            UpdateIncome(0.47, MineClass.Teller, MineClass.Gekocht);

            MineClass.PrijsVerhogenBonus();
            MineClass.GekockteBonusMinea();

            UpdateButtonEnabledState(BtnMineBonus, BonusPrijs);
            UpdateLabelContent(BonusPrijs);
        }

        private void BtnFactory_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)FactoryClass.Prijs;
            double Income = 2.60;

            FactoryClass.Gekocht++;
            FactoryClass.PrijsVerhogen();

            stackpanelImage(SkpFactory, "/img/Factory.png");
            UpdateButtonEnabledState(BtnMine, Prijs);
            UpdateLabelContent(Prijs, Income);
        }

        private void BtnFactoryBonus_Click(object sender, RoutedEventArgs e)
        {
            double BonusPrijs = (double)FactoryClass.PrijsBonus;

            UpdateIncome(2.60, FactoryClass.Teller, FactoryClass.Gekocht);

            FactoryClass.PrijsVerhogenBonus();
            FactoryClass.GekockteBonusFactory();

            UpdateButtonEnabledState(BtnFactoryBonus, BonusPrijs);
            UpdateLabelContent(BonusPrijs);
        }

        private void BtnBank_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)BankClass.Prijs;
            double Income = 14;

            BankClass.Gekocht++;
            BankClass.PrijsVerhogen();

            stackpanelImage(SkpBank, "/img/Bank.png");
            UpdateButtonEnabledState(BtnBank, Prijs);
            UpdateLabelContent(Prijs, Income);
        }

        private void BtnBankBonus_Click(object sender, RoutedEventArgs e)
        {
            double BonusPrijs = (double)BankClass.PrijsBonus;

            UpdateIncome(14, BankClass.Teller, BankClass.Gekocht);

            BankClass.PrijsVerhogenBonus();
            BankClass.GekockteBonusBank();

            UpdateButtonEnabledState(BtnBankBonus, BonusPrijs);
            UpdateLabelContent(BonusPrijs);
        }

        private void BtnTemple_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)TempleClass.Prijs;
            double Income = 78;

            TempleClass.Gekocht++;
            TempleClass.PrijsVerhogen();

            stackpanelImage(SkpTemple, "/img/Temple.png");
            UpdateButtonEnabledState(BtnTemple, Prijs);
            UpdateLabelContent(Prijs, Income);
        }

        private void BtnTempleBonus_Click(object sender, RoutedEventArgs e)
        {
            double BonusPrijs = (double)TempleClass.PrijsBonus;

            UpdateIncome(78, BankClass.Teller, BankClass.Gekocht);

            TempleClass.PrijsVerhogenBonus();
            TempleClass.GekockteBonusTemple();

            UpdateButtonEnabledState(BtnTempleBonus, BonusPrijs);
            UpdateLabelContent(BonusPrijs);
        }

        private void Btn_Achievements_Click(object sender, RoutedEventArgs e)
        {
            Achievement achievements = new Achievement();
            achievements.Show();
        }
    }
}
