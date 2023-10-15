using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        private void BtnItemVerwijderen_Click(object sender, RoutedEventArgs e) // Werkt
        {
            if(LstSimple.SelectedItem != null)
            {
                LstSimple.Items.Remove(LstSimple.SelectedItem);
                LstSimple.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Selecteer een item om te verwijderen.");
            }
        }

        private void BtnListBoxVerwijderen_Click(object sender, RoutedEventArgs e) // Werkt
        {
            LstSimple.Items.Clear();
            LstSimple.Items.Refresh();
        }

        private void BtnVervangen_Click(object sender, RoutedEventArgs e)  // Werkt
        {
            string Vervangen = TxtVervangen.Text;
            int index = LstSimple.SelectedIndex;

            ListBoxItem listBox = new ListBoxItem();
            listBox.Content = Vervangen;

            LstSimple.Items.RemoveAt(index);

            LstSimple.Items.Insert(index, listBox);
            LstSimple.Items.Refresh();
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e) // Werkt
        {
            string Toevoegen = TxtToeveogen.Text;
            ListBoxItem listBox = new ListBoxItem();
            listBox.Content = Toevoegen;
            LstSimple.Items.Add(listBox);
            LstSimple.Items.Refresh();
            TxtToeveogen.Clear();
        }

        private void BtnZoeken_Click(object sender, RoutedEventArgs e) // Werkt
        {

            for (int i = 0; i < LstSimple.Items.Count; i++)
            {
                if (((ListBoxItem)LstSimple.Items[i]).Content.ToString().Equals(TxtZoeken.Text))
                {
                    LbZoeken.Content = "Het item staat in " + i;
                    break;
                }
            }
                
        }

        private void BtnSorteren_Click(object sender, RoutedEventArgs e) // Werkt
        {
            List<string> listBoxItemText = new List<string>();

            foreach (ListBoxItem listBoxItem in  LstSimple.Items)
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
            LstSimple.Items.Refresh();

        }

        private void LstMultiple_SelectionChanged(object sender, SelectionChangedEventArgs e) // Afmaken
        {
            
        }
    }
}
