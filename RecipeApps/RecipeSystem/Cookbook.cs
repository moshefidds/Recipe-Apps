using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Cookbook
    {
        // Load Cookbook list
        public static DataTable GetCookbookList()
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand("CookbookGet_List_Overview");
            return SqlUtility.GetDataTable(cmd);
        }

        // Load Cookbook
        public static DataTable Load(int cookbookid, string cookbookname = "")
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("CookbookGet");
            SqlUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            SqlUtility.SetParamValue(cmd, "@CookBookName", cookbookname);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load RecipeList from DB
        public static DataTable GetRecipeList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeGet");
            SqlUtility.SetParamValue(cmd, "@All", 1);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load Cookbook's Recipe List
        public static DataTable GetCookbookRecipeList(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("CookbookRecipeGet");
            SqlUtility.SetParamValue(cmd, "@CookBookId", cookbookid);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Update or Insert Cookbook
        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("No Cookbooks in table to call 'CookbookUpdate'");
            }
            DataRow r = dtcookbook.Rows[0];

            SqlUtility.SaveDataRow(r, "CookbookUpdate");
        }

        // Delete Cookbook
        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookBookId"];
            SqlCommand cmd = SqlUtility.GetSqlCommand("CookbookDelete");
            SqlUtility.SetParamValue(cmd, "@CookBookId", id);
            SqlUtility.ExecuteSQL(cmd);
        }

        // Delete Cookbook's Recipe
        public static void DeleteCookbookRecipe(int cookbookrecipetid)
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand("CookbookRecipeDelete");
            cmd.Parameters["@CookbookRecipeId"].Value = cookbookrecipetid;
            SqlUtility.ExecuteSQL(cmd);
        }
    }
}
