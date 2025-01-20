namespace RecipeWinForms
{
    partial class frmCookbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCookbook));
            tblMain = new TableLayoutPanel();
            btnSaveBook = new Button();
            btnDeleteBook = new Button();
            lblCookbookName = new Label();
            txtCookBookName = new TextBox();
            lblUser = new Label();
            lstUserName = new ComboBox();
            lblDateCreatedCaption = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            txtCookBookPrice = new TextBox();
            lblDateRecorded = new Label();
            ckbCookBookActive = new CheckBox();
            btnSave = new Button();
            gCookbookRecipe = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.Controls.Add(btnSaveBook, 0, 0);
            tblMain.Controls.Add(btnDeleteBook, 1, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(txtCookBookName, 1, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lblDateCreatedCaption, 2, 3);
            tblMain.Controls.Add(lblPrice, 0, 3);
            tblMain.Controls.Add(lblActive, 0, 4);
            tblMain.Controls.Add(txtCookBookPrice, 1, 3);
            tblMain.Controls.Add(lblDateRecorded, 2, 4);
            tblMain.Controls.Add(ckbCookBookActive, 1, 4);
            tblMain.Controls.Add(btnSave, 0, 5);
            tblMain.Controls.Add(gCookbookRecipe, 0, 6);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 157F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(794, 814);
            tblMain.TabIndex = 0;
            // 
            // btnSaveBook
            // 
            btnSaveBook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSaveBook.BackColor = SystemColors.AppWorkspace;
            btnSaveBook.Location = new Point(15, 15);
            btnSaveBook.Margin = new Padding(15);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(234, 50);
            btnSaveBook.TabIndex = 0;
            btnSaveBook.Text = "Save Book";
            btnSaveBook.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteBook.BackColor = SystemColors.AppWorkspace;
            btnDeleteBook.Location = new Point(279, 15);
            btnDeleteBook.Margin = new Padding(15);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(234, 50);
            btnDeleteBook.TabIndex = 1;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(75, 99);
            lblCookbookName.Margin = new Padding(75, 15, 15, 15);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(174, 21);
            lblCookbookName.TabIndex = 2;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // txtCookBookName
            // 
            txtCookBookName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCookBookName.BorderStyle = BorderStyle.FixedSingle;
            tblMain.SetColumnSpan(txtCookBookName, 2);
            txtCookBookName.Location = new Point(279, 95);
            txtCookBookName.Margin = new Padding(15);
            txtCookBookName.Name = "txtCookBookName";
            txtCookBookName.Size = new Size(500, 29);
            txtCookBookName.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(75, 158);
            lblUser.Margin = new Padding(75, 15, 15, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(174, 21);
            lblUser.TabIndex = 4;
            lblUser.Text = "User";
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblMain.SetColumnSpan(lstUserName, 2);
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(279, 154);
            lstUserName.Margin = new Padding(15);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(500, 29);
            lstUserName.TabIndex = 5;
            // 
            // lblDateCreatedCaption
            // 
            lblDateCreatedCaption.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateCreatedCaption.AutoSize = true;
            lblDateCreatedCaption.Location = new Point(543, 221);
            lblDateCreatedCaption.Margin = new Padding(15);
            lblDateCreatedCaption.Name = "lblDateCreatedCaption";
            lblDateCreatedCaption.Size = new Size(103, 21);
            lblDateCreatedCaption.TabIndex = 6;
            lblDateCreatedCaption.Text = "Date Created:";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(75, 217);
            lblPrice.Margin = new Padding(75, 15, 15, 15);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(174, 21);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(75, 290);
            lblActive.Margin = new Padding(75, 15, 15, 15);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(174, 21);
            lblActive.TabIndex = 8;
            lblActive.Text = "Active";
            // 
            // txtCookBookPrice
            // 
            txtCookBookPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCookBookPrice.BorderStyle = BorderStyle.FixedSingle;
            txtCookBookPrice.Location = new Point(279, 213);
            txtCookBookPrice.Margin = new Padding(15, 15, 75, 15);
            txtCookBookPrice.Name = "txtCookBookPrice";
            txtCookBookPrice.Size = new Size(174, 29);
            txtCookBookPrice.TabIndex = 9;
            // 
            // lblDateRecorded
            // 
            lblDateRecorded.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDateRecorded.AutoSize = true;
            lblDateRecorded.BackColor = SystemColors.AppWorkspace;
            lblDateRecorded.BorderStyle = BorderStyle.FixedSingle;
            lblDateRecorded.Location = new Point(543, 284);
            lblDateRecorded.Margin = new Padding(15);
            lblDateRecorded.Name = "lblDateRecorded";
            lblDateRecorded.Padding = new Padding(5);
            lblDateRecorded.Size = new Size(236, 33);
            lblDateRecorded.TabIndex = 10;
            lblDateRecorded.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckbCookBookActive
            // 
            ckbCookBookActive.Dock = DockStyle.Fill;
            ckbCookBookActive.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ckbCookBookActive.Location = new Point(279, 272);
            ckbCookBookActive.Margin = new Padding(15, 15, 175, 15);
            ckbCookBookActive.Name = "ckbCookBookActive";
            ckbCookBookActive.Size = new Size(74, 57);
            ckbCookBookActive.TabIndex = 11;
            ckbCookBookActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = SystemColors.AppWorkspace;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(30, 354);
            btnSave.Margin = new Padding(30, 10, 10, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 39);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // gCookbookRecipe
            // 
            gCookbookRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gCookbookRecipe, 3);
            gCookbookRecipe.Dock = DockStyle.Fill;
            gCookbookRecipe.Location = new Point(3, 406);
            gCookbookRecipe.Name = "gCookbookRecipe";
            gCookbookRecipe.RowTemplate.Height = 25;
            gCookbookRecipe.Size = new Size(788, 405);
            gCookbookRecipe.TabIndex = 13;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 814);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmCookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSaveBook;
        private Button btnDeleteBook;
        private Label lblCookbookName;
        private TextBox txtCookBookName;
        private Label lblUser;
        private ComboBox lstUserName;
        private Label lblDateCreatedCaption;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtCookBookPrice;
        private Label lblDateRecorded;
        private CheckBox ckbCookBookActive;
        private Button btnSave;
        private DataGridView gCookbookRecipe;
    }
}