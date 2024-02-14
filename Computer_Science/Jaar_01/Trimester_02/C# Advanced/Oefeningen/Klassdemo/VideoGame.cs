using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassdemo
{
    public class VideoGame
    {
        // nooiit plublic variale maken !!!
        //private string naam;
        //private double prijs;
        //private double downloadGrootte;

        // Impliciet aanweizig, indien geen contructor
        // Let op! Als we een nieuwe contructor aanmaken, dan overschrijven we de default controuctor
        public VideoGame() {}

        public VideoGame(string naam, string bedrijf, string genre, double prijs, int downloadGrootte)
        {
            Naam = naam;
            Bedrijf = bedrijf;
            Genre = genre;    
            Prijs = prijs;
            DownloadGrootte = downloadGrootte;
        }

        // propfull om uigebreide versie van een property te genereren
        // Meer gebruiken als ge complexere code gaan schrijven meer flexibel
        private string bedrijf;

        public string Bedrijf
        {
            get { return bedrijf; }
            set { bedrijf = value; }
        }

        // Leerkracht ziet dit liever
        public string Genre { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public int DownloadGrootte { get; set; }

        public string Info()
        {
            return $"{Naam}, {bedrijf} - {Prijs}";
        }
    }
}
