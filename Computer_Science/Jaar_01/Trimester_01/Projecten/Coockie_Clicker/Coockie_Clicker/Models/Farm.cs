using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coockie_Clicker.Classes
{
    internal class Farm
    {
        public int Teller { get; set; }
        public double Prijs { get; set; }
        public double PrijsUpgrade { get; set; }

        public Farm()
        {
            Teller = 0;
            Prijs = 1100;
            PrijsUpgrade = 1; // Staat niet in opdracht ?? 
        }

        public void PrijsVerhogen()
        {
            Prijs += PrijsUpgrade;
            PrijsUpgrade++;
        }

        public void GekockteFarm()
        {
            Teller++;
        }
    }
}
