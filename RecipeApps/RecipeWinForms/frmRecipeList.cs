namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            BindData();
        }

        // Bind Data
        private void BindData()
        {
            gRecipeList.DataSource = Recipe.GetRecipeList_Overview();
            WindowsFormUtility.FormatGridForSearch(gRecipeList, "Recipe");
        }

        // ShowRecipeForm
        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormUtility.GetIdFromGrid(gRecipeList, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }

        // Event Handlers
        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
