using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalManagerLibrary
{
    public class Team
    {
        public string Teamnaam { get; set; }

        private Voetballer Kapitein;

        public List<Voetballer> speler { get; } 

        public Team(string teamnaam)
        {
            Teamnaam = teamnaam;
        }

        public Voetballer kapitein
        {
            get { return Kapitein; }
            set { Kapitein = value; }
        }

    }
}
