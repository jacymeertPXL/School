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
using System.Data;

namespace DemoAdoNetDisconnected
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

        DataSet ds = new DataSet();
        DataTable dt = new DataTable("Stud");

        DataColumn dcStudId = new DataColumn("StudId", typeof(int)); 
        DataColumn dcNaam = new DataColumn("Naam", typeof(string)); 
        DataColumn dcOpleiding = new DataColumn("Opleiding", typeof(string)); 
        DataColumn dcGbDatum = new DataColumn("GbDatum", typeof(DateTime));

        dt.Columns.Add(dcStudId);
        dt.Columns.Add(dcNaam);
        dt.Columns.Add(dcOpleiding);
        dt.Columns.Add(dcGbDatum);
    }
}
