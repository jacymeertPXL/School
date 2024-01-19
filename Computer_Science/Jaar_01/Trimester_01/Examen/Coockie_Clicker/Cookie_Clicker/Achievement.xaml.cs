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
using System.Windows.Threading;

namespace Coockie_Clicker
{
    /// <summary>
    /// Interaction logic for Achievements.xaml
    /// </summary>
    public partial class Achievement : Window
    {
        // Timer
        private DispatcherTimer timer;

        public Achievement()
        {
            InitializeComponent();

            // Timer Tick Voor de Rest van het programma
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Interval = TimeSpan.FromMilliseconds(10);

            timer.Tick += Timer_Tick;
            timer.Start();
            ControleerAchievements();
        }

        private void Timer_Tick(object sender, EventArgs e) // Werkt
        {
            // gaat elke 10 miliseconden alles visual updaten van de client.
            ControleerAchievements();
        }
        private void ControleerAchievements() 
        {
            
        }
    }
}
