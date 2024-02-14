using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_01
{
    public class Auto
    {
        private int aantalwielen;
        private int aantalDeuren;
         private string merk;
        private string rijbewijs;
        private int maxSnelheid;

        public string BeschirjfVoertuig()
        {
            return $"{aantalwielen}, {aantalDeuren}, {merk}, {rijbewijs}; {maxSnelheid}";
        }

        public string Rij()
        {
            return "Vroom";
        }
    }
}
