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
            tblControls = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            lblCaptionRecipeName = new Label();
            lblCaptionUser = new Label();
            lblCaptionCuisine = new Label();
            lblCaptionNumCalories = new Label();
            lblCaptionRecipeStatus = new Label();
            tblStatus = new TableLayoutPanel();
            lblCaptionStatusDates = new Label();
            lblCaptionDateDrafted = new Label();
            lblDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblDateArchived = new Label();
            txtRecipeName = new TextBox();
            lstUserName = new ComboBox();
            lstCuisineType = new ComboBox();
            txtNumOfCalories = new TextBox();
            lblRecipeStatus = new Label();
            tabRecipeInfo = new TabControl();
            tabPageIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredient = new Button();
            gIngredients = new DataGridView();
            tabPageSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnStepsSave = new Button();
            gSteps = new DataGridView();
            tblMain.SuspendLayout();
            tblControls.SuspendLayout();
            tblStatus.SuspendLayout();
            tabRecipeInfo.SuspendLayout();
            tabPageIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tabPageSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblMain.Controls.Add(tblControls, 0, 0);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 1);
            tblMain.Controls.Add(lblCaptionUser, 0, 2);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 3);
            tblMain.Controls.Add(lblCaptionNumCalories, 0, 4);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 5);
            tblMain.Controls.Add(tblStatus, 0, 6);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lstCuisineType, 1, 3);
            tblMain.Controls.Add(txtNumOfCalories, 1, 4);
            tblMain.Controls.Add(lblRecipeStatus, 1, 5);
            tblMain.Controls.Add(tabRecipeInfo, 0, 7);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(829, 901);
            tblMain.TabIndex = 0;
            // 
            // tblControls
            // 
            tblControls.ColumnCount = 3;
            tblMain.SetColumnSpan(tblControls, 2);
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblControls.Controls.Add(btnSave, 0, 0);
            tblControls.Controls.Add(btnDelete, 1, 0);
            tblControls.Controls.Add(btnChangeStatus, 2, 0);
            tblControls.Dock = DockStyle.Fill;
            tblControls.Location = new Point(3, 3);
            tblControls.Name = "tblControls";
            tblControls.RowCount = 1;
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblControls.Size = new Size(823, 59);
            tblControls.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = SystemColors.AppWorkspace;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(30, 10);
            btnSave.Margin = new Padding(30, 10, 10, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 39);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = SystemColors.AppWorkspace;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(215, 10);
            btnDelete.Margin = new Padding(10, 10, 30, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 39);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnChangeStatus.BackColor = SystemColors.AppWorkspace;
            btnChangeStatus.Location = new Point(629, 10);
            btnChangeStatus.Margin = new Padding(10);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(184, 39);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Dock = DockStyle.Fill;
            lblCaptionRecipeName.Location = new Point(30, 65);
            lblCaptionRecipeName.Margin = new Padding(30, 0, 4, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(214, 37);
            lblCaptionRecipeName.TabIndex = 2;
            lblCaptionRecipeName.Text = "Recipe Name";
            lblCaptionRecipeName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Dock = DockStyle.Fill;
            lblCaptionUser.Location = new Point(30, 102);
            lblCaptionUser.Margin = new Padding(30, 0, 4, 0);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(214, 35);
            lblCaptionUser.TabIndex = 0;
            lblCaptionUser.Text = "User";
            lblCaptionUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Dock = DockStyle.Fill;
            lblCaptionCuisine.Location = new Point(30, 137);
            lblCaptionCuisine.Margin = new Padding(30, 0, 4, 0);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(214, 35);
            lblCaptionCuisine.TabIndex = 1;
            lblCaptionCuisine.Text = "Cuisine";
            lblCaptionCuisine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionNumCalories
            // 
            lblCaptionNumCalories.AutoSize = true;
            lblCaptionNumCalories.Dock = DockStyle.Fill;
            lblCaptionNumCalories.Location = new Point(30, 172);
            lblCaptionNumCalories.Margin = new Padding(30, 0, 4, 0);
            lblCaptionNumCalories.Name = "lblCaptionNumCalories";
            lblCaptionNumCalories.Size = new Size(214, 37);
            lblCaptionNumCalories.TabIndex = 3;
            lblCaptionNumCalories.Text = "Number Calories";
            lblCaptionNumCalories.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Dock = DockStyle.Fill;
            lblCaptionRecipeStatus.Location = new Point(30, 209);
            lblCaptionRecipeStatus.Margin = new Padding(30, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(214, 62);
            lblCaptionRecipeStatus.TabIndex = 7;
            lblCaptionRecipeStatus.Text = "Current Status";
            lblCaptionRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblStatus
            // 
            tblStatus.ColumnCount = 4;
            tblMain.SetColumnSpan(tblStatus, 2);
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.86754F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.637373F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2475433F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2475433F));
            tblStatus.Controls.Add(lblCaptionStatusDates, 0, 0);
            tblStatus.Controls.Add(lblCaptionDateDrafted, 1, 0);
            tblStatus.Controls.Add(lblDateDrafted, 1, 1);
            tblStatus.Controls.Add(lblCaptionDatePublished, 2, 0);
            tblStatus.Controls.Add(lblDatePublished, 2, 1);
            tblStatus.Controls.Add(lblCaptionDateArchived, 3, 0);
            tblStatus.Controls.Add(lblDateArchived, 3, 1);
            tblStatus.Dock = DockStyle.Fill;
            tblStatus.Location = new Point(3, 274);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.Size = new Size(823, 75);
            tblStatus.TabIndex = 27;
            // 
            // lblCaptionStatusDates
            // 
            lblCaptionStatusDates.AutoSize = true;
            lblCaptionStatusDates.Dock = DockStyle.Fill;
            lblCaptionStatusDates.Location = new Point(30, 0);
            lblCaptionStatusDates.Margin = new Padding(30, 0, 3, 0);
            lblCaptionStatusDates.Name = "lblCaptionStatusDates";
            tblStatus.SetRowSpan(lblCaptionStatusDates, 2);
            lblCaptionStatusDates.Size = new Size(212, 76);
            lblCaptionStatusDates.TabIndex = 0;
            lblCaptionStatusDates.Text = "Status Dates";
            lblCaptionStatusDates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Dock = DockStyle.Fill;
            lblCaptionDateDrafted.Location = new Point(249, 0);
            lblCaptionDateDrafted.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(202, 21);
            lblCaptionDateDrafted.TabIndex = 4;
            lblCaptionDateDrafted.Text = "Drafted";
            lblCaptionDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.BackColor = SystemColors.ControlDark;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(253, 29);
            lblDateDrafted.Margin = new Padding(8);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(194, 39);
            lblDateDrafted.TabIndex = 26;
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Dock = DockStyle.Fill;
            lblCaptionDatePublished.Location = new Point(459, 0);
            lblCaptionDatePublished.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(175, 21);
            lblCaptionDatePublished.TabIndex = 5;
            lblCaptionDatePublished.Text = "Published";
            lblCaptionDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.BackColor = SystemColors.ControlDark;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(463, 29);
            lblDatePublished.Margin = new Padding(8);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(167, 39);
            lblDatePublished.TabIndex = 21;
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Dock = DockStyle.Fill;
            lblCaptionDateArchived.Location = new Point(642, 0);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(177, 21);
            lblCaptionDateArchived.TabIndex = 6;
            lblCaptionDateArchived.Text = "Archived";
            lblCaptionDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.BackColor = SystemColors.ControlDark;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(646, 29);
            lblDateArchived.Margin = new Padding(8);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(169, 39);
            lblDateArchived.TabIndex = 22;
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Location = new Point(253, 69);
            txtRecipeName.Margin = new Padding(5, 4, 15, 4);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(561, 29);
            txtRecipeName.TabIndex = 11;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(253, 105);
            lstUserName.Margin = new Padding(5, 3, 15, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(561, 29);
            lstUserName.TabIndex = 24;
            // 
            // lstCuisineType
            // 
            lstCuisineType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(253, 140);
            lstCuisineType.Margin = new Padding(5, 3, 15, 3);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(561, 29);
            lstCuisineType.TabIndex = 25;
            // 
            // txtNumOfCalories
            // 
            txtNumOfCalories.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNumOfCalories.BorderStyle = BorderStyle.FixedSingle;
            txtNumOfCalories.Location = new Point(253, 176);
            txtNumOfCalories.Margin = new Padding(5, 4, 15, 4);
            txtNumOfCalories.Name = "txtNumOfCalories";
            txtNumOfCalories.Size = new Size(561, 29);
            txtNumOfCalories.TabIndex = 12;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.BackColor = SystemColors.ControlDark;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(256, 217);
            lblRecipeStatus.Margin = new Padding(8);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(565, 46);
            lblRecipeStatus.TabIndex = 23;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabRecipeInfo
            // 
            tblMain.SetColumnSpan(tabRecipeInfo, 2);
            tabRecipeInfo.Controls.Add(tabPageIngredients);
            tabRecipeInfo.Controls.Add(tabPageSteps);
            tabRecipeInfo.Dock = DockStyle.Fill;
            tabRecipeInfo.Location = new Point(10, 362);
            tabRecipeInfo.Margin = new Padding(10);
            tabRecipeInfo.Multiline = true;
            tabRecipeInfo.Name = "tabRecipeInfo";
            tabRecipeInfo.SelectedIndex = 0;
            tabRecipeInfo.Size = new Size(809, 529);
            tabRecipeInfo.TabIndex = 28;
            // 
            // tabPageIngredients
            // 
            tabPageIngredients.Controls.Add(tblIngredients);
            tabPageIngredients.Location = new Point(4, 30);
            tabPageIngredients.Name = "tabPageIngredients";
            tabPageIngredients.Padding = new Padding(3);
            tabPageIngredients.Size = new Size(801, 495);
            tabPageIngredients.TabIndex = 0;
            tabPageIngredients.Text = "Ingredients";
            tabPageIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.Controls.Add(btnSaveIngredient, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblIngredients.Size = new Size(795, 489);
            tblIngredients.TabIndex = 1;
            // 
            // btnSaveIngredient
            // 
            btnSaveIngredient.BackColor = SystemColors.AppWorkspace;
            btnSaveIngredient.Location = new Point(3, 3);
            btnSaveIngredient.Name = "btnSaveIngredient";
            btnSaveIngredient.Size = new Size(109, 40);
            btnSaveIngredient.TabIndex = 0;
            btnSaveIngredient.Text = "Save";
            btnSaveIngredient.UseVisualStyleBackColor = false;
            // 
            // gIngredients
            // 
            gIngredients.BackgroundColor = SystemColors.Control;
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 49);
            gIngredients.Name = "gIngredients";
            gIngredients.RowTemplate.Height = 25;
            gIngredients.Size = new Size(789, 437);
            gIngredients.TabIndex = 1;
            // 
            // tabPageSteps
            // 
            tabPageSteps.Controls.Add(tblSteps);
            tabPageSteps.Location = new Point(4, 30);
            tabPageSteps.Name = "tabPageSteps";
            tabPageSteps.Padding = new Padding(3);
            tabPageSteps.Size = new Size(801, 495);
            tabPageSteps.TabIndex = 1;
            tabPageSteps.Text = "Steps";
            tabPageSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.Controls.Add(btnStepsSave, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSteps.Size = new Size(795, 489);
            tblSteps.TabIndex = 2;
            // 
            // btnStepsSave
            // 
            btnStepsSave.BackColor = SystemColors.AppWorkspace;
            btnStepsSave.Location = new Point(3, 3);
            btnStepsSave.Name = "btnStepsSave";
            btnStepsSave.Size = new Size(109, 40);
            btnStepsSave.TabIndex = 0;
            btnStepsSave.Text = "Save";
            btnStepsSave.UseVisualStyleBackColor = false;
            // 
            // gSteps
            // 
            gSteps.BackgroundColor = SystemColors.Control;
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 49);
            gSteps.Name = "gSteps";
            gSteps.RowTemplate.Height = 25;
            gSteps.Size = new Size(789, 437);
            gSteps.TabIndex = 1;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 901);
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
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            tabRecipeInfo.ResumeLayout(false);
            tabPageIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tabPageSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
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
        private TableLayoutPanel tblControls;
        private Button btnSave;
        private Button btnDelete;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblRecipeStatus;
        private ComboBox lstUserName;
        private ComboBox lstCuisineType;
        private Label lblDateDrafted;
        private Button btnChangeStatus;
        private TableLayoutPanel tblStatus;
        private Label lblCaptionStatusDates;
        private TabControl tabRecipeInfo;
        private TabPage tabPageIngredients;
        private TabPage tabPageSteps;
        private Button btnSaveIngredient;
        private TableLayoutPanel tblIngredients;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnStepsSave;
        private DataGridView gSteps;
    }
}