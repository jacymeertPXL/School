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
using BewerkenLib;

namespace BewerkenLibWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bewerking bw = new Bewerking();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TxtResultaat.Text = Convert.ToString(bw.Min(float.Parse(TxtGetal1.Text), float.Parse(TxtGetal2.Text)));
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSom_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TxtResultaat.Text = Convert.ToString(bw.Som(float.Parse(TxtGetal1.Text), y: float.Parse(TxtGetal2.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMaal_Click(object sender, RoutedEventArgs e)
        { 
            try
            {
                TxtResultaat.Text = Convert.ToString(bw.Maal(float.Parse(TxtGetal1.Text), y: float.Parse(TxtGetal2.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
