
using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class Recipe
    {
        // Search for Recipe
        public static DataTable SearchRecipes(string recipe, int all = 0)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipe;
            cmd.Parameters["@All"].Value = all;
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load Recipe Data from DB
        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load User Data from DB
        public static DataTable GetUserList()
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("UserGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load Cuisine data from DB
        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Save or Insert Data
        public static void Save(DataTable dtrecipe)
        {
            //SqlUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update Recipe set",
                $"UserId = '{r["UserId"]}',",
                $"CuisineId = '{r["CuisineId"]}',",
                $"RecipeName = '{r["RecipeName"]}',",
                $"NumOfCalories = {r["NumOfCalories"]},",
                $"DateDrafted = '{r["DateDrafted"]}'",
                $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(UserId, CuisineId, RecipeName, NumOfCalories, DateDrafted) ";
                sql += $"select '{r["UserId"]}', '{r["CuisineId"]}', '{r["RecipeName"]}', {r["NumOfCalories"]}, '{r["DateDrafted"]}'";
            }

            SqlUtility.ExecuteSQL(sql);
        }

        // Delete Data
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SqlUtility.ExecuteSQL(sql);
        }
    }
}