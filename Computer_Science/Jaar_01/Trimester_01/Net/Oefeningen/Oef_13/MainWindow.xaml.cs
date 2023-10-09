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

namespace Oef_13
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

        // Deze code hoort hier niet te staan
        private void TxtBelasting_TextChanged(object sender, TextChangedEventArgs e)
        {
            int SliderValue = (int)SldSalaris.Value;

            if (SliderValue >= 50000)
            {
                int belastingen = (SliderValue / 100) * 90;
                TxtBelasting.Text = belastingen.ToString();
            }
            else if(SliderValue>=10000 & SliderValue < 50000)
            {
                int belastingen = (SliderValue / 100) * 90;
                TxtBelasting.Text = belastingen.ToString();
            }
            else
            {
                TxtBelasting.Text = SliderValue.ToString();
            }
        }

        private void SldSalaris_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int SliderValue = (int)SldSalaris.Value;

            if (SliderValue >= 50000)
            {
                int belastingen = (SliderValue / 100) * 90;
                TxtBelasting.Text = belastingen.ToString();
            }
            else if (SliderValue >= 10000 & SliderValue < 50000)
            {
                int belastingen = (SliderValue / 100) * 90;
                TxtBelasting.Text = belastingen.ToString();
            }
            else
            {
                TxtBelasting.Text = SliderValue.ToString();
            }
        }
    }
}
