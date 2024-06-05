using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueClassLibrary.Entities
{
    public interface IWinnable
    {
         int Winner { get; set; }
         void DecideWinner();
    }
}
