namespace RecipeWinForms
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            tblMain = new TableLayoutPanel();
            lblCaptionUser = new Label();
            lblCaptionCuisine = new Label();
            lblCaptionRecipeName = new Label();
            lblCaptionNumCalories = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            txtRecipeName = new TextBox();
            txtNumOfCalories = new TextBox();
            txtDateDrafted = new TextBox();
            tblControls = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            txtUserName = new TextBox();
            txtCuisineType = new TextBox();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblRecipeStatus = new Label();
            tblMain.SuspendLayout();
            tblControls.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionUser, 0, 0);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 1);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 2);
            tblMain.Controls.Add(lblCaptionNumCalories, 0, 3);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 4);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 5);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 6);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 7);
            tblMain.Controls.Add(txtRecipeName, 1, 2);
            tblMain.Controls.Add(txtNumOfCalories, 1, 3);
            tblMain.Controls.Add(txtDateDrafted, 1, 4);
            tblMain.Controls.Add(tblControls, 1, 9);
            tblMain.Controls.Add(txtUserName, 1, 0);
            tblMain.Controls.Add(txtCuisineType, 1, 1);
            tblMain.Controls.Add(lblDatePublished, 1, 5);
            tblMain.Controls.Add(lblDateArchived, 1, 6);
            tblMain.Controls.Add(lblRecipeStatus, 1, 7);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(612, 357);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.Anchor = AnchorStyles.Left;
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Location = new Point(4, 7);
            lblCaptionUser.Margin = new Padding(4, 0, 4, 0);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(42, 21);
            lblCaptionUser.TabIndex = 0;
            lblCaptionUser.Text = "User";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Location = new Point(4, 42);
            lblCaptionCuisine.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(61, 21);
            lblCaptionCuisine.TabIndex = 1;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(4, 78);
            lblCaptionRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(102, 21);
            lblCaptionRecipeName.TabIndex = 2;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionNumCalories
            // 
            lblCaptionNumCalories.Anchor = AnchorStyles.Left;
            lblCaptionNumCalories.AutoSize = true;
            lblCaptionNumCalories.Location = new Point(4, 115);
            lblCaptionNumCalories.Margin = new Padding(4, 0, 4, 0);
            lblCaptionNumCalories.Name = "lblCaptionNumCalories";
            lblCaptionNumCalories.Size = new Size(149, 21);
            lblCaptionNumCalories.TabIndex = 3;
            lblCaptionNumCalories.Text = "Number Of Calories";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(4, 152);
            lblCaptionDateDrafted.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(98, 21);
            lblCaptionDateDrafted.TabIndex = 4;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Location = new Point(4, 189);
            lblCaptionDatePublished.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(114, 21);
            lblCaptionDatePublished.TabIndex = 5;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Location = new Point(4, 226);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(107, 21);
            lblCaptionDateArchived.TabIndex = 6;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(4, 263);
            lblCaptionRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(102, 21);
            lblCaptionRecipeStatus.TabIndex = 7;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // txtRecipeName
            // 
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(161, 74);
            txtRecipeName.Margin = new Padding(4);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(447, 29);
            txtRecipeName.TabIndex = 11;
            // 
            // txtNumOfCalories
            // 
            txtNumOfCalories.BorderStyle = BorderStyle.FixedSingle;
            txtNumOfCalories.Dock = DockStyle.Fill;
            txtNumOfCalories.Location = new Point(161, 111);
            txtNumOfCalories.Margin = new Padding(4);
            txtNumOfCalories.Name = "txtNumOfCalories";
            txtNumOfCalories.Size = new Size(447, 29);
            txtNumOfCalories.TabIndex = 12;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(161, 148);
            txtDateDrafted.Margin = new Padding(4);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(447, 29);
            txtDateDrafted.TabIndex = 13;
            // 
            // tblControls
            // 
            tblControls.ColumnCount = 2;
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblControls.Controls.Add(btnSave, 0, 0);
            tblControls.Controls.Add(btnDelete, 1, 0);
            tblControls.Dock = DockStyle.Fill;
            tblControls.Location = new Point(160, 295);
            tblControls.Name = "tblControls";
            tblControls.RowCount = 1;
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblControls.Size = new Size(449, 59);
            tblControls.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(5, 5);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(214, 49);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(229, 5);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 49);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Location = new Point(160, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(449, 29);
            txtUserName.TabIndex = 19;
            // 
            // txtCuisineType
            // 
            txtCuisineType.BorderStyle = BorderStyle.FixedSingle;
            txtCuisineType.Dock = DockStyle.Fill;
            txtCuisineType.Location = new Point(160, 38);
            txtCuisineType.Name = "txtCuisineType";
            txtCuisineType.Size = new Size(449, 29);
            txtCuisineType.TabIndex = 20;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(165, 189);
            lblDatePublished.Margin = new Padding(8);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(439, 21);
            lblDatePublished.TabIndex = 21;
            lblDatePublished.Text = "label1";
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(165, 226);
            lblDateArchived.Margin = new Padding(8);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(439, 21);
            lblDateArchived.TabIndex = 22;
            lblDateArchived.Text = "label2";
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(165, 263);
            lblRecipeStatus.Margin = new Padding(8);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(439, 21);
            lblRecipeStatus.TabIndex = 23;
            lblRecipeStatus.Text = "label3";
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 357);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblControls.ResumeLayout(false);
            tblControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionUser;
        private Label lblCaptionCuisine;
        private Label lblCaptionRecipeName;
        private Label lblCaptionNumCalories;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private TextBox txtRecipeName;
        private TextBox txtNumOfCalories;
        private TextBox txtDateDrafted;
        private TableLayoutPanel tblControls;
        private Button btnSave;
        private Button btnDelete;
        private TextBox txtUserName;
        private TextBox txtCuisineType;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblRecipeStatus;
    }
}