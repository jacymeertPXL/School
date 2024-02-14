using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_01
{
    public class Brommer
    {
        private int aantalwielen;
        private string merk;
        private string rijbewijs;
        private int maxSnelheid;

        public Brommer(int aantalwielen, string merk, string rijbewijs, int maxSnelheid)
        {
            this.aantalwielen = aantalwielen;
            this.merk = merk;
            this.rijbewijs = rijbewijs;
            this.maxSnelheid = maxSnelheid;
        }

        public string BeschirjfVoertuig()
        {
            return $"{aantalwielen}, {merk}, {rijbewijs}; {maxSnelheid}";
        }

        public string Rij()
        {
            return "Vroom";
        }
    }
}
