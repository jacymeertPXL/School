using Coockie_Clicker.Classes;
using Coockie_Clicker.Models;
using System;
using System.Collections.Generic;
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

namespace Coockie_Clicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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

        // Timer
        private DispatcherTimer timer;

        public MainWindow() // Werkt is timing van 10 Milliseconden
        {
            InitializeComponent();

            BtnCursor.Visibility = Visibility.Hidden;
            BtnGrandma.Visibility = Visibility.Hidden;
            BtnFarm.Visibility = Visibility.Hidden;
            BtnMine.Visibility = Visibility.Hidden;
            BtnFactory.Visibility = Visibility.Hidden;
            BtnBank.Visibility = Visibility.Hidden;
            BtnTemple.Visibility = Visibility.Hidden;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) // Werkt
        {
            UpdateCounterText();
            UpdateScoreText();
            UpdateInvestmentButtonVisibility();
            UpdateButtonEnabledState(BtnCursor, CursorClass.Prijs);
            UpdateButtonEnabledState(BtnGrandma, GrandmaClass.Prijs);
            UpdateButtonEnabledState(BtnFarm, FarmClass.Prijs);
            UpdateButtonEnabledState(BtnMine, MineClass.Prijs);
            UpdateButtonEnabledState(BtnFactory, FactoryClass.Prijs);
        }

        private void UpdateCounterText() // Werkt
        {
            if (Income >= 0)
            {
                Score += Income;
                LbCounter.Content = Score;
            }
        }

        private void UpdateScoreText() // werkt
        {
            LbIncome.Content = FormaatGrootGetal(Income);
            LbCounter.Content = FormaatGrootGetal(Score);
            LbClicked_Text.Content = Clicked;
            LbUpgrades_Text.Content = Bought;
            LbUsed_Text.Content = Used;
            LbPrijsCursor.Content = FormaatGrootGetal_Prijs(CursorClass.Prijs);
            LbPrijsFactory.Content = FormaatGrootGetal_Prijs(FactoryClass.Prijs);
            LbPrijsFarm.Content = FormaatGrootGetal_Prijs(FarmClass.Prijs);
            LbPrijsGrandma.Content = FormaatGrootGetal_Prijs(GrandmaClass.Prijs);
            LbPrijsMine.Content = FormaatGrootGetal_Prijs(MineClass.Prijs);
        }

        private string FormaatLeesbaar_018(int number) // Werkt maar nog niet toegepast
        {
            if (number < 1000 || number >= 1000000)
            {
                return number.ToString();
            }

            string formattedNumber = number.ToString("### ###");

            return formattedNumber;
        }

        private string FormaatGrootGetal(double number) // Werkt
        {
            string[] terms = { "", "Duizend", "Miljoen", "Miljard", "Biljoen", "Biljard", "Triljoen" };

            int index = 0;
            while (number >= 1000)
            {
                number /= 1000;
                index++;
            }

            return $"{number:F3} {terms[index]}";
        }

        private string FormaatGrootGetal_Prijs(double number) // Werkt
        {
            string[] terms = { "", "Duizend", "Miljoen", "Miljard", "Biljoen", "Biljard", "Triljoen" };

            int index = 0;
            while (number >= 1000)
            {
                number /= 1000;
                index++;
            }

            return $"{number:F0} {terms[index]}";
        }

        private void UpdateButtonEnabledState(Button button, double Value) // Werkt
        {
            button.IsEnabled = Score >= Value;
        }

        private void UpdateInvestmentButtonVisibility() // Werkt moet optimized worden
        {
            double totalCookies = Score + Used;

            if (!CursorClass.CursorButtonVisible && totalCookies >= CursorClass.Prijs)
            {
                BtnCursor.Visibility = Visibility.Visible;
                CursorClass.CursorButtonVisible = true;
            }

            if (!GrandmaClass.CursorButtonVisible && totalCookies >= GrandmaClass.Prijs)
            {
                BtnGrandma.Visibility = Visibility.Visible;
                GrandmaClass.CursorButtonVisible = true;
            }

            if (!FarmClass.CursorButtonVisible && totalCookies >= FarmClass.Prijs)
            {
                BtnFarm.Visibility = Visibility.Visible;
                FarmClass.CursorButtonVisible = true;
            }

            if (!MineClass.CursorButtonVisible && totalCookies >= MineClass.Prijs)
            {
                BtnMine.Visibility = Visibility.Visible;
                MineClass.CursorButtonVisible = true;
            }

            if (!FactoryClass.CursorButtonVisible && totalCookies >= FactoryClass.Prijs)
            {
                BtnFactory.Visibility = Visibility.Visible;
                FactoryClass.CursorButtonVisible = true;
            }

            if (!BankClass.CursorButtonVisible && totalCookies >= BankClass.Prijs)
            {
                BtnBank.Visibility = Visibility.Visible;
                BankClass.CursorButtonVisible = true;
            }

            if (!TempleClass.CursorButtonVisible && totalCookies >= TempleClass.Prijs)
            {
                BtnTemple.Visibility = Visibility.Visible;
                TempleClass.CursorButtonVisible = true;
            }
        }

        private void UpdateLabelContent(double Value, double income) // Werkt
        {
            Score -= Value;
            Income += income;
            Used += Value;
            Bought++;

            UpdateScoreText();
            UpdateInvestmentButtonVisibility();
        }

        private void LbName_MouseDown(object sender, MouseButtonEventArgs e) // Werkt
        {
            string NieuweNaam = WijzigNaamCookieClicker.Show("Bakkerij Naam wijzigen", "Voer de nieuwe bakkerij naam in:");

            if (!string.IsNullOrWhiteSpace(NieuweNaam))
            {
                LbName.Content = NieuweNaam;
            }
            else
            {
                MessageBox.Show("Ongeldige naam. De naam mag niet leeg zijn of alleen uit witruimte bestaan.");
            }
        }

        public static class WijzigNaamCookieClicker // Werkt
        {
            public static string Show(string title, string prompt)
            {

                Window window = new Window
                {
                    Title = title,
                    Width = 350,
                    Height = 250,
                    WindowStartupLocation = WindowStartupLocation.CenterScreen,
                    ResizeMode = ResizeMode.CanResize
                };

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
        private void Cookie_MouseDown(object sender, RoutedEventArgs e) // Werkt 
        {
            Score++;
            Clicked++;
            UpdateScoreText();

            if (sender is Image image)
            {
                ScaleTransform scaleTransform = new ScaleTransform(1.0, 1.0);
                image.RenderTransform = scaleTransform;

                DoubleAnimation animation = new DoubleAnimation(1.2, 1.0, TimeSpan.FromSeconds(0.3));
                scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, animation);
                scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, animation);
            }
        }

        //private void Class_Button_Click(object obj, Button button, double income)
        //{
        //    var prijsProperty = obj.GetType().GetProperty("Prijs");
        //    var tellerProperty = obj.GetType().GetProperty("Teller");
        //    double prijs = (double)prijsProperty.GetValue(obj);
        //    int teller = (int)tellerProperty.GetValue(obj);

        //    obj.GetType().GetMethod("PrijsVerhogen");
        //    obj.GetType().GetMethod("GekockteUpgrade");

        //    if (button == BtnCursor) LbCursor.Content = teller.ToString();
        //    else if (button == BtnGrandma) LbGrandma.Content = teller.ToString();
        //    else if (button == BtnFarm) LbFarm.Content = teller.ToString();
        //    else if (button == BtnMine) LbMine.Content = teller.ToString();
        //    else if (button == BtnFactory) LbFactory.Content = teller.ToString();

        //    UpdateButtonEnabledState(button, prijs);
        //    UpdateLabelContent(prijs, income);
        //}
        private void BtnCursor_Click(object sender, RoutedEventArgs e)
        {

            //Class_Button_Click(CursorClass, BtnCursor, 0.0001);

            double Prijs = (double)CursorClass.Prijs;
            double income = 0.001;

            CursorClass.GekockteCursor();
            CursorClass.PrijsVerhogen();

            int TellerCursos = CursorClass.Teller;
            // LbCursor.Content = TellerCursos.ToString();

            UpdateButtonEnabledState(BtnCursor, Prijs);
            UpdateLabelContent(Prijs, income);
        }

        private void BtnGrandma_Click(object sender, RoutedEventArgs e)
        {

            double Prijs = (double)GrandmaClass.Prijs;
            double income = 0.01;

            GrandmaClass.GekockteGrandma();
            GrandmaClass.PrijsVerhogen();

            int TellerGrandma = GrandmaClass.Teller;

            // LbGrandma.Content = TellerGrandma.ToString();

            UpdateButtonEnabledState(BtnGrandma, Prijs);
            UpdateLabelContent(Prijs, income);
        }

        private void BtnFarm_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)FarmClass.Prijs;
            double income = 0.08;

            FarmClass.GekockteFarm();
            FarmClass.PrijsVerhogen();

            int TellerFarm = FarmClass.Teller;

            // LbFarm.Content = TellerFarm.ToString();

            UpdateButtonEnabledState(BtnFactory, Prijs);
            UpdateLabelContent(Prijs, income);

        }

        private void BtnMine_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)MineClass.Prijs;
            double income = 0.47;

            MineClass.GekockteMinea();
            MineClass.PrijsVerhogen();

            int TellerMine = MineClass.Teller;

            // LbMine.Content = TellerMine.ToString();

            UpdateButtonEnabledState(BtnFarm, Prijs);
            UpdateLabelContent(Prijs, income);
        }

        private void BtnFactory_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)FactoryClass.Prijs;
            double income = 2.60;

            FactoryClass.GekockteFactory();
            FactoryClass.PrijsVerhogen();

            int TellerFactory = FactoryClass.Teller;

            // LbFactory.Content = TellerFactory.ToString();

            UpdateButtonEnabledState(BtnMine, Prijs);
            UpdateLabelContent(Prijs, income);
        }

        private void BtnBank_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)BankClass.Prijs;
            double income = 14;

            BankClass.GekockteBank();
            BankClass.PrijsVerhogen();

            int TellerBank = BankClass.Teller;

            //LbBank.Content = TellerBank.ToString();

            UpdateButtonEnabledState(BtnBank, Prijs);
            UpdateLabelContent(Prijs, income);
        }

        private void BtnTemple_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)TempleClass.Prijs;
            double income = 78;

            TempleClass.GekockteTemple();
            TempleClass.PrijsVerhogen();
            
            int TellerTemple = TempleClass.Teller;

            // LbFactory.Content = TellerTemple.ToString();

            UpdateButtonEnabledState(BtnTemple, Prijs);
            UpdateLabelContent(Prijs, income);
        }
    }
}
