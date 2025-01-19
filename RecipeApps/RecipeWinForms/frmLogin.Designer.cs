namespace RecipeWinForms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            tblButtons = new TableLayoutPanel();
            txtPassword = new TextBox();
            lblUserNmae = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSubmit = new Button();
            btnExit = new Button();
            tblButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.02167F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.97833F));
            tblButtons.Controls.Add(txtPassword, 1, 1);
            tblButtons.Controls.Add(lblUserNmae, 0, 0);
            tblButtons.Controls.Add(lblPassword, 0, 1);
            tblButtons.Controls.Add(txtUserName, 1, 0);
            tblButtons.Controls.Add(tableLayoutPanel1, 1, 2);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(0, 0);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 4;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(527, 153);
            tblButtons.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(219, 38);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(305, 29);
            txtPassword.TabIndex = 3;
            // 
            // lblUserNmae
            // 
            lblUserNmae.Anchor = AnchorStyles.Right;
            lblUserNmae.AutoSize = true;
            lblUserNmae.Location = new Point(125, 7);
            lblUserNmae.Name = "lblUserNmae";
            lblUserNmae.Size = new Size(88, 21);
            lblUserNmae.TabIndex = 0;
            lblUserNmae.Text = "User Name";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(137, 42);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(219, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(305, 29);
            txtUserName.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnSubmit, 0, 0);
            tableLayoutPanel1.Controls.Add(btnExit, 1, 0);
            tableLayoutPanel1.Location = new Point(324, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(200, 54);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(3, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 43);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(103, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 43);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(527, 153);
            Controls.Add(tblButtons);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmLogin";
            Text = "Recipe Login";
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblButtons;
        private Label lblUserNmae;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSubmit;
        private Button btnExit;
    }
}