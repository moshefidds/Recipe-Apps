namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
            LoadForm();
        }

        // LoadForm
        private void LoadForm()
        {
            lstUser.DataSource = RecipeGeneralSystem.GetUserList();
            lstUser.DisplayMember = "UserName";
            lstUser.ValueMember = "UserId";
        }

        // CreateCookbook
        private void CreateCookbook()
        {
            int userid = WindowsFormUtility.GetIdFromCombobox(lstUser);
            RecipeGeneralSystem.AutoCreateACookbook(userid);
        }

        // Event Handlers
        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }
    }
}
