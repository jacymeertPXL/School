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
using System.Windows.Shapes;

namespace Gegevens_Tussen_Vensters
{
    /// <summary>
    /// Interaction logic for KeuzeVenster.xaml
    /// </summary>
    public partial class KeuzeVenster : Window
    {
        public KeuzeVenster()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            //string wijzigletter = MainWindow.txtwijzig.Text;

            if(BtnUpper.IsChecked == true)
            {
                Data.Tekxt = Data.Tekxt.ToUpper();
                //wijzigletter = wijzigletter.ToUpper();
            }
            else
            {
                Data.Tekxt = Data.Tekxt.ToLower();
                //wijzigletter = wijzigletter.ToLower();
            }

            //MainWindow.txtwijzig.Text = wijzigletter;

            //DialogResult = true;
            Hide();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            //DialogResult = false;
            Close();
        }
    }
}
