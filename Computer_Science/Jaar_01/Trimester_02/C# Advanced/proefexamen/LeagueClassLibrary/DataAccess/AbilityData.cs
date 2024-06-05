using LeagueClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueClassLibrary.DataAccess
{
    public static class AbilityData
    {
        public static List<Ability> Abilities { get; set; }

        public static void LoadCSV(string padNaarCsv)
        {
            if (File.Exists(padNaarCsv))
            {
                Abilities.Clear();
                using (StreamReader sr = new StreamReader(padNaarCsv))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        Abilities.Add(new Ability(int.Parse(fields[0]), fields[1], fields[2]));
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }

        public static List<Ability> GetAbilitiesByChampionName(string championName)
        {
            return Abilities.Where(x => x.ChampionName == championName).ToList();
        }
    }
}
