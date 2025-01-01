namespace RecipeWinForms
{
    partial class frmAutoCreateCookbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoCreateCookbook));
            tblMain = new TableLayoutPanel();
            lstUser = new ComboBox();
            btnCreateCookbook = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.6443138F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.3556862F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(lstUser, 0, 0);
            tblMain.Controls.Add(btnCreateCookbook, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 1;
            // 
            // lstUser
            // 
            lstUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lstUser.FormattingEnabled = true;
            lstUser.Location = new Point(50, 295);
            lstUser.Margin = new Padding(50, 3, 50, 3);
            lstUser.Name = "lstUser";
            lstUser.Size = new Size(452, 40);
            lstUser.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCreateCookbook.BackColor = SystemColors.AppWorkspace;
            btnCreateCookbook.Location = new Point(602, 290);
            btnCreateCookbook.Margin = new Padding(50, 15, 50, 15);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(377, 50);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = false;
            // 
            // frmAutoCreateCookbook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmAutoCreateCookbook";
            Text = "Auto-Create a Cookbook";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUser;
        private Button btnCreateCookbook;
    }
}