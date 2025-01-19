using RecipeWinForms.Properties;
using System.Configuration;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;

        public frmLogin()
        {
            InitializeComponent();
            btnSubmit.Click += BtnSubmit_Click;
            btnExit.Click += BtnExit_Click;
        }

        public bool ShowLogin()
        {
#if DEBUG
            this.Text += " - DEV";
#endif
            txtUserName.Text = Settings.Default.userid;
            txtPassword.Text = Settings.Default.password;
            this.ShowDialog();
            return loginsuccess;
        }

        private void BtnSubmit_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstringkey = "";
#if DEBUG
                connstringkey = "devconn";
#else
                connstringkey = "liveconn";
#endif

                string connstring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                DBManager.SetConnectionString(connstring, true, txtUserName.Text, txtPassword.Text);
                loginsuccess = true;

                Settings.Default.userid = txtUserName.Text;
                Settings.Default.password = txtPassword.Text;
                Settings.Default.Save();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Login Attempt." + Environment.NewLine + "Please Try Again", Application.ProductName);
            }
        }


        private void BtnExit_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
