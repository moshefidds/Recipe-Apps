using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }
        public void ShowForm(int recipeid)
        {
            string sql = "select u.UserName, c.CuisineType, r.* from Recipe r join [User] u on r.UserId = u.UserId join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId = " + recipeid.ToString();
            DataTable dt = SqlUtility.GetDataTable(sql);
            lblUser.DataBindings.Add("Text", dt, "UserName");
            lblCuisine.DataBindings.Add("Text", dt, "CuisineType");
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtNumCalories.DataBindings.Add("Text", dt, "NumOfCalories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtRecipePictureFile.DataBindings.Add("Text", dt, "RecipePictureFile");
            this.Show();

        }
    }
}
