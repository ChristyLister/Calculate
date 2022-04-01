using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Calculate
{
    public class Calculator
    {
        // Производим вычисления

        public static double Сalculation(string valueInput)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), valueInput);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}
