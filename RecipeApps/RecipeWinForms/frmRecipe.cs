
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
        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);

            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUserList();
            WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "User");

            DataTable dtcuisine = Recipe.GetCuisineList(); 
            WindowsFormUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");

            WindowsFormUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtNumOfCalories, dtrecipe);
            WindowsFormUtility.SetControlBinding(dtpDateDrafted, dtrecipe);
            WindowsFormUtility.SetControlBinding(lblDatePublished, dtrecipe);
            WindowsFormUtility.SetControlBinding(lblDateArchived, dtrecipe);
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            Recipe.Save(dtrecipe);
            this.Close();
        }

        private void Delete()
        {
            Recipe.Delete(dtrecipe);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
