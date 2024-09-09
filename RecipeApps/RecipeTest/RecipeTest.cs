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

        // TestDelete
        [Test]
        public void TestDeleteRecipe()
        {
            var (recipeid, recipedt) = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No Recipes found in DB. Test can't run");

            TestContext.WriteLine("Existing Recipe Info is - RecipeId: " + recipeid + ", RecipeName: " + recipedt.Rows[0]["RecipeName"]);
            TestContext.WriteLine("Ensure that App can delete Recipe with RecipeId = " + recipeid);

            Recipe.Delete(recipedt);

            DataTable dtafterdelete = SqlUtility.GetDataTable("select * from recipe where RecipeId = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Deletion attempt failed. RecipeId = " + recipeid + " still in DB");
            TestContext.WriteLine("Successfuly deleted president with RecipeId = " + recipeid);
        }

// MF - Below is one test for all columns. Prefer a seperate test for each.
        
        //// TestUpdateRecipe
        //[TestCase("Fried Kishka", 99999, "1915-03-17 12:41:21")]
        //public void TestUpdateRecipe(string changerecipename, int changenumofcalories, DateTime changedatedrafted)
        //{
        //    var (recipeid, recipedt) = GetExistingRecipeId();
        //    Assume.That(recipeid > 0, "No Recipes found in DB. Test can't run");

        //    // get current values
        //    string recipename = (string)recipedt.Rows[0]["RecipeName"];
        //    int numofcalories = (int)recipedt.Rows[0]["NumOfCalories"];
        //    DateTime datedrafted = (DateTime)recipedt.Rows[0]["DateDrafted"];

        //    // state initial
        //    TestContext.WriteLine("Current RecipeId: " + recipeid + ", RecipeName is: " + recipename);
        //    TestContext.WriteLine("Current RecipeId: " + recipeid + ", NumOf Calories is: " + numofcalories);
        //    TestContext.WriteLine("Current RecipeId: " + recipeid + ", DaterDrafted is: " + datedrafted);

        //    // populate DataTable with TestCase values.
        //    changerecipename += " " + DateTime.Now.ToString();
        //    recipedt.Rows[0]["RecipeName"] = changerecipename;
        //    recipedt.Rows[0]["NumOfCalories"] = changenumofcalories;
        //    recipedt.Rows[0]["DateDrafted"] = changedatedrafted;

        //    // state changed
        //    TestContext.WriteLine("Attempting to update Recipe with RecipeId: " + recipeid + ", RecipeName chnanging to: " + changerecipename);
        //    TestContext.WriteLine("Attempting to update Recipe with RecipeId: " + recipeid + ", NumOf Calories chnanging to: " + changenumofcalories);
        //    TestContext.WriteLine("Attempting to update Recipe with RecipeId: " + recipeid + ", DaterDrafted chnanging to: " + changedatedrafted);
        //    Recipe.Save(recipedt);

        //    //check from table and Assert
        //    DataTable newrecipedt = Recipe.Load(recipeid);
        //    string newrecipename = (string)newrecipedt.Rows[0]["RecipeName"];
        //    int newnumofcalories = (int)newrecipedt.Rows[0]["NumOfCalories"];
        //    DateTime newdatedrafted = (DateTime)newrecipedt.Rows[0]["DateDrafted"];

        //    Assert.IsTrue(changerecipename == newrecipename , "Update attempt failed. RecipeName is still: " + recipename);
        //    Assert.IsTrue(changenumofcalories == newnumofcalories , "Update attempt failed. NumOfCalories is still: " + numofcalories);
        //    Assert.IsTrue(changedatedrafted == newdatedrafted , "Update attempt failed. DateDrafted is still: " + datedrafted);

        //    TestContext.WriteLine("Successfuly updated Recipe with RecipeId: " + recipeid + ", RecipeName updated to: " + newrecipename);
        //    TestContext.WriteLine("Successfuly updated Recipe with RecipeId: " + recipeid + ", NomOfCalories updated to: " + newnumofcalories);
        //    TestContext.WriteLine("Successfuly updated Recipe with RecipeId: " + recipeid + ", DateDrafted updated to: " + newdatedrafted);
        //}

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

        // Procedure - GetExistingRecipeId
        private (int, DataTable) GetExistingRecipeId()
        {
            int recipeid = SqlUtility.GetFirstColumnFirstRowValue("select top 1 RecipeId from Recipe");
            DataTable recipedt = Recipe.Load(recipeid);
            return (recipeid, recipedt);
        }
    }
}