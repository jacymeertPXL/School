using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueClassLibrary.Entities
{
    public abstract class Match : IWinnable
    {
        public int Winner { get; set; }
        public string code { get; set; }

        public List<Champion> Team1Champions { get; set; }
        public List<Champion> Team2Champions { get; set; }

        public void DecideWinner()
        {
            double avgRealseYearTeam1 = Team1Champions.Average(x => x.ReleaseYear);
            double avgRealseYearTeam2 = Team2Champions.Average(x => x.ReleaseYear);

            if (avgRealseYearTeam1 < avgRealseYearTeam2)
            {
                Winner = 1;
            }
            else if (avgRealseYearTeam1 > avgRealseYearTeam2)
            {
                Winner = 2;
            }  
            else
            {
                double assasinsTeam1 = Team1Champions.Count(x => x.Class == "Assasin");
                double assasinsTeam2 = Team2Champions.Count(x => x.Class == "Assasin");

                if (assasinsTeam1 > assasinsTeam2)
                {
                    Winner = 1;
                }
                else if (assasinsTeam1 < assasinsTeam2)
                {
                    Winner = 2;
                }  
                else
                {
                    Winner = 1;
                }
            }
        }

        public abstract void GenerateTeams();

        public void match(string code)
        {
            this.code = code;

        }
    }
}
