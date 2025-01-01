using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class DataMaintenance
    {
        // GetDataList
        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand(tablename + "Get");
            SqlUtility.SetParamValue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SqlUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            }
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // SaveDataList
        public static void SaveDataList(DataTable dt, string tablename)
        {
            SqlUtility.SaveDataTable(dt, tablename + "Update");
        }

        //DeleteRow
        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand(tablename + "Delete");
            SqlUtility.SetParamValue(cmd, $"@{tablename}Id", id);
            SqlUtility.ExecuteSQL(cmd);
        }
    }
}
