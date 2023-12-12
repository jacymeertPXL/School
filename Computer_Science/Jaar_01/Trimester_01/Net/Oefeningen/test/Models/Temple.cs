using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coockie_Clicker.Models
{
    internal class Temple
    {
        public int Gekocht { get; set; } 
        public int Teller { get; set; }
        public double Prijs { get; set; }
        public double PrijsBonus { get; set; }
        public bool CursorButtonVisible { get; set; }

        public Temple()
        {
            Gekocht = 0;
            Teller = 2;
            Prijs = 20000000;
            PrijsBonus = 20000000;
            CursorButtonVisible = false;
        }

        public void PrijsVerhogen()
        {
            Prijs = Prijs * Math.Pow(1.15, Teller);
        }

        public void PrijsVerhogenBonus()
        {
            double factor = (double)Math.Pow(10, Teller - 2);
            PrijsBonus = Prijs * factor;
        }

        public void GekockteBonusTemple()
        {
            Teller++;
        }
    }
}
