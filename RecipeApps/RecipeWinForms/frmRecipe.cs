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
            string sql = "select * from Recipe r where r.RecipeId = " + recipeid.ToString();
            dtrecipe = SqlUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            WindowsFormUtility.SetControlBinding(txtUserName, dtrecipe); //lblUser.DataBindings.Add("Text", dtrecipe, "UserName");
            WindowsFormUtility.SetControlBinding(txtCuisineType, dtrecipe); //lblCuisine.DataBindings.Add("Text", dtrecipe, "CuisineType");
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtrecipe); //txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            WindowsFormUtility.SetControlBinding(txtNumOfCalories, dtrecipe); //txtNumCalories.DataBindings.Add("Text", dt, "NumOfCalories");
            WindowsFormUtility.SetControlBinding(txtDateDrafted, dtrecipe); //txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            WindowsFormUtility.SetControlBinding(lblDatePublished, dtrecipe); //txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            WindowsFormUtility.SetControlBinding(lblDateArchived, dtrecipe); //txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, dtrecipe); //txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
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
                $"UserName = '{r["UserName"]}',",
                $"CuisineType = '{r["CuisineType"]}',",
                $"RecipeName = '{r["RecipeName"]}',",
                $"NumOfCalories = {r["NumOfCalories"]},",
                $"DateDrafted = '{r["DateDrafted"]}'",
                $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(UserName, CuisineType, RecipeName, NumOfCalories, DateDrafted) ";
                sql += $"select '{r["UserName"]}', '{r["CuisineType"]}', '{r["RecipeName"]}', {r["NumOfCalories"]}, '{r["DateDrafted"]}'";
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
