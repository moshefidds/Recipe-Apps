
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
            SqlUtility.SetParamValue(cmd, "@RecipeName", recipe);
            SqlUtility.SetParamValue(cmd, "@All", all);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Get Recipe List_Overview
        public static DataTable GetRecipeList_Overview()
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeGet_List_Overview");
            return SqlUtility.GetDataTable(cmd);
        }

        // Get Recipe List
        public static DataTable GetRecipeList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeGet");
            SqlUtility.SetParamValue(cmd, "@All", 1);
            SqlUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load Recipe Data from DB
        public static DataTable LoadRecipe(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeGet");
            SqlUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load Ingredient data from DB
        public static DataTable GetIngredientList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("IngredientGet");
            SqlUtility.SetParamValue(cmd, "@All", 1);
            SqlUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load Measurement data from DB
        public static DataTable GetMeasurementList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("MeasurementGet");
            SqlUtility.SetParamValue(cmd, "@All", 1);
            SqlUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load Recipe's Ingredients & Measurements - RecipeIngredientMeasurementGet
        public static DataTable LoadRecipeIngredientMeasurement(int recipeid = 0)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeIngredientMeasurementGet");
            SqlUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Load Recipe's Steps (Directions)
        public static DataTable LoadRecipeSteps(int recipeid = 0)
        {
            DataTable dt = new();
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeStepsGet");
            SqlUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SqlUtility.GetDataTable(cmd);
            return dt;
        }

        // Save or Insert Recipe
        public static void Save(DataTable dtrecipe)
        {
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("No Recipes in table to call 'RecipeUpdate'");
            }
            DataRow r = dtrecipe.Rows[0];

            SqlUtility.SaveDataRow(r, "RecipeUpdate");
        }

        // Delete Recipe
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeDelete");
            SqlUtility.SetParamValue(cmd, "@RecipeId", id);
            SqlUtility.ExecuteSQL(cmd);
        }

        // Delete Recipe's Ingredient
        public static void DeleteRecipeIngredient(int recipeingredientid)
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeIngredientDelete");
            cmd.Parameters["@RecipeIngredientId"].Value = recipeingredientid;
            SqlUtility.ExecuteSQL(cmd);
        }

        // Delete Recipe's Directions
        public static void DeleteRecipeSteps(int recipestepsid)
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand("RecipeStepsDelete");
            cmd.Parameters["@RecipeDirectionsId"].Value = recipestepsid;
            SqlUtility.ExecuteSQL(cmd);
        }
    }
}