
using System.Data;
namespace RecipeSystem
{
    public class Recipe
    {
        // Search for Recipe
        public static DataTable SearchRecipes(string recipe)
        {
            string sql = "select r.RecipeId, r.RecipeName from Recipe r where r.RecipeName like '%" + recipe + "%'";

            DataTable dt = SqlUtility.GetDataTable(sql);
            return dt;
        }

        // Load Recipe Data from DB
        public static DataTable Load(int recipeid)
        {
            string sql = "select r.*, c.CuisineType, u.UserName from Recipe r join [User] u on r.UserId = u.UserId join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId = " + recipeid.ToString();
            return SqlUtility.GetDataTable(sql);
        }

        // Load User Data from DB
        public static DataTable GetUserList()
        {
            return SqlUtility.GetDataTable("select UserId, UserName from [User]");
        }

        // Load Cuisine data from DB
        public static DataTable GetCuisineList()
        {
            return SqlUtility.GetDataTable("select CuisineId, CuisineType from Cuisine");
        }

        // Save or Insert Data
        public static void Save(DataTable dtrecipe)
        {
            SqlUtility.DebugPrintDataTable(dtrecipe);
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