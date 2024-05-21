using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Overerving
{
    public class Werknemer: Persoon
    {
        public DateTime DatumInDienst {  get; set; }
        private string functie = "Lector";

        public string Functie
        {
            get { return functie; }
            set { functie = value; }
        }

        public override string Gegevens()
        {
            return base.Gegevens() + " - " + functie;
        }

        public override void Info(string msg)
        {
            MessageBox.Show("Gegevens van de werknemers: " + msg, "Info Klasse Werknemer", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
