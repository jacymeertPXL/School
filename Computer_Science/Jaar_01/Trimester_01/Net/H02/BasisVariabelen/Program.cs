using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasisVariabelen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geef Getal: "); // Vragen aan de user als die een getal ingeeft
            double getal1 = Convert.ToDouble(Console.ReadLine()); // Convert van een string wat de user ingeeft naar een double

            Console.Write("Geef Getal: ");
            double getal2 = Convert.ToDouble(Console.ReadLine());

            double som = getal1 * getal2; // Optellen
            double aftrekking = getal1 - getal2; // Aftrekken
            double product = getal2 * getal1; // product
            double deling = getal1 / getal2;  // deling

            Console.WriteLine("De som, aftrekking, prodcut en deling is: " + som + aftrekking + product + deling);

            Console.ReadKey(); // sluit met een keypress het programma af
        }
    }
}
