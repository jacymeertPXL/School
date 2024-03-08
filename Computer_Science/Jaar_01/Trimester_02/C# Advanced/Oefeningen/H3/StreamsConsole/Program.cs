using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Oefening 01 
            DateTime dateTime = DateTime.Now;
            int hours = dateTime.Hour;
            int min = dateTime.Minute;

            Console.WriteLine("Geef je naam: ");
            string naam = Console.ReadLine();
            string tekst = "";

            // Checken welke tijd van de dag het is
            // String aanmaken voor Streamreader.write
            if (hours >= 1 && hours <= 12)
            {
                //Good Morning
                tekst =  "Good Morning " + naam;
            }
            else if (hours >= 12 && hours <= 16)
            {
                //Good Afternoon
                tekst = "Good Afternoon " + naam;
            }
            else if (hours >= 16 && hours <= 21)
            {
                //Good Evening
                tekst = "Good Evening " + naam;
            }
            else if (hours >= 21 && hours <= 24)
            {
                //Good Night
                tekst = "Good Night " + naam;
            }

            using(StreamWriter sw = new StreamWriter("groen.txt"))
            {
                sw.WriteLine(tekst);
                sw.Close();
            }
            // Oefening 01 

        }

        // Oefening 02
        // Simpele Wipe functie
        public void Wipe(String Bestandnaam)
        {
            Wipe(Bestandnaam);
        } // Oefening 02

        // Oefening 03
        // Aanmaken van mensen
        public void AanmakenMensen()
        {
            Console.WriteLine("Geef je Voornaam: ");
            string Voornaam = Console.ReadLine();
            if (Voornaam.Contains("-"))
            {
                Console.WriteLine("Ongeldige naam:");
            }

            Console.WriteLine("Geef je Achternaam: ");
            string Achternaam = Console.ReadLine();
            if (Achternaam.Contains("-"))
            {
                Console.WriteLine("Ongeldige naam:");
            }

            int leeftijd = 0;
            Console.WriteLine("Geef je leeftijd: ");
            try
            {
                leeftijd = (int)Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("geef een nummer in");
            }

            using (StreamWriter sw2 = new StreamWriter("mensen.txt"))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"{Voornaam}-{Achternaam}-{leeftijd}");
                sw2.WriteLine(stringBuilder);
                sw2.Close();
            }
        }// Oefening 03


        // Oefening 04
        // Zoek Achternaam functie
        public void ZoekAchterNaam(String achternaam)
        {
            using (StreamReader sr = new StreamReader("mensen.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string tekst = sr.ReadLine();
                    if (tekst.Contains(achternaam))
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append($"{tekst}");
                    }
                }
                sr.Close(); 
            }
        } // Oefening 04

        // Oefening 05
        // Random achternaam uit functie
        public void Randomnaam()
        {
            using (StreamReader sr = new StreamReader("mensen.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string tekst = sr.ReadLine();
                    Random rnd = new Random();
                    int i = 0;
                    int num = rnd.Next();
                    int num2 = rnd.Next();
                    if (num == num2 && 0 > i)
                    {
                        i++;
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append($"{tekst}");
                    }
                }
                sr.Close();
            }
        } // Oefening 05

        // Oefening 08
        // VerwijderPersoon functie
        public void VerwijderPersoon(String achternaam, String voornaam)
        {
            string tempBestand = Path.GetTempFileName();

            using (StreamReader sr = new StreamReader("mensen.txt"))
            {
                using (StreamWriter sw = new StreamWriter(tempBestand))
                {
                    string regel;
                    
                    while ((regel = sr.ReadLine()) != null)
                    {
                        // controleert elke regel als die de voornaam en achternaam hebben
                        // zo ja gaat die die niet toevoegen in het tempbestand dat later het niwue bestand wordt 
                        if (!regel.Contains(voornaam) && !regel.Contains(achternaam))
                        {
                            // slaat de regels op in een nieuwe bestand
                            sw.WriteLine(regel);
                        }
                    }   
                }
            }
            File.Delete("mensen.txt");
            File.Move(tempBestand, "mensen.txt");

        } // Oefening 08
    }
}
