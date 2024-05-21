using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Overerving
{
    public class Persoon
    {
        public string Voornaam {  get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }

        // VIrtual betekent dat het overriden kan worden
        public virtual string Volledigenaam()
        {
            return Voornaam + " " + Naam;
        }

        // VIrtual betekent dat het overriden kan worden
        public virtual string Gegevens()
        {
            return Volledigenaam() + " Geboortedatum: " + Geboortedatum.ToLongDateString();
        }

        // VIrtual betekent dat het overriden kan worden
        public virtual void Info(string msg)
        {
            MessageBox.Show("Uw persoonlijke gegevens: " + msg, "Info Klasse Persoon", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
