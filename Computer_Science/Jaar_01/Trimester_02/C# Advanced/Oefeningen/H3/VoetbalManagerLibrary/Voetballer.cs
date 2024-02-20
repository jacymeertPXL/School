using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VoetbalManagerLibrary
{
    public class Voetballer
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        private string positieOpVeld;

        public string PositieOpVeld
        {
            get { return positieOpVeld; }
            set
            {

                switch (positieOpVeld)
                {
                    case "doelman":
                        positieOpVeld = value;
                        break;
                    case "aanvaller":
                        positieOpVeld = value;
                        break;
                    case "middenvelder":
                        positieOpVeld = value;
                        break;
                    case "verdidiger":
                        positieOpVeld = value;
                        break;
                    default:
                        positieOpVeld = "middenvelder";
                        break;
                }

            }

        }

        private int rugnummer;

        public int Rugnummer
        {
            get { return rugnummer; }
            set { if (value > 0 && value < 100)
                {
                    rugnummer = value;
                }
                else {
                    rugnummer = 0;
                }
            ;}
        }

        public int AantalDoelpunten { get; set; }

        public Voetballer(string voornaam, string achternaam, string positieOpVeld, int rugnummer, int aantalDoelpunten)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            PositieOpVeld = positieOpVeld;
            PositieOpVeld = positieOpVeld;
            Rugnummer = rugnummer;
            Rugnummer = rugnummer;
            AantalDoelpunten = aantalDoelpunten;
        }

        public Voetballer(string positieOpVeld, int aantalDoelpunten)
        {
            if (positieOpVeld == string.Empty)
            {
                PositieOpVeld = positieOpVeld;
            }
            else
            {
                PositieOpVeld = "middenvelder";
            }

            if (aantalDoelpunten == null)
            {
                AantalDoelpunten = 0;
            }
            else
            {
                AantalDoelpunten = aantalDoelpunten;
            }
        }

        public override string ToString()
        {
            return Achternaam + " " + Voornaam;
        }

        public void informatie()
        {
            StringBuilder stringBuilder = new StringBuilder();

        }
    }
 }
