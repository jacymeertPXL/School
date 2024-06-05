using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueClassLibrary.Entities
{
    public class Champion
    {
        public Champion(string name, string title, string @class, int releaseYear, List<Ability> abilities, List<string> positions, string iconSource, string bannerSource, int costIP, int costRP)
        {
            Name = name;
            Title = title;
            Class = @class;
            ReleaseYear = releaseYear;
            Abilities = abilities;
            Positions = positions;
            IconSource = iconSource;
            BannerSource = bannerSource;
            CostIP = costIP;
            CostRP = costRP;
        }

        public string Name { get; set; }
        public string Title { get; set; }
        public string Class { get; set; }
        public int ReleaseYear { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<string> Positions { get; set; }
        public string IconSource { get; set; }
        public string BannerSource { get; set; }
        public int CostIP { get; set; }
        public int CostRP { get; set; }

        public override string ToString()
        {
            return Name + " " + Title;
        }

        public string Getcost()
        {
            return CostRP + " " + CostIP;
        }
    }
}
