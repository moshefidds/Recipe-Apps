using System.Data;
using System.Data.SqlClient;
using System.Drawing;


namespace RecipeSystem
{
    public class RecipeGeneralSystem
    {
        // GetDashboard
        public static DataTable GetDashboard()
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand("DashboardGet");
            return SqlUtility.GetDataTable(cmd);
        }

        // Load User Data from DB
        public static DataTable GetUserList(bool includeblank = false, string username = "")
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("UserGet");
            SqlUtility.SetParamValue(cmd, "@All", 1);
            SqlUtility.SetParamValue(cmd, "@UserName", username);
            SqlUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load Cuisine data from DB
        public static DataTable GetCuisineList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("CuisineGet");
            SqlUtility.SetParamValue(cmd, "@All", 1);
            SqlUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Update or Save Table
        public static void SaveTable(DataTable dt, string sproc, string parentid_columnname, int parentid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r[parentid_columnname] = parentid;
            }

            SqlUtility.SaveDataTable(dt, sproc);
        }

        // Clone A Recipe
        public static void CloneARecipe(int recipeid)
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand("CloneARecipe");
            SqlUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            SqlUtility.ExecuteSQL(cmd);
        }

        // Auto Create A Cookbook
        public static void AutoCreateACookbook(int userid)
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand("AutoCreateCookbook");
            SqlUtility.SetParamValue(cmd, "@UserId", userid);
            SqlUtility.ExecuteSQL(cmd);
        }
    }
}
