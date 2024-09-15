﻿namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            WindowsFormUtility.FormatGridForSearch(gRecipe);
        }

        // SearchRecipe
        private void SearchRecipe(string recipe)
        {
            DataTable dt = Recipe.SearchRecipes(recipe);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        // ShowRecipeForm
        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipe frm = new();
            frm.ShowForm(id);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchRecipe(txtRecipe.Text);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
