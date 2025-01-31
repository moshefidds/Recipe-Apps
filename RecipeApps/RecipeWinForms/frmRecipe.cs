namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        DataTable dtingredient;
        DataTable dtsteps;
        BindingSource bindsource = new();
        int recipeid = 0;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            this.FormClosing += FrmRecipe_FormClosing;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            btnStepsSave.Click += BtnStepsSave_Click;
            txtNumOfCalories.KeyPress += TxtNumOfCalories_KeyPress;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
        }

        // Load Form
        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.LoadRecipe(recipeid);
            bindsource.DataSource = dtrecipe;
            bool newrecipe = false;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
                newrecipe = true;
            }
            DataTable dtusers = RecipeGeneralSystem.GetUserList(newrecipe);
            WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "User");

            DataTable dtcuisine = RecipeGeneralSystem.GetCuisineList(newrecipe);
            WindowsFormUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");

            WindowsFormUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(txtNumOfCalories, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, bindsource);

            this.Text = GetRecipeDesc().ToString();
            this.Show();

            //this.Shown += FrmRecipe_Shown;

            LoadIngredients();
            LoadSteps();
            SetControlsEnabledPerNewRecord();
        }

        // Load Ingredients
        private void LoadIngredients()
        {
            gIngredients.Columns.Clear();
            dtingredient = Recipe.LoadRecipeIngredientMeasurement(recipeid);
            gIngredients.DataSource = dtingredient;

            bool newrecipe = false;
            if (recipeid == 0)
            {
                newrecipe = true;
            }
            DataTable dtmeasurementlist = Recipe.GetMeasurementList(newrecipe);
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, dtmeasurementlist, "Measurement", "MeasurementType");

            DataTable dtingredientlist = Recipe.GetIngredientList(newrecipe);
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, dtingredientlist, "Ingredient", "IngredientName");

            WindowsFormUtility.AddDeleteButtonToGrid(gIngredients, "Delete");

            //foreach (DataGridViewButtonCell btn in gIngredients.Columns)
            //{
            //    if (btn.RowIndex == gIngredients.Rows.Count)
            //    {
                    
            //    }
            //}

            FormatIngredientsGrid();

        }

        // Load Steps
        private void LoadSteps()
        {
            gSteps.Columns.Clear();
            dtsteps = Recipe.LoadRecipeSteps(recipeid);
            gSteps.DataSource = dtsteps;

            WindowsFormUtility.AddDeleteButtonToGrid(gSteps, "Delete");

            WindowsFormUtility.FormatGridForEdit(gSteps, "RecipeDirections");
            gSteps.Columns["RecipeDirectionSequence"].ReadOnly = true;
        }

        // SaveRecipeSteps
        private void SaveRecipeSteps()
        {
            try
            {
                RecipeGeneralSystem.SaveTable(dtsteps, "RecipeStepsUpdate", "RecipeId", recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            LoadSteps();
        }

        // SaveRecipeIngredient
        private void SaveRecipeIngredient()
        {
            try
            {
                RecipeGeneralSystem.SaveTable(dtingredient, "RecipeIngredientUpdate", "RecipeId", recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            LoadIngredients();
        }

        // DeleteRecipeSteps
        private void DeleteRecipeSteps(int rowIndex)
        {
            if (rowIndex == dtsteps.Rows.Count)
            {
                return;
            }

            var response = MessageBox.Show("You're sure you want to Delete this Step?", "Recipe - Steps", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }

            int id = WindowsFormUtility.GetIdFromGrid(gSteps, rowIndex, "RecipeDirectionsId");
            if (id > 0)
            {
                try
                {
                    Recipe.DeleteRecipeSteps(id);
                    LoadSteps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowIndex);
            }
        }

        // DeleteRecipeIngredient
        private void DeleteRecipeIngredient(int rowIndex)
        {
            if (rowIndex == dtingredient.Rows.Count)
            {
                return;
            }

            var response = MessageBox.Show("You're sure you want to Delete this Ingredient?", "Recipe - Ingredient", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }

            int id = WindowsFormUtility.GetIdFromGrid(gIngredients, rowIndex, "RecipeIngredientId");
            if (id > 0)
            {
                try
                {
                    Recipe.DeleteRecipeIngredient(id);
                    LoadIngredients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIngredients.Rows.Count)
            {
                gIngredients.Rows.RemoveAt(rowIndex);
            }
        }

        // Save
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SqlUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetControlsEnabledPerNewRecord();
                this.Text = GetRecipeDesc().ToString();
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

        // Delete
        private void Delete()
        {
            var response = MessageBox.Show("You're sure you want to Delete?", "Record Keeper", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
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

        // ShowChangeStatusForm
        private void ShowChangeStatusForm(Type frmtype, int id)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                if (frmtype == typeof(frmChangeStatus))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), id);
                }
            }
        }

        // SetControlsEnabledPerNewRecord
        private void SetControlsEnabledPerNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnSaveIngredient.Enabled = b;
            btnStepsSave.Enabled = b;

            gIngredients.Columns["Delete"].Visible = b;

        }

        // GetRecipeDesc
        private StringBuilder GetRecipeDesc()
        {
            StringBuilder value = new();
            value.Append("Recipe - ");
            int pkvalue = SqlUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value.Append(SqlUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName"));
            }
            else value.Append("New Recipe");
            return value;
        }

        // FormatIngredientsGrid
        public void FormatIngredientsGrid()
        {
            WindowsFormUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            gIngredients.Columns["RecipeName"].Visible = false;
            gIngredients.Columns["IngredientName"].Visible = false;
            gIngredients.Columns["MeasurementType"].Visible = false;
            gIngredients.Columns["IngredientSequence"].ReadOnly = true;

            //gIngredients.Columns["Ingredient"].DisplayIndex = 1;
            //gIngredients.Columns["Measurement"].DisplayIndex = 2;
            //gIngredients.Columns["MeasurementAmount"].DisplayIndex = 3;
            //gIngredients.Columns["IngredientSequence"].DisplayIndex = 4;
            //gIngredients.Columns["Delete"].DisplayIndex = 5;
        }

        // Event Handlers

        //private void FrmRecipe_Shown(object? sender, EventArgs e)
        //{
        //    LoadIngredients();
        //}

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }

        private void BtnStepsSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeSteps();
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeSteps(e.RowIndex);
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeIngredient(e.RowIndex);
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ShowChangeStatusForm(typeof(frmChangeStatus), (int)this.Tag);
        }

        // Num of Calories - Only Numbers
        private void TxtNumOfCalories_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sender is TextBox tb)
            {
                string textboxname = tb.Name.Substring(3);
                WindowsFormUtility.FormatTextBoxToInt(e, textboxname);
            }
        }

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SqlUtility.TableHasChanges(dtrecipe))
            {
                var res = MessageBox.Show($"Do you wan't to save your changes to {this.Text} before leaving?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
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
