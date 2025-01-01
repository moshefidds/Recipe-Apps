using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Meal
    {
        // Get Meal List
        public static DataTable GetMealList()
        {
            SqlCommand cmd = SqlUtility.GetSqlCommand("MealListGet");
            return SqlUtility.GetDataTable(cmd);
        }
    }
}
