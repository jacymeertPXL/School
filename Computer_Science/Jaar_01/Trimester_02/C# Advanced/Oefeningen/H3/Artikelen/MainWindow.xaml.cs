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

namespace Artikelen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Library> artikelen = new List<Library>();
        private int huidigIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            MaakArtikelen();
        }

        private void BtnVolgende_Click(object sender, RoutedEventArgs e)
        {
            if(huidigIndex < artikelen.Count)
            {
                if(huidigIndex == 3)
                {
                    LaadArtikelen(artikelen[huidigIndex]);
                }
                else
                {
                    LaadArtikelen(artikelen[huidigIndex]);
                    huidigIndex++;
                }
               
            }
        }

        private void BtnVorige_Click(object sender, RoutedEventArgs e)
        {
            if (huidigIndex > 0)
            {
                huidigIndex--;
                LaadArtikelen(artikelen[huidigIndex]);
            }
        }

        private void MaakArtikelen()
        {
            Library Artikel01 = new Library("18-08-2003", "", "test1", "Jacy Meert", "Test");
            Library Artikel02 = new Library("18-08-2003", "", "test2", "Jacy Meert", "Test");
            Library Artikel03 = new Library("18-08-2003", "", "test3", "Jacy Meert", "Test");

            artikelen.Add(Artikel01);
            artikelen.Add(Artikel02);
            artikelen.Add(Artikel03);
        }

        private void LaadArtikelen(Library library)
        {
            LbTitel.Content = library.Titel;
            TxtText.Text = library.Inhoud;
            TxtDatum.Content = library.DatumVanPublicatie;
            TxtJournalist.Content = library.Journalist;
            ImgArtikel.Source = new BitmapImage(new Uri(library.ImagePath, UriKind.RelativeOrAbsolute));
        }
    }
}
