using RecipeSystem;
using System.Data;

namespace RecipeTest
{
    public class ResipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=tcp:mfiddle-cpu.database.windows.net,1433;Initial Catalog=RecipeDB;Persist Security Info=False;User ID=moshefiddle1234@gmail.com@mfiddle-cpu;Password=MoeFidds6074!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        // TestCorrectRecipeLoaded
        [Test]
        public void TestCorrectRecipeLoaded()
        {
            var (recipeid, recipedt) = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No Recipes were found in DB. Test can't run");

            TestContext.WriteLine("Existing Recipe's Id = " + recipeid);
            TestContext.WriteLine("Ensure that RecipeId loaded by App = " + recipeid);

            int loadedrecipeid = (int)recipedt.Rows[0]["RecipeId"];

            Assert.IsTrue(loadedrecipeid == recipeid, "RecipeId returned by App (" + loadedrecipeid + "( <> " + recipeid);
            TestContext.WriteLine("RecipeId returned by App = " + loadedrecipeid);
        }

        // TestRecipeSearchPerCriteria
        [Test]
        public void TestRecipeSearchPerCriteria()
        {
            string criteria = "c";
            int num = SqlUtility.GetFirstColumnFirstRowValue("select total = Count(*) from Recipe where RecipeName like '%" + criteria + "%'");
            Assume.That(num > 0, "No Recipes were found in DB that match the search criteria = " + criteria);
            TestContext.WriteLine("Number of Recipes that match the search criteria of: " + criteria + " = " + num);
            TestContext.WriteLine("Ensure that number of Recipes returned by App with search criteria of: " + criteria + " = " + num);

            DataTable dt = Recipe.SearchRecipes(criteria);
            int results = dt.Rows.Count;

            Assert.IsTrue(results == num, "Num of Recipes returned by App (" + results + ") <> " + num);
            TestContext.WriteLine("Number of Recipes returned by App with search criteria of: " + criteria + " = " + results);
        }

        // TestCuisineList
        [Test]
        public void TestCuisineList()
        {
            int cuisinecount = SqlUtility.GetFirstColumnFirstRowValue("select Total = count(*) from Cuisine");
            Assume.That(cuisinecount > 0, "No Cuisines were found in DB. Test can't run");

            TestContext.WriteLine("Number of Cuisines = " + cuisinecount);
            TestContext.WriteLine("Ensure that number of Rows returned by App = " + cuisinecount);

            DataTable dt = Recipe.GetCuisineList();
            Assert.IsTrue(dt.Rows.Count == cuisinecount, "Num Rows returned by App (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Number of rows in Cuisine returned by App = " + dt.Rows.Count);
        }

        // TestUserList
        [Test]
        public void TestUserList()
        {
            int usercount = SqlUtility.GetFirstColumnFirstRowValue("select Total = count(*) from[User]");
            Assume.That(usercount > 0, "No Users were found in DB. Test can't run");

            TestContext.WriteLine("Number of Users = " + usercount);
            TestContext.WriteLine("Ensure that number of Rows returned by App = " + usercount);

            DataTable dt = Recipe.GetUserList();
            Assert.IsTrue(dt.Rows.Count == usercount, "Num Rows returned by App (" + dt.Rows.Count + ") <> " + usercount);
            TestContext.WriteLine("Number of rows in Users returned by App = " + dt.Rows.Count);
        }

