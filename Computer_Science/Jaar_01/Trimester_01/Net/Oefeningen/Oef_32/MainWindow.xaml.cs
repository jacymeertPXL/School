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

namespace Oef_32
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

        private void BtnItemVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if(LstSimple.Items.Count > 0)
            {
                LstSimple.Items.RemoveAt(LstSimple.Items.IndexOf(LstSimple.SelectedIndex));
            }
        }

        private void BtnListBoxVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            LstSimple.Items.Clear();
        }

        private void BtnVervangen_Click(object sender, RoutedEventArgs e)
        {
            string Vervangen = TxtVervangen.Text;
            int index = LstSimple.SelectedIndex;
            LstSimple.Items.RemoveAt(index);
            LstSimple.Items.Insert(index, Vervangen);
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string Toevoegen = TxtToeveogen.Text;
            LstSimple.Items.Add(Toevoegen);
        }

        private void BtnZoeken_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < LstSimple.Items.Count; i++)
            {
                if (LstSimple.Items[i].ToString() == TxtZoeken.Text)
                {
                    LbZoeken.Content = "Het item staat in " + i;
                    break;
                }
            }
        }

        private void BtnSorteren_Click(object sender, RoutedEventArgs e)
        {
            List<string> listBoxItemText = new List<string>();

            foreach (ListBoxItem listBoxItem in LstSimple.Items)
            {
                listBoxItemText.Add(listBoxItem.Content.ToString());
            }

            // Sorteren van de list
            listBoxItemText.Sort();

            LstSimple.Items.Clear();

            // gesorteede list terug in de listbox steken
            foreach (string itemText in listBoxItemText)
            {
                LstSimple.Items.Add(new ListBoxItem { Content = itemText });
            }   

        }

        private void LstMultiple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int AantalSelected = LstMultiple.SelectedItems.Count;
            TxtGeselecteerd.Text = AantalSelected.ToString();
        }
    }
}
