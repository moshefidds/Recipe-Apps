namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtrecipe;
        BindingSource bindsource = new();
        int recipeid = 0;

        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }

        // Load Form
        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.LoadRecipe(recipeidval);
            BindData();
            this.Text = SqlUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName") + " - Change Status";
            SetButtonsPerStatus();
        }

        // Bind Data
        private void BindData()
        {
            bindsource.DataSource = dtrecipe;
            WindowsFormUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
        }

        // SetButtonsPerStatus
        private void SetButtonsPerStatus()
        {
            string currentstatus = SqlUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus");
            foreach (Button btn in tblButtons.Controls)
            {
                if (currentstatus.Contains(btn.Text))
                {
                    btn.Enabled = false;
                }
                else btn.Enabled = true;
            }
        }

        // UpdateRecipeStatus
        private void UpdateRecipeStatus(Label lbl)
        {
            var response = MessageBox.Show($"Change status to {lbl.Name.Substring(7)}", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                DateTime now = DateTime.Now;

                DataRow r = dtrecipe.Rows[0];
                    
                switch (lbl.Name)
                {
                    case "lblDateArchived":
                        r["DateArchived"] = now.ToString();
                        break;
                    case "lblDatePublished":
                        r["DatePublished"] = now.ToString();
                        r["DateArchived"] = DBNull.Value;
                        break;
                    case "lblDateDrafted":
                        r["DateDrafted"] = now.ToString();
                        r["DateArchived"] = DBNull.Value;
                        r["DatePublished"] = DBNull.Value;
                        break;
                }

                SqlUtility.SaveDataRow(r, "RecipeStatusUpdate");
                dtrecipe = Recipe.LoadRecipe((int)this.Tag);
                bindsource.DataSource = dtrecipe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        // event Handlers
        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            UpdateRecipeStatus(lblDateArchived);
            SetButtonsPerStatus();
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            UpdateRecipeStatus(lblDatePublished);
            SetButtonsPerStatus();
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            UpdateRecipeStatus(lblDateDrafted);
            SetButtonsPerStatus();
        }
    }
}
