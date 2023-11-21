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
        public bool CursorButtonVisible { get; set; }

        public Cursor()
        {
            Teller = 0;
            Prijs = 15;
            CursorButtonVisible = false;
        }

        public void PrijsVerhogen()
        {
            Prijs = Prijs * Math.Pow(1.15, Teller);
        }

        public void GekockteCursor()
        {
            Teller++;
        }
    }
}
