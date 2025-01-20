namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook;
        DataTable dtcookbookrecipe;
        BindingSource bindsource = new();
        int cookbookid = 0;
        public frmCookbook()
        {
            InitializeComponent();

            btnDeleteBook.Click += BtnDeleteBook_Click;
            btnSaveBook.Click += BtnSaveBook_Click;
            btnSave.Click += BtnSave_Click;
            gCookbookRecipe.CellContentClick += GCookbookRecipe_CellContentClick;
            txtCookBookPrice.KeyPress += TxtCookBookPrice_KeyPress;
            this.FormClosing += FrmCookbook_FormClosing;
        }

        // Load Form
        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            bool newrecipe = false;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
                newrecipe = true;
            }
            DataTable dtusers = RecipeGeneralSystem.GetUserList(newrecipe);
            WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtcookbook, "User");

            WindowsFormUtility.SetControlBinding(txtCookBookName, bindsource);
            WindowsFormUtility.SetControlBinding(txtCookBookPrice, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateRecorded, bindsource);
            WindowsFormUtility.SetControlBinding(ckbCookBookActive, bindsource);

            SetControlsEnabledPerNewRecord();

            this.Text = GetCookbookDesc().ToString();
            this.Show();
            ckbCookBookActive.CheckState = CheckState.Checked;
            LoadCookbookRecipe();
        }

        // Load CookbookRecipe
        private void LoadCookbookRecipe()
        {
            gCookbookRecipe.Columns.Clear();
            dtcookbookrecipe = Cookbook.GetCookbookRecipeList(cookbookid);
            gCookbookRecipe.DataSource = dtcookbookrecipe;

            bool newrecipe = false;
            if (cookbookid == 0)
            {
                newrecipe = true;
            }
            DataTable dtrecipelist = Cookbook.GetRecipeList(newrecipe);
            WindowsFormUtility.AddComboBoxToGrid(gCookbookRecipe, dtrecipelist, "Recipe", "RecipeName");

            WindowsFormUtility.AddDeleteButtonToGrid(gCookbookRecipe, "Delete");

            WindowsFormUtility.FormatGridForEdit(gCookbookRecipe, "CookBookRecipe");
            gCookbookRecipe.Columns["RecipeName"].Visible = false;
            gCookbookRecipe.Columns["CookBookRecipeSequence"].ReadOnly = true;
        }

        // Save Cookbook
        private bool SaveCookbook()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SqlUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookBookId");
                this.Tag = cookbookid;
                SetControlsEnabledPerNewRecord();
                this.Text = GetCookbookDesc().ToString();

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

        // Delete Cookbook
        private void DeleteCookbook()
        {
            var response = MessageBox.Show("You're sure you want to Delete this Cookbook with all related Records?", "Cookbook", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CookBook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        // SaveCookbookRecipe
        private void SaveCookbookRecipe()
        {
            try
            {
                RecipeGeneralSystem.SaveTable(dtcookbookrecipe, "CookbookRecipeUpdate", "CookBookId", cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            LoadCookbookRecipe();
        }

        // DeleteCookbookRecipe
        private void DeleteCookbookRecipe(int rowIndex)
        {
            var response = MessageBox.Show("You're sure you want to Delete this Recipe?", "Cookbook Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }

            int id = WindowsFormUtility.GetIdFromGrid(gCookbookRecipe, rowIndex, "CookBookRecipeId");
            if (id > 0)
            {
                try
                {
                    Cookbook.DeleteCookbookRecipe(id);
                    LoadCookbookRecipe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gCookbookRecipe.Rows.Count)
            {
                gCookbookRecipe.Rows.RemoveAt(rowIndex);
            }
        }

        // SetControlsEnabledPerNewRecord 
        private void SetControlsEnabledPerNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDeleteBook.Enabled = b;
            btnSave.Enabled = b;
        }

        // GetCookbookDesc
        private StringBuilder GetCookbookDesc()
        {
            StringBuilder value = new();
            value.Append("Cookbook - ");
            int pkvalue = SqlUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookBookId");
            if (pkvalue > 0)
            {
                value.Append(SqlUtility.GetValueFromFirstRowAsString(dtcookbook, "CookBookName"));
            }
            else value.Append("New Cookbook");
            return value;
        }

        // Event Handlers
        private void GCookbookRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookbookRecipe(e.RowIndex);
        }

        private void BtnSaveBook_Click(object? sender, EventArgs e)
        {
            SaveCookbook();
        }

        private void BtnDeleteBook_Click(object? sender, EventArgs e)
        {
            DeleteCookbook();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }


        // Cookbook Price - Only Numbers
        private void TxtCookBookPrice_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sender is TextBox tb)
            {
                string textboxname = tb.Name.Substring(3);
                WindowsFormUtility.FormatTextBoxToInt(e, textboxname);
            }
        }
        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SqlUtility.TableHasChanges(dtcookbook))
            {
                var res = MessageBox.Show($"Do you wan't to save your changes to {this.Text} before leaving?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = SaveCookbook();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