        // TestDeleteRecipe
        [Test]
        public void TestDeleteRecipe()
        {
            string sql = @"
                select top 1 * 
                from Recipe r 
                left join RecipeIngredient ri 
                on r.RecipeId = ri.RecipeId 
                left join RecipeDirections rd 
                on r.RecipeId = rd.RecipeId 
                left join MealCourseRecipe mcr 
                on r.RecipeId = mcr.RecipeId 
                left join CookBookRecipe cbr 
                on r.RecipeId = cbr.RecipeId 
                where ri.RecipeIngredientId is null 
                and rd.RecipeDirectionsId is null 
                and mcr.MealCourseRecipeId is null 
                and cbr.CookBookRecipeId is null
                and (r.RecipeStatus = 'Drafted' or datediff(day, r.DateArchived, GetDate()) > 30)
                ";
            var (recipeid, recipedt) = GetExistingRecipeId(sql);
            Assume.That(recipeid > 0, "No Recipes without any related records found in DB. Test can't run");

            TestContext.WriteLine("Existing Recipe Info is - RecipeId: " + recipeid + ", RecipeName: " + recipedt.Rows[0]["RecipeName"]);
            TestContext.WriteLine("Ensure that App can delete Recipe with RecipeId = " + recipeid);

            Recipe.Delete(recipedt);

            DataTable dtafterdelete = SqlUtility.GetDataTable("select * from recipe where RecipeId = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Deletion attempt failed. RecipeId = " + recipeid + " still in DB");
            TestContext.WriteLine("Successfuly deleted president with RecipeId = " + recipeid);
        }

        // TestUpdateRecipe_RecipeName
        [TestCase("Fried Kishka")]
        public void TestUpdateRecipe_RecipeName(string changerecipename)
        {
            var (recipeid, recipedt) = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No Recipes found in DB. Test can't run");

            // get current values
            string recipename = (string)recipedt.Rows[0]["RecipeName"];
            TestContext.WriteLine("Current RecipeId: " + recipeid + ", RecipeName is: " + recipename);

            // populate DataTable with TestCase values.
            changerecipename += " " + DateTime.Now.ToString();
            recipedt.Rows[0]["RecipeName"] = changerecipename;

            // execute test
            TestContext.WriteLine("Attempting to update Recipe with RecipeId: " + recipeid + ", RecipeName chnanging to: " + changerecipename);
            Recipe.Save(recipedt);

            //check from table and Assert
            DataTable newrecipedt = Recipe.Load(recipeid);
            string newrecipename = (string)newrecipedt.Rows[0]["RecipeName"];
            Assert.IsTrue(changerecipename == newrecipename, "Update attempt failed. RecipeName is still: " + recipename);
            TestContext.WriteLine("Successfuly updated Recipe with RecipeId: " + recipeid + ", RecipeName updated to: " + newrecipename);
        }

        // TestUpdateRecipe_NumOfCalories
        [TestCase(99999)]
        public void TestUpdateRecipe_NumOfCalories(int changenumofcalories)
        {
            var (recipeid, recipedt) = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No Recipes found in DB. Test can't run");

            // get current values
            int numofcalories = (int)recipedt.Rows[0]["NumOfCalories"];
            TestContext.WriteLine("Current RecipeId: " + recipeid + ", NumOf Calories is: " + numofcalories);

            // populate DataTable with TestCase values.
            recipedt.Rows[0]["NumOfCalories"] = changenumofcalories;

            // execute test
            TestContext.WriteLine("Attempting to update Recipe with RecipeId: " + recipeid + ", NumOf Calories chnanging to: " + changenumofcalories);
            Recipe.Save(recipedt);

            //check from table and Assert
            DataTable newrecipedt = Recipe.Load(recipeid);
            int newnumofcalories = (int)newrecipedt.Rows[0]["NumOfCalories"];
            Assert.IsTrue(changenumofcalories == newnumofcalories, "Update attempt failed. NumOfCalories is still: " + numofcalories);
            TestContext.WriteLine("Successfuly updated Recipe with RecipeId: " + recipeid + ", NomOfCalories updated to: " + newnumofcalories);
        }

