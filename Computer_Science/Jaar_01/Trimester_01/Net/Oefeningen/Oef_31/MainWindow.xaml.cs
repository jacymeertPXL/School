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

namespace Oef_31
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing += new((sender, client) => {
                if (MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Application.Current.Shutdown();
                }
                else
                {
                    client.Cancel = true;
                }
            });
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
            
        }


        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtOndernemingsNummer.Text = string.Empty;
            TxtResultaat.Text = string.Empty;
        }

        private void BtnControle_Click(object sender, RoutedEventArgs e)
        {
            string OndernemingsNummer = TxtOndernemingsNummer.Text;
            string[] OndernemingsLijst = OndernemingsNummer.Split(' ');
            if (OndernemingsLijst.Length == 0)
            {
                MessageBox.Show("Geef een Ondernemingsnummer in");
            }else
            {
                if (OndernemingsLijst[0] == "BE" & OndernemingsLijst[1].Length == 11)
                {
                    TxtResultaat.Text = "Goed gevormd!";
                    Array.Clear(OndernemingsLijst, 0, OndernemingsLijst.Length);
                }
                else
                {
                    MessageBox.Show("De vorm waarin het ondernemingsnummer moet gegeven" +
                        "worden is BE xxx.xxx.xxx");
                }
            }
        }
    }
}
