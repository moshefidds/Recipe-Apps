namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipesList.Click += MnuRecipesList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuCloneAREcipe.Click += MnuCloneARecipe_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuCookbooksList.Click += MnuCookbooksList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuAutoCreate.Click += MnuAutoCreate_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuTile.Click += MnuTile_Click;
            mnuCascade.Click += MnuCascade_Click;
            this.Shown += FrmMain_Shown;
        }

        // Initial Open Dashboard
        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        // Open Form
        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            var (exists, existingopenedfrm) = WindowsFormUtility.IsFormOpen(frmtype, pkvalue);
            if (exists == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbook))
                {
                    frmCookbook f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                else if (frmtype ==typeof(frmCloneARecipe))
                {
                    frmCloneARecipe f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmAutoCreateCookbook))
                {
                    frmAutoCreateCookbook f = new();
                    newfrm = f;
                }

                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
            }
            else if (exists == true)
            {
                existingopenedfrm.Activate();
            }
            WindowsFormUtility.SetupNav(tsMain);
        }

        // Event Handlers
        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreateCookbook));
        }

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }

        private void MnuCookbooksList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuCloneARecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneARecipe));
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }

        private void MnuRecipesList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));

        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void MnuCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormUtility.SetupNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormUtility.SetupNav(tsMain);
        }
    }
}
