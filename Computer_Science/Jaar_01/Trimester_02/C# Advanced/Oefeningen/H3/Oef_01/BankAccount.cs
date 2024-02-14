using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_01
{
    public class BankAccount
    {
        // Eigenschappen
        public Persoon Owner { get; set; }
        private string _accountNumber;
        public string RekeningNummer
        {
            get { return _accountNumber; }
            set
            {
                if (value.StartsWith("BE") && value.Substring(2).All(char.IsDigit))
                {
                    _accountNumber = value;
                }
                else
                {
                    throw new ArgumentException("Ongeldig rekeningnummer geef een andere in");
                }
            }
        }

        private List<Transactie> _transactions;
                
        // Constructor
        public BankAccount(Persoon owner, string rekeningNummer)
        {
            Owner = owner;
            RekeningNummer = rekeningNummer;
            _transactions = new List<Transactie>();
        }

        // Methodes
        public void VoegTransactieToe(Transactie transactie)
        {
            _transactions.Add(transactie);
        }

        public decimal Saldo()
        {
            decimal saldo = 0;
            foreach (var transacties in _transactions)
            {
                saldo += transacties.Bedrag;
            }
            return saldo;
        }
    }
}
