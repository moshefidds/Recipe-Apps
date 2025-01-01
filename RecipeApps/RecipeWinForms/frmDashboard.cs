namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        // bind Data
        private void BindData()
        {
            gDashboard.DataSource = RecipeGeneralSystem.GetDashboard();
            WindowsFormUtility.FormatGridForView(gDashboard);
        }

        // Show Form
        private void ShowForm(Type frmtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                if (frmtype == typeof(frmRecipeList))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
                }
                else if (frmtype == typeof(frmMealList))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmMealList));
                }
            }
        }

        // Event Handlers
        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmCookbookList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmMealList));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipeList));
        }
    }
}
