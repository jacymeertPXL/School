using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DisconnectedNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();

            DataTable dataTable = new DataTable("Stud");

            DataColumn dcStudId = new DataColumn("StudId", typeof(int));
            DataColumn dcNaam = new DataColumn("Naam", typeof(string));
            DataColumn dcOpleiding = new DataColumn("Opleiding", typeof(string));
            DataColumn dcGbDatum = new DataColumn("GbDatum", typeof(DateTime));

            dataTable.Columns.Add(dcStudId);
            dataTable.Columns.Add(dcNaam);
            dataTable.Columns.Add(dcOpleiding);
            dataTable.Columns.Add(dcGbDatum);

            DataColumn dataColumn = new DataColumn();
            dataColumn.ColumnName = "Telefoon";
            dataColumn.DataType = typeof(string); 
            dataColumn.Unique = true;
            dataColumn.ReadOnly = false;

            dataTable.Columns.Add(dataColumn);

            // Primary key in colum zetten
            DataColumn[] pk = { dcStudId };
            dataTable.PrimaryKey = pk;

            // Remove
            //LInq gebruiken om in een row er uit te deleten
            dataTable.Columns.Remove(dcStudId);
        }
    }
}
