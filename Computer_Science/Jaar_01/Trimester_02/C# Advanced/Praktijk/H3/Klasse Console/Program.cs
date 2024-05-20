using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gebruiker gebruiker = new Gebruiker("Jacy", "Meert");

            Console.WriteLine(gebruiker.Voornaam, "Voornaam");
            Console.WriteLine(gebruiker.Naam, "Naam");

            Console.WriteLine(gebruiker.ToonNaam(), "Naam van gebruiker");
        }
    }
}
