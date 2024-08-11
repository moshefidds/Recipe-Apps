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
            lblCaptionRecipePictureFile = new Label();
            lblUser = new Label();
            lblCuisine = new Label();
            txtRecipeName = new TextBox();
            txtNumCalories = new TextBox();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtRecipeStatus = new TextBox();
            txtRecipePictureFile = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblCaptionUser, 0, 0);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 1);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 2);
            tblMain.Controls.Add(lblCaptionNumCalories, 0, 3);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 4);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 5);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 6);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 7);
            tblMain.Controls.Add(lblCaptionRecipePictureFile, 0, 8);
            tblMain.Controls.Add(lblUser, 1, 0);
            tblMain.Controls.Add(lblCuisine, 1, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 2);
            tblMain.Controls.Add(txtNumCalories, 1, 3);
            tblMain.Controls.Add(txtDateDrafted, 1, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Controls.Add(txtRecipeStatus, 1, 7);
            tblMain.Controls.Add(txtRecipePictureFile, 1, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(612, 359);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.Anchor = AnchorStyles.Left;
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Location = new Point(4, 0);
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
            lblCaptionCuisine.Location = new Point(4, 21);
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
            lblCaptionRecipeName.Location = new Point(4, 50);
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
            lblCaptionNumCalories.Location = new Point(4, 87);
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
            lblCaptionDateDrafted.Location = new Point(4, 124);
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
            lblCaptionDatePublished.Location = new Point(4, 161);
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
            lblCaptionDateArchived.Location = new Point(4, 198);
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
            lblCaptionRecipeStatus.Location = new Point(4, 235);
            lblCaptionRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(102, 21);
            lblCaptionRecipeStatus.TabIndex = 7;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblCaptionRecipePictureFile
            // 
            lblCaptionRecipePictureFile.AutoSize = true;
            lblCaptionRecipePictureFile.Location = new Point(4, 274);
            lblCaptionRecipePictureFile.Margin = new Padding(4, 10, 4, 0);
            lblCaptionRecipePictureFile.Name = "lblCaptionRecipePictureFile";
            lblCaptionRecipePictureFile.Size = new Size(136, 21);
            lblCaptionRecipePictureFile.TabIndex = 8;
            lblCaptionRecipePictureFile.Text = "Recipe Picture File";
            // 
            // lblUser
            // 
            lblUser.BackColor = SystemColors.Window;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(161, 0);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(447, 21);
            lblUser.TabIndex = 9;
            // 
            // lblCuisine
            // 
            lblCuisine.BackColor = SystemColors.Window;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Location = new Point(161, 21);
            lblCuisine.Margin = new Padding(4, 0, 4, 0);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(447, 21);
            lblCuisine.TabIndex = 10;
            // 
            // txtRecipeName
            // 
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(161, 46);
            txtRecipeName.Margin = new Padding(4);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(447, 29);
            txtRecipeName.TabIndex = 11;
            // 
            // txtNumCalories
            // 
            txtNumCalories.BorderStyle = BorderStyle.FixedSingle;
            txtNumCalories.Dock = DockStyle.Fill;
            txtNumCalories.Location = new Point(161, 83);
            txtNumCalories.Margin = new Padding(4);
            txtNumCalories.Name = "txtNumCalories";
            txtNumCalories.Size = new Size(447, 29);
            txtNumCalories.TabIndex = 12;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(161, 120);
            txtDateDrafted.Margin = new Padding(4);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(447, 29);
            txtDateDrafted.TabIndex = 13;
            // 
            // txtDatePublished
            // 
            txtDatePublished.BorderStyle = BorderStyle.FixedSingle;
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(161, 157);
            txtDatePublished.Margin = new Padding(4);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(447, 29);
            txtDatePublished.TabIndex = 14;
            // 
            // txtDateArchived
            // 
            txtDateArchived.BorderStyle = BorderStyle.FixedSingle;
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(161, 194);
            txtDateArchived.Margin = new Padding(4);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(447, 29);
            txtDateArchived.TabIndex = 15;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(161, 231);
            txtRecipeStatus.Margin = new Padding(4);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(447, 29);
            txtRecipeStatus.TabIndex = 16;
            // 
            // txtRecipePictureFile
            // 
            txtRecipePictureFile.BorderStyle = BorderStyle.FixedSingle;
            txtRecipePictureFile.Dock = DockStyle.Fill;
            txtRecipePictureFile.Location = new Point(161, 268);
            txtRecipePictureFile.Margin = new Padding(4);
            txtRecipePictureFile.Name = "txtRecipePictureFile";
            txtRecipePictureFile.Size = new Size(447, 29);
            txtRecipePictureFile.TabIndex = 17;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 359);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
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
        private Label lblCaptionRecipePictureFile;
        private Label lblUser;
        private Label lblCuisine;
        private TextBox txtRecipeName;
        private TextBox txtNumCalories;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipePictureFile;
    }
}