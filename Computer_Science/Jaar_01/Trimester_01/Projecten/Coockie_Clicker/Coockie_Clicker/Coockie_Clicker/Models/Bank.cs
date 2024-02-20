using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coockie_Clicker.Models
{
    internal class Bank
    {
        public int Teller { get; set; }
        public double Prijs { get; set; }
        public bool CursorButtonVisible { get; set; }

        public Bank()
        {
            Teller = 0;
            Prijs = 1400000;
            CursorButtonVisible = false;
        }

        public void PrijsVerhogen()
        {
            Prijs = Prijs * Math.Pow(1.15, Teller);
        }

        public void GekockteBank()
        {
            Teller++;
        }
    }
}
