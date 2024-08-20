namespace RecipeWinForms
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            tblMain = new TableLayoutPanel();
            tblSearch = new TableLayoutPanel();
            lblCaptionRecipe = new Label();
            txtRecipe = new TextBox();
            btnSearch = new Button();
            gRecipe = new DataGridView();
            btnNew = new Button();
            tblMain.SuspendLayout();
            tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(tblSearch, 0, 0);
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tblMain.Size = new Size(531, 568);
            tblMain.TabIndex = 0;
            // 
            // tblSearch
            // 
            tblSearch.ColumnCount = 4;
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.Controls.Add(lblCaptionRecipe, 0, 0);
            tblSearch.Controls.Add(txtRecipe, 1, 0);
            tblSearch.Controls.Add(btnNew, 3, 0);
            tblSearch.Controls.Add(btnSearch, 2, 0);
            tblSearch.Location = new Point(3, 3);
            tblSearch.Name = "tblSearch";
            tblSearch.RowCount = 1;
            tblSearch.RowStyles.Add(new RowStyle());
            tblSearch.Size = new Size(345, 50);
            tblSearch.TabIndex = 0;
            // 
            // lblCaptionRecipe
            // 
            lblCaptionRecipe.Anchor = AnchorStyles.Left;
            lblCaptionRecipe.AutoSize = true;
            lblCaptionRecipe.Location = new Point(3, 14);
            lblCaptionRecipe.Name = "lblCaptionRecipe";
            lblCaptionRecipe.Size = new Size(59, 21);
            lblCaptionRecipe.TabIndex = 0;
            lblCaptionRecipe.Text = "Recipe:";
            // 
            // txtRecipe
            // 
            txtRecipe.Anchor = AnchorStyles.Left;
            txtRecipe.BorderStyle = BorderStyle.FixedSingle;
            txtRecipe.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipe.Location = new Point(68, 10);
            txtRecipe.Name = "txtRecipe";
            txtRecipe.Size = new Size(100, 29);
            txtRecipe.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(174, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 38);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 59);
            gRecipe.Name = "gRecipe";
            gRecipe.RowTemplate.Height = 25;
            gRecipe.Size = new Size(525, 506);
            gRecipe.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Left;
            btnNew.AutoSize = true;
            btnNew.Location = new Point(257, 6);
            btnNew.Margin = new Padding(5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 37);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 568);
            Controls.Add(tblMain);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "frmSearch";
            Text = "Recipe Search";
            tblMain.ResumeLayout(false);
            tblSearch.ResumeLayout(false);
            tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblSearch;
        private Label lblCaptionRecipe;
        private TextBox txtRecipe;
        private Button btnSearch;
        private DataGridView gRecipe;
        private Button btnNew;
    }
}