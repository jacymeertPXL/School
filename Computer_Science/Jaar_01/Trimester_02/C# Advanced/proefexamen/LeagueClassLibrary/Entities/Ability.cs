using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueClassLibrary.Entities
{
    public class Ability
    {
        public Ability(int id, string championName, string name)
        {
            this.id = id;
            ChampionName = championName;
            Name = name;
        }

        public int id { get; set; }
        public string ChampionName { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
