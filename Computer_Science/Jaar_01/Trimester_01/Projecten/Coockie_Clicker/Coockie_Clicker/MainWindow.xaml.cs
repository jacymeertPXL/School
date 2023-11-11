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

        // Variable
        private double Score, Income, Clicked, Bought, Used;

        // Timer
        private DispatcherTimer timer;
        
        public MainWindow() // Werkt is timing van 10 Milliseconden
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) // Werkt
        {
            UpdateCounterText();
            UpdateScoreText();
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

        private void UpdateScoreText() // Werkt
        {
            LbIncome.Content = Income;
            LbCounter.Content = Score;
            LbClicked_Text.Content = Clicked;
            LbUpgrades_Text.Content = Bought;
            LbUsed_Text.Content = Used;
            LbPrijsCursor.Content = CursorClass.Prijs;
            LbPrijsFactory.Content = FactoryClass.Prijs;
            LbPrijsFarm.Content = FarmClass.Prijs;
            LbPrijsGrandma.Content = GrandmaClass.Prijs;
            LbPrijsMine.Content = MineClass.Prijs;
        } 

        private void UpdateButtonEnabledState(Button button, double Value) // Werkt
        {
            button.IsEnabled = Score >= Value;

            /*if (Convert.ToDouble(LbCounter.Content.ToString()) >= Value) oude code
            {
                button.IsEnabled = true;
            }
            else
            {
                button.IsEnabled = false;
            }*/

        }

        private void UpdateLabelContent(double Value, double income) // Werkt
        {
            Score -= Value;
            Income += income;
            Used += Value;
            Bought++;

            UpdateScoreText();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Werkt 
        {
            Score ++;
            Clicked++;
            UpdateScoreText();

            if (sender is Button button)
            {
                ScaleTransform scaleTransform = new ScaleTransform(1.0, 1.0);
                button.RenderTransform = scaleTransform;

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

            CursorClass.PrijsVerhogen();
            CursorClass.GekockteCursor();

            int TellerCursos = CursorClass.Teller;

            LbCursor.Content = TellerCursos.ToString();
            
            UpdateButtonEnabledState(BtnCursor, Prijs);
            UpdateLabelContent(Prijs, income);
        }

        private void BtnGrandma_Click(object sender, RoutedEventArgs e)
        {

            double Prijs = (double)GrandmaClass.Prijs;
            double income = 0.01;

            GrandmaClass.PrijsVerhogen();
            GrandmaClass.GekockteGrandma();

            int TellerGrandma = GrandmaClass.Teller;

            LbGrandma.Content = TellerGrandma.ToString();

            UpdateButtonEnabledState(BtnGrandma, Prijs);
            UpdateLabelContent(Prijs, income);
        }

        private void BtnFarm_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)FarmClass.Prijs;
            double income = 0.08;

            FarmClass.PrijsVerhogen();
            FarmClass.GekockteFarm();
            
            int TellerFarm = FarmClass.Teller;

            LbFarm.Content = TellerFarm.ToString();

            UpdateButtonEnabledState(BtnFactory, Prijs);
            UpdateLabelContent(Prijs, income);

        }

        private void BtnMine_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)MineClass.Prijs;
            double income = 0.47;

            MineClass.PrijsVerhogen();
            MineClass.GekockteMinea();

            int TellerMine = MineClass.Teller;

            LbMine.Content = TellerMine.ToString();

            UpdateButtonEnabledState(BtnFarm, Prijs);
            UpdateLabelContent(Prijs, income);          
        }

        private void BtnFactory_Click(object sender, RoutedEventArgs e)
        {
            double Prijs = (double)FactoryClass.Prijs;
            double income = 2.60;

            FactoryClass.PrijsVerhogen();
            FactoryClass.GekockteFactory();

            int TellerFactory = FactoryClass.Teller;

            LbFactory.Content = TellerFactory.ToString();

            UpdateButtonEnabledState(BtnMine, Prijs);
            UpdateLabelContent(Prijs, income);
        }
    }
}
