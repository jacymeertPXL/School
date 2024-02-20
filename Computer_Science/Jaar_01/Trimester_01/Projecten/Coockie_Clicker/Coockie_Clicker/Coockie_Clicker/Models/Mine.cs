using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coockie_Clicker.Classes
{
    internal class Mine
    {
        public int Teller { get; set; }
        public double Prijs { get; set; }
        public bool CursorButtonVisible { get; set; }

        public Mine()
        {
            Teller = 0;
            Prijs = 12000;
            CursorButtonVisible = false;
        }

        public void PrijsVerhogen()
        {
            Prijs = Prijs * Math.Pow(1.15, Teller);
        }

        public void GekockteMinea()
        {
            Teller++;
        }
    }
}
