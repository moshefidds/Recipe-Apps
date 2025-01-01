namespace RecipeWinForms
{
    public partial class frmCloneARecipe : Form
    {
        string recipename;
        public frmCloneARecipe()
        {
            InitializeComponent();
            btnClone.Click += BtnClone_Click;
            lstRecipe.Click += LstRecipe_Click;
            LoadForm();
        }

        // Load Form
        private void LoadForm()
        {
            lstRecipe.DataSource = Recipe.GetRecipeList();
            lstRecipe.DisplayMember = "RecipeName";
            lstRecipe.ValueMember = "RecipeId";
        }

        // CloneARecipe
        private void CloneARecipe()
        {
            int recipeid = WindowsFormUtility.GetIdFromCombobox(lstRecipe);
            RecipeGeneralSystem.CloneARecipe(recipeid);

            string newrecipe = recipename + " - clone";
            OpenNewRecipe(newrecipe);
        }

        // OpenNewRecipe
        private void OpenNewRecipe(string newrecipe)
        {
            DataTable dt = Recipe.SearchRecipes(newrecipe);
            int newrecipeid = (int)dt.Rows[0]["RecipeId"];
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), newrecipeid);
            }
            this.Close();
        }

        // Event Handlers
        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneARecipe();
        }

        private void LstRecipe_Click(object? sender, EventArgs e)
        {
            recipename = lstRecipe.Text;
        }
    }
}