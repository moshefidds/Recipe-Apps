namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataMaintenance));
            tblMain = new TableLayoutPanel();
            gData = new DataGridView();
            pnlOptionButtons = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisines = new RadioButton();
            optIngredients = new RadioButton();
            optMeasurements = new RadioButton();
            optCourses = new RadioButton();
            btnSave = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            pnlOptionButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.13431F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.86569F));
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(pnlOptionButtons, 0, 0);
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 1;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(251, 3);
            gData.Name = "gData";
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(775, 529);
            gData.TabIndex = 1;
            // 
            // pnlOptionButtons
            // 
            pnlOptionButtons.BackColor = SystemColors.ScrollBar;
            pnlOptionButtons.Controls.Add(optUsers);
            pnlOptionButtons.Controls.Add(optCuisines);
            pnlOptionButtons.Controls.Add(optIngredients);
            pnlOptionButtons.Controls.Add(optMeasurements);
            pnlOptionButtons.Controls.Add(optCourses);
            pnlOptionButtons.Dock = DockStyle.Fill;
            pnlOptionButtons.FlowDirection = FlowDirection.TopDown;
            pnlOptionButtons.Location = new Point(3, 3);
            pnlOptionButtons.Name = "pnlOptionButtons";
            tblMain.SetRowSpan(pnlOptionButtons, 2);
            pnlOptionButtons.Size = new Size(242, 624);
            pnlOptionButtons.TabIndex = 2;
            // 
            // optUsers
            // 
            optUsers.AutoSize = true;
            optUsers.Checked = true;
            optUsers.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optUsers.Location = new Point(3, 3);
            optUsers.Name = "optUsers";
            optUsers.Padding = new Padding(20, 50, 0, 0);
            optUsers.Size = new Size(101, 84);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            optCuisines.AutoSize = true;
            optCuisines.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optCuisines.Location = new Point(3, 93);
            optCuisines.Name = "optCuisines";
            optCuisines.Padding = new Padding(20, 25, 0, 0);
            optCuisines.Size = new Size(127, 59);
            optCuisines.TabIndex = 1;
            optCuisines.Text = "Cuisines";
            optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            optIngredients.AutoSize = true;
            optIngredients.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optIngredients.Location = new Point(3, 158);
            optIngredients.Name = "optIngredients";
            optIngredients.Padding = new Padding(20, 25, 0, 0);
            optIngredients.Size = new Size(155, 59);
            optIngredients.TabIndex = 2;
            optIngredients.Text = "Ingredients";
            optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            optMeasurements.AutoSize = true;
            optMeasurements.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optMeasurements.Location = new Point(3, 223);
            optMeasurements.Name = "optMeasurements";
            optMeasurements.Padding = new Padding(20, 25, 0, 0);
            optMeasurements.Size = new Size(188, 59);
            optMeasurements.TabIndex = 3;
            optMeasurements.Text = "Measurements";
            optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            optCourses.AutoSize = true;
            optCourses.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optCourses.Location = new Point(3, 288);
            optCourses.Name = "optCourses";
            optCourses.Padding = new Padding(20, 25, 0, 0);
            optCourses.Size = new Size(124, 59);
            optCourses.TabIndex = 4;
            optCourses.Text = "Courses";
            optCourses.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = SystemColors.AppWorkspace;
            btnSave.Location = new Point(837, 557);
            btnSave.Margin = new Padding(15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(177, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            pnlOptionButtons.ResumeLayout(false);
            pnlOptionButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gData;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
        private Button btnSave;
    }
}