namespace RecipeWinForms
{
    public partial class frmCloneARecipe : Form
    {
        string recipename;
        public frmCloneARecipe()
        {
            InitializeComponent();
            btnClone.Click += BtnClone_Click;
            lstRecipe.TextChanged += LstRecipe_TextChanged;
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
        private bool CloneARecipe()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                int recipeid = WindowsFormUtility.GetIdFromCombobox(lstRecipe);
                RecipeGeneralSystem.CloneARecipe(recipeid);
                b = true;
                string newrecipe = recipename + " - clone";
                OpenNewRecipe(newrecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        // OpenNewRecipe
        private void OpenNewRecipe(string newrecipe)
        {
            DataTable dt = Recipe.GetRecipeList(false, 0, newrecipe);
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

        private void LstRecipe_TextChanged(object? sender, EventArgs e)
        {
            recipename = lstRecipe.Text;
        }
    }
}