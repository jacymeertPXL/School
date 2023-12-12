using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coockie_Clicker.Classes
{
    internal class Factory
    {
        public int Gekocht { get; set; }
        public int Teller { get; set; }
        public double Prijs { get; set; }
        public double PrijsBonus { get; set; }
        public bool CursorButtonVisible { get; set; }
        public Factory() {
            Gekocht = 0;
            Teller = 2;
            Prijs = 130000;
            PrijsBonus = 130000;
            CursorButtonVisible = false;
        }

        public void PrijsVerhogenBonus()
        {
            PrijsBonus = Prijs * Math.Pow(10, 2 + 3 * Teller);
        }

        public void PrijsVerhogen()
        {
            double factor = (double)Math.Pow(10, Teller - 2);
            PrijsBonus = Prijs * factor;
        }

        public void GekockteBonusFactory()
        {
            Teller++;
        }

    }
}