        // TestUpdateRecipe_DateDrafted
        [TestCase("1915-03-17 12:41:21")]
        public void TestUpdateRecipe_DateDrafted(DateTime changedatedrafted)
        {
            var (recipeid, recipedt) = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No Recipes found in DB. Test can't run");
            // get current values
            DateTime datedrafted = (DateTime)recipedt.Rows[0]["DateDrafted"];
            TestContext.WriteLine("Current RecipeId: " + recipeid + ", DaterDrafted is: " + datedrafted);

            // populate DataTable with TestCase values.
            recipedt.Rows[0]["DateDrafted"] = changedatedrafted;

            // execute test
            TestContext.WriteLine("Attempting to update Recipe with RecipeId: " + recipeid + ", DaterDrafted chnanging to: " + changedatedrafted);
            Recipe.Save(recipedt);

            //check from table and Assert
            DataTable newrecipedt = Recipe.Load(recipeid);
            DateTime newdatedrafted = (DateTime)newrecipedt.Rows[0]["DateDrafted"];
            Assert.IsTrue(changedatedrafted == newdatedrafted, "Update attempt failed. DateDrafted is still: " + datedrafted);
            TestContext.WriteLine("Successfuly updated Recipe with RecipeId: " + recipeid + ", DateDrafted updated to: " + newdatedrafted);
        }

        // TestInsertRecipe
        [TestCase("Fried Kugel", 99999, "2015-03-17 12:41:21.113")]
        public void TestInsertRecipe(string recipename, int numofcalories, DateTime datedrafted)
        {
            DataTable dt = SqlUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int cuisineid = SqlUtility.GetFirstColumnFirstRowValue("select top 1 CuisineId from Cuisine");
            int userid = SqlUtility.GetFirstColumnFirstRowValue("select top 1 UserId from [User]"); ;

            Assume.That(cuisineid > 0, "No Cuisines were found in DB. Test can't run");
            Assume.That(userid > 0, "No Users were found in DB. Test can't run");

            recipename += " " + DateTime.Now.ToString();

            TestContext.WriteLine("Attempting to Insert new Recipe with RecipeName: " + recipename);

            r["UserId"] = userid;
            r["CuisineId"] = cuisineid;
            r["RecipeName"] = recipename;
            r["NumOfCalories"] = numofcalories;
            r["DateDrafted"] = datedrafted;

            Recipe.Save(dt);

            int newrecipeid = SqlUtility.GetFirstColumnFirstRowValue("select * from recipe where RecipeName = '" + recipename + "'");

            Assert.IsTrue(newrecipeid > 0, "Insert failed. Recipe with name: " + recipename + " not found");
            TestContext.WriteLine("Successfuly inserted new Recipe with - pkId: " + newrecipeid + ", RecipeName: " + recipename);
        }

        // TestInvalidDeleteRecipe_WithFk
        //[TestCase("ri.RecipeIngredientId")]
        //[TestCase("rd.RecipeDirectionsId")]
        [TestCase("mcr.MealCourseRecipeId")]
        [TestCase("cbr.CookBookRecipeId")]
        public void TestInvalidDeleteRecipe_WithFk(string tableid)
        {
            string sql = "select top 1 * " +
                "from Recipe r " +
                "left join RecipeIngredient ri " +
                "on r.RecipeId = ri.RecipeId " +
                "left join RecipeDirections rd  " +
                "on r.RecipeId = rd.RecipeId " +
                "left join MealCourseRecipe mcr " +
                "on r.RecipeId = mcr.RecipeId " +
                "left join CookBookRecipe cbr " +
                "on r.RecipeId = cbr.RecipeId " +
                "order by " + tableid + " desc";
            var (recipeid, recipedt) = GetExistingRecipeId(sql);
            Assume.That(recipeid > 0, "No Recipes with related records in " + tableid +  " found in DB. Test can't run");

            TestContext.WriteLine("Existing Recipe Info is - RecipeId: " + recipeid + ", RecipeName: " + recipedt.Rows[0]["RecipeName"]);
            TestContext.WriteLine("Ensure that App cannot delete Recipe with RecipeId = " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(recipedt));
            TestContext.WriteLine(ex.Message);
        }

