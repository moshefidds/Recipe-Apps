namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { User, Cuisine, Ingredient, Measurement, Course }
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.User;
        string deletecolumnname = "deletecol";

        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
            this.FormClosing += FrmDataMaintenance_FormClosing;

            SetRadioButtons();
            BindData(currenttabletype);
        }

        // Bind Data
        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;

            WindowsFormUtility.AddDeleteButtonToGrid(gData, deletecolumnname);
            WindowsFormUtility.FormatGridForEdit(gData, tabletype.ToString());

        }

        // SetRadioButtons
        private void SetRadioButtons()
        {
            foreach (Control c in pnlOptionButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optUsers.Tag = TableTypeEnum.User;
            optCuisines.Tag = TableTypeEnum.Cuisine;
            optIngredients.Tag = TableTypeEnum.Ingredient;
            optMeasurements.Tag = TableTypeEnum.Measurement;
            optCourses.Tag = TableTypeEnum.Course;
        }

        // Event - RadioButton Clicked
        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        // Save
        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        // Delete
        private void Delete(int rowIndex)
        {
            var response = MessageBox.Show($"You're about to Delete this {currenttabletype} with all it's related Records." + Environment.NewLine + "Are you sure you'd like to go ahead?",  currenttabletype.ToString(), MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }

            int id = WindowsFormUtility.GetIdFromGrid(gData, rowIndex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowIndex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowIndex]);
            }
        }

        // Event Handlers
        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolumnname)
            {
                Delete(e.RowIndex);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SqlUtility.TableHasChanges(dtlist))
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
