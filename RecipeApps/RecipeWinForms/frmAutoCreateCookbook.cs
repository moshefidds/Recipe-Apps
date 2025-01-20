namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        string username;
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
            lstUser.Click += LstUser_Click;
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
        private bool CreateCookbook()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                int userid = WindowsFormUtility.GetIdFromCombobox(lstUser);
                RecipeGeneralSystem.AutoCreateACookbook(userid);
                b = true;
                OpenNewCookbook();
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

        private void OpenNewCookbook()
        {
            DataTable userdt = RecipeGeneralSystem.GetUserList(false, username);
            string firstname = userdt.Rows[0]["UserFirstName"].ToString();
            string lastname = userdt.Rows[0]["UserLastName"].ToString();
            string newcookbookname = "Recipes by " + firstname + " " + lastname;

            DataTable dt = Cookbook.Load(0, newcookbookname);
            int newcookbookid = (int)dt.Rows[0]["CookBookId"];
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), newcookbookid);
            }
            this.Close();
        }

        // Event Handlers
        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }

        private void LstUser_Click(object? sender, EventArgs e)
        {
            username = lstUser.Text;
        }
    }
}
