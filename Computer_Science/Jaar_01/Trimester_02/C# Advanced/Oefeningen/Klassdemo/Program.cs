using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aanmaken van object (= insantie maken) van Videogame
            // Eerste instantie
            VideoGame game = new VideoGame();
            game.Naam = "League Of Legends";
            game.Prijs = 0;

            //genre setter
            game.Genre = "Moba";

            //eigenschap setter
            game.Bedrijf = "Riot Games";


            Console.WriteLine(game.Info());
            Console.WriteLine(game.Bedrijf);

            // Tweede instantie
            VideoGame WorldOfWarcraft = new VideoGame();
            WorldOfWarcraft.Naam = "WorldOfWarcraft";
            WorldOfWarcraft.Genre = "MMO";
            WorldOfWarcraft.Prijs = 59.99;
            WorldOfWarcraft.Bedrijf = "Blizzard";
            Console.WriteLine();

            // Derde Instantie Optimaal
            VideoGame Cyberpunk = new VideoGame("Cyberpunk" , "Cd Projekt Red", "Cyberpunk, Rpg, Action", 69.99, 100);
            Console.WriteLine(Cyberpunk.Info());
            Console.WriteLine(Cyberpunk.Bedrijf);

            Console.ReadLine();


        }
    }
}
