using LeagueClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueClassLibrary.Entities
{
    public class TwistedTreeline : Match
    {
        public TwistedTreeline(string code)
        {
            this.code = code;
        }
        public override void GenerateTeams()
        {
            Team1Champions = new List<Champion>
            {
                ChampionData.GetRandomChampionByPosition("Top"),
                ChampionData.GetRandomChampionByPosition("Jungle"),
                ChampionData.GetRandomChampionByPosition("Mid"),
                ChampionData.GetRandomChampionByPosition("ADC"),
                ChampionData.GetRandomChampionByPosition("Support")
            };

            Team2Champions = new List<Champion>
            {
                ChampionData.GetRandomChampionByPosition("Top"),
                ChampionData.GetRandomChampionByPosition("Jungle"),
                ChampionData.GetRandomChampionByPosition("Mid"),
                ChampionData.GetRandomChampionByPosition("ADC"),
                ChampionData.GetRandomChampionByPosition("Support")
            };
        }
    }
}
