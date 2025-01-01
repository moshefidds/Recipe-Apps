namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            gCookbookList.CellDoubleClick += GCookbookList_CellDoubleClick;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            BindData();
        }

        // Bind Dat
        private void BindData()
        {
            gCookbookList.DataSource = Cookbook.GetCookbookList();
            WindowsFormUtility.FormatGridForSearch(gCookbookList, "Cookbook");
        }

        // ShowCookbookForm
        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormUtility.GetIdFromGrid(gCookbookList, rowindex, "CookBookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }

        // Event Handlers
        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }

        private void GCookbookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }
    }
}
