using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Meert_Jacy_1Pro_E_C__1ezit_Eg016
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[,] Uitslagenn = new string[,]
        {
            { "Padel Hasselt", "Padel Genk", "3-2", "N", "P200" },
            { "Padel Leuven", "Padel Diepenbeek", "Padel", "J", "P300" }
            
        };

        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            
            //Methods
            VulArray();
            VulListObject();
            VulDictionary();
            VulCombo();
            VulListbox();
            VulDatumEnTijd();
            TextBox();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            VulDatumEnTijd();
        }
        public void VulDatumEnTijd()
        {
            LbTijd.Content = DateTime.Now;
        }

        public void VulArray()
        {
            
        }
        public void VulListObject()
        {

        }
        public void VulDictionary()
        {

        }
        public void VulCombo()
        {
            //for (int i = 0; i < 1; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        CbBezoekers.Items.Add();
            //    }

                
            //}
            
        }
        public void VulListbox()
        {

        }
        
        public void TextBox()
        {

        }
    }
}