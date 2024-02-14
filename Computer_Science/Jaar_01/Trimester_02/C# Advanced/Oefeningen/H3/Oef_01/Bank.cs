using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_01
{
    internal class Bank
    {
        private List<BankAccount> klanten;
        public string naam {  get; set; }

        public void VoegKlantToe(BankAccount bankAccount)
        {
            klanten.Add(bankAccount);
        }

        public int Saldo()
        {
            int saldo = 0;   
            return saldo;
        }

        public List<string> GetAlleKlantNamen()
        {
            return null;
        }
    }
}
