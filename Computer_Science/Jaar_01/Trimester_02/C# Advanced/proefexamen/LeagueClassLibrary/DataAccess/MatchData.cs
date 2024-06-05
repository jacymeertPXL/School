using LeagueClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueClassLibrary.DataAccess
{
    public static class MatchData
    {
        private static DataTable DataTableChampoins { get; set; }

        public static void InitializeDataTableMatches()
        {
            DataTableChampoins = new DataTable("Matches");

            DataColumn idColumn = new DataColumn("MatchId", typeof(int))
            {
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
                AllowDBNull = false,
                Unique = true
            };

            DataTableChampoins.Columns.Add(idColumn);
            DataTableChampoins.Columns.Add("Code", typeof(string));
            DataTableChampoins.Columns.Add("Winner", typeof(string));

            DataTableChampoins.PrimaryKey = new DataColumn[] { DataTableChampoins.Columns["MatchId"] };
        }
        
        public static void AddFinishedMatch(Match match)
        {
            DataTableChampoins.Rows.Add(null, match.code, match.Winner == 1 ? "Red" : "Blue");
        }

        public static DataView GetDataViewMatches()
        {
            return DataTableChampoins.DefaultView;
        }

        public static void ExportToXML()
        {
            //DataSet ds = new DataSet();
            //ds.Tables.Add(DataTableChampoins);
            //ds.WriteXml(@"C:\MyDataset.xml"); 

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml",
                FileName = "Matches.xml"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataTableChampoins.WriteXml(sfd.FileName);
            }
        }

        public static void isUniquecode(string code)
        {
            if (DataTableChampoins.Rows.Contains(code))
            {
                throw new DuplicateNameException("Code already exists");
            }
        }   
    }
}
