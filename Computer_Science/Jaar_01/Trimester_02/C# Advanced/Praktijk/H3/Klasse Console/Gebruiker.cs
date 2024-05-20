using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Console
{
    public class Gebruiker
    {
        private string voornaam;
        private string familienaam;

        public Gebruiker()
        {
            this.voornaam = string.Empty;
            this.familienaam = string.Empty;
        }


        public Gebruiker(string voornaam, string familienaam)
        {
            this.voornaam = voornaam;
            this.familienaam = familienaam;
        }

        // propfull
        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        // prop
        // Dit kan ook men gaan we ook meestal gebruiken 
        // Het andere doe ja als je meer controle er over hebt
        //public int Voornaam { get; set; }

        public string Naam
        {
            get { return familienaam; }
            set { familienaam = value; }
        }

        public string Gegevens
        {
            get { return voornaam + " " + familienaam;}
        }

        public string ToonNaam()
        {
            return voornaam + " - " + familienaam;
        }
    }
}
