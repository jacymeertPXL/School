using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TekstBestandenDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("tekstbestand.txt");

            // lezen van een bestand regel per regel
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

            reader.Close();

            // Hele bestand lezen 
            string tekst = File.ReadAllText("tekstbestand.txt");
            string tekst2 = reader.ReadToEnd();

            // Csv bestand lezen
            using (StreamReader reader2 = new StreamReader("csvbestand.csv"))
            {
                while (!reader2.EndOfStream)
                {
                    // opsplitsen van de regel waarbij de ; het scheidingsteken is
                    string[] lijn = reader2.ReadLine().Split(';');
                    Console.WriteLine(lijn[0] + " " + lijn[1]);
                }
            }

            // txt bestand lezen 
            using (StreamReader reader3 = new StreamReader("tekstbestand.txt"))
            {
                while (!reader3.EndOfStream)
                {
                    Console.WriteLine(reader3.ReadLine());
                }
            }
        }
    }
}