        // TestInvalidDeleteRecipe_BusinessRule_Published_Or_Drafted_Less_Than_30_Days
        [Test]
        public void TestInvalidDeleteRecipe_BusinessRule_Published_Or_Drafted_Less_Than_30_Days()
        {
            string sql = @"
            select * 
            from Recipe r 
            where r.RecipeStatus = 'Published'
            or 
            (
                r.RecipeStatus = 'Archived' 
                and 
                datediff(day, r.DateArchived, GetDate()) <= 30
            )
            ";
            var (recipeid, recipedt) = GetExistingRecipeId(sql);
            Assume.That(recipeid > 0, "No Recipes in 'Published' or in 'Drafted' for less than 30 days found in DB. Test can't run");

            TestContext.WriteLine("Existing Recipe in 'Published' or in 'Drafted' for less than 30 days Info is - RecipeId: " + recipeid + ", RecipeName: " + recipedt.Rows[0]["RecipeName"]);
            TestContext.WriteLine("Ensure that App cannot delete Recipe in 'Published' or in 'Drafted' for less than 30 days with RecipeId = " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(recipedt));
            TestContext.WriteLine(ex.Message);
        }

        // TestInvalidInsertRecipe_Existing
        [Test]
        public void TestInvalidInsertRecipe_Existing()
        {
            DataTable dt = SqlUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int cuisineid = SqlUtility.GetFirstColumnFirstRowValue("select top 1 CuisineId from Cuisine");
            int userid = SqlUtility.GetFirstColumnFirstRowValue("select top 1 UserId from [User]"); ;

            Assume.That(cuisineid > 0, "No Cuisines were found in DB. Test can't run");
            Assume.That(userid > 0, "No Users were found in DB. Test can't run");

            string recipename = SqlUtility.GetExistingRecord("RecipeName", "Recipe");

            TestContext.WriteLine("Attempting to Insert new Recipe with RecipeName: " + recipename);

            r["UserId"] = userid;
            r["CuisineId"] = cuisineid;
            r["RecipeName"] = recipename;
            r["NumOfCalories"] = 100;
            r["DateDrafted"] = "2015-03-17 12:41:21.113";

            Exception ex = Assert.Throws<Exception>(()=> Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        // TestInvalidInsertRecipe_Blank
        [TestCase("")]
        public void TestInvalidInsertRecipe_Blank(string recipename)
        {
            DataTable dt = SqlUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int cuisineid = SqlUtility.GetFirstColumnFirstRowValue("select top 1 CuisineId from Cuisine");
            int userid = SqlUtility.GetFirstColumnFirstRowValue("select top 1 UserId from [User]"); ;

            Assume.That(cuisineid > 0, "No Cuisines were found in DB. Test can't run");
            Assume.That(userid > 0, "No Users were found in DB. Test can't run");

            TestContext.WriteLine("Attempting to Insert new Recipe with a blank RecipeName");

            r["UserId"] = userid;
            r["CuisineId"] = cuisineid;
            r["RecipeName"] = recipename;
            r["NumOfCalories"] = 100;
            r["DateDrafted"] = "2015-03-17 12:41:21.113";

            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        // TestInvalidInsertNumOfCalories_NegativeOrZero
        [TestCase(0)]
        [TestCase(-5)]
        public void TestInvalidInsertNumOfCalories_NegativeOrZero(int numofcalories)
        {
            DataTable dt = SqlUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int cuisineid = SqlUtility.GetFirstColumnFirstRowValue("select top 1 CuisineId from Cuisine");
            int userid = SqlUtility.GetFirstColumnFirstRowValue("select top 1 UserId from [User]"); ;

            Assume.That(cuisineid > 0, "No Cuisines were found in DB. Test can't run");
            Assume.That(userid > 0, "No Users were found in DB. Test can't run");

            TestContext.WriteLine("Attempting to Insert new Recipe with a NumOfCalories = " + numofcalories);

            r["UserId"] = userid;
            r["CuisineId"] = cuisineid;
            r["RecipeName"] = "Mack & Cheese";
            r["NumOfCalories"] = numofcalories;
            r["DateDrafted"] = "2015-03-17 12:41:21.113";

            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        // Procedure - GetExistingRecipeId
        private (int, DataTable) GetExistingRecipeId(String sql = "select top 1 RecipeId from Recipe")
        {
            int recipeid = SqlUtility.GetFirstColumnFirstRowValue(sql);
            DataTable recipedt = Recipe.Load(recipeid);
            return (recipeid, recipedt);
        } 
    }
}