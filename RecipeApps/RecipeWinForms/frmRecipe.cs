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
using CPUWindowsFormFramework;

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
            string sql = "select r.*, c.CuisineType, u.UserName from Recipe r join [User] u on r.UserId = u.UserId join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId = " + recipeid.ToString();
            dtrecipe = SqlUtility.GetDataTable(sql);

            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = SqlUtility.GetDataTable("select UserId, UserName from [User]");
            WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "User");

            DataTable dtcuisine = SqlUtility.GetDataTable("select CuisineId, CuisineType from Cuisine");
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
            this.Close();
        }

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SqlUtility.ExecuteSQL(sql);
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
