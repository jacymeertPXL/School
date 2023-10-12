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

namespace Oef_30
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

        private string BinNaarDec(string BinStr)
        {
            return Convert.ToInt32(BinStr, 2).ToString(); //inbuild weg om naar dec van bin te gaan
        }

        private string DecNaarBinTot255(string decimalStr)
        {
            int decimalValue = (int)Convert.ToInt64(decimalStr);
            string binaryResult = "";

            for (int i = 7; i >= 0; i--)
            {
                int power = (int)Math.Pow(2, i); 
                if (decimalValue >= power)
                {
                    binaryResult += '1';
                    decimalValue -= power;
                }
                else
                {
                    binaryResult += '0';
                }
            }

            return binaryResult;
        }


        private void BtnOmzetten_Click(object sender, RoutedEventArgs e)
        {
            string input = TxtDecimaalGetal.Text.Trim();
            string resultaat = DecNaarBinTot255(input);
            TxtBinairGetal.Text = resultaat;


        }

        private void BtnAllesOmzetten_Click(object sender, RoutedEventArgs e)
        {
            string binValue = TxtBinairGetal.Text;
            string resultaat = BinNaarDec(binValue);
            TxtDecimaalGetal.Text = resultaat;
        }
    }
}
