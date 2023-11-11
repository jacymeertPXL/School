using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coockie_Clicker.Models
{
    internal class Cursor
    {
        public int Teller { get; set; }
        public double Prijs { get; set; }
        public double PrijsUpgrade { get; set; }

        public Cursor()
        {
            Teller = 0;
            Prijs = 15;
            PrijsUpgrade = 1; // Staat niet in opdracht ?? 
        }

        public void PrijsVerhogen()
        {
            Prijs += PrijsUpgrade;
            PrijsUpgrade++;
        }

        public void GekockteCursor()
        {
            Teller++;
        }
    }
}
