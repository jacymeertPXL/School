using LeagueClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueClassLibrary.DataAccess
{
    public static class ChampionData
    {
        private static DataTable DataTableChampions = new DataTable();
        private static Random r = new Random();

        public static void LoadCSV(string padNaarCsv)
        {
            DataTableChampions.Clear();
            using (StreamReader sr = new StreamReader(padNaarCsv))
            {
                string[] headers = sr.ReadLine().Split(';');
                foreach (string header in headers)  {
              
                    DataTableChampions.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    DataTableChampions.Rows.Add(sr.ReadLine().Split(';'));
                }
            }
        }

        public static DataView GetDataViewChampion()
        {
            return DataTableChampions.DefaultView;
        }

        public static DataView GetDataViewChampionsByPosition(string position)
        {
            DataRow[] filteredRows = DataTableChampions.Select($"ChampionPosition1 = '{position}' OR ChampionPosition2 = '{position}' OR ChampionPosition3 = '{position}'");
            DataTable filteredTable = filteredRows.CopyToDataTable();
            return filteredTable.DefaultView;
        }

        public static DataView GetDataViewChampionsBestToWorst()
        {
            DataTable sortedTable = DataTableChampions.Clone();
            var sortedRows = DataTableChampions.AsEnumerable()
                .OrderByDescending(row => int.Parse(row["ReleaseYear"].ToString()))
                .ThenByDescending(row => new string[] { "ChampionPosition1", "ChampionPosition2", "ChampionPosition3" }
                    .Count(col => !string.IsNullOrEmpty(row[col].ToString())))
                .ThenBy(row => row["ChampionName"].ToString());

            foreach (var row in sortedRows)
            {
                sortedTable.ImportRow(row);
            }

            return sortedTable.DefaultView;
        }

        public static Champion GetRandomChampionByPosition(string position)
        {
            var champions = DataTableChampions.AsEnumerable()
                .Where(row => row["ChampionPosition1"].ToString() == position ||
                              row["ChampionPosition2"].ToString() == position ||
                              row["ChampionPosition3"].ToString() == position)
                .ToArray();

            if (champions.Length == 0)
                return null;

            var randomChampionRow = champions[r.Next(champions.Length)];
            var abilities = AbilityData.GetAbilitiesByChampionName(randomChampionRow["Champion Name"].ToString());
            return new Champion(
                randomChampionRow["Champion Name"].ToString(),
                randomChampionRow["Champion Title"].ToString(),
                randomChampionRow["Champion Class"].ToString(),
                int.Parse(randomChampionRow["Release Year"].ToString()),
                abilities,
                new string[] { randomChampionRow["Champion Position1"].ToString(), randomChampionRow["Champion Position2"].ToString(), randomChampionRow["Champion Position3"].ToString() }.ToList(),
                randomChampionRow["Champion Icon"].ToString(),
                randomChampionRow["Champion Banner"].ToString(),
                int.Parse(randomChampionRow["RP Cost"].ToString()),
                int.Parse(randomChampionRow["IP Cost"].ToString())
            );
        }

    }
}
