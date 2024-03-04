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

namespace MeerdereVenstersDemo
{
    /// <summary>
    /// Interaction logic for ExtraVenster.xaml
    /// </summary>
    public partial class ExtraVenster : Window
    {
        public ExtraVenster(string tekstVanMaimn)
        {
            InitializeComponent();

            string ExtraWindoz  = MainWindow.IedereenKanHierAan;

            Lbtekst.Content = ExtraWindoz;
            Lbtekst.Content += tekstVanMaimn;
            Lbtekst.Content += Data.IedereenKanHierAanClass;
            
        }

    }
}
