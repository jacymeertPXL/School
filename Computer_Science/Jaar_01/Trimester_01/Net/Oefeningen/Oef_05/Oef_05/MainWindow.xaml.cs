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

namespace Oef_05
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

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtBetalen.Text = string.Empty;
            TxtKorting.Text = string.Empty;
            TxtNormaal.Text = string.Empty;
            TxtStudent.Text = string.Empty;
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double NORMALE_TARIEF = 9.10;
            double KORTING_TARIEF = 8.10;
            double STUDENT_TARIEF = 6.90;

            int aantalkor = int.Parse(TxtKorting.Text);
            int aantalnor = int.Parse(TxtNormaal.Text);
            int aantalstd = int.Parse(TxtStudent.Text);

            int somkor = (int)(double)(KORTING_TARIEF * aantalkor);
            int somnor = (int)(double)(NORMALE_TARIEF * aantalnor);
            int somstd = (int)(double)(STUDENT_TARIEF * aantalstd);

            int somtotaal = somkor + somnor + somstd;

            TxtBetalen.Text = Convert.ToString(somtotaal);
        }
    }
}
