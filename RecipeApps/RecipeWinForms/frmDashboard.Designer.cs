namespace RecipeWinForms
{
    partial class frmDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            tblMain = new TableLayoutPanel();
            lblHeader = new Label();
            lblDesc = new Label();
            gDashboard = new DataGridView();
            tblButtons = new TableLayoutPanel();
            btnMealList = new Button();
            btnCookbookList = new Button();
            btnRecipeList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDashboard).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblHeader, 0, 0);
            tblMain.Controls.Add(lblDesc, 0, 1);
            tblMain.Controls.Add(gDashboard, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblMain.ImeMode = ImeMode.Off;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(1190, 641);
            tblMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(4, 4);
            lblHeader.Margin = new Padding(4);
            lblHeader.Name = "lblHeader";
            lblHeader.Padding = new Padding(0, 30, 0, 0);
            lblHeader.Size = new Size(1182, 70);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hearty Hearth Desktop App";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Dock = DockStyle.Fill;
            lblDesc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.Location = new Point(4, 78);
            lblDesc.Margin = new Padding(4, 0, 4, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Padding = new Padding(300, 50, 300, 50);
            lblDesc.RightToLeft = RightToLeft.No;
            lblDesc.Size = new Size(1182, 160);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and cookbooks. you can also...";
            lblDesc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gDashboard
            // 
            gDashboard.AllowUserToAddRows = false;
            gDashboard.AllowUserToDeleteRows = false;
            gDashboard.AllowUserToResizeColumns = false;
            gDashboard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gDashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gDashboard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gDashboard.BackgroundColor = SystemColors.ButtonHighlight;
            gDashboard.CausesValidation = false;
            gDashboard.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(0, 20, 0, 20);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDashboard.Cursor = Cursors.No;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 20, 0, 20);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gDashboard.DefaultCellStyle = dataGridViewCellStyle3;
            gDashboard.EditMode = DataGridViewEditMode.EditOnEnter;
            gDashboard.Enabled = false;
            gDashboard.ImeMode = ImeMode.Disable;
            gDashboard.Location = new Point(300, 248);
            gDashboard.Margin = new Padding(300, 10, 300, 10);
            gDashboard.MultiSelect = false;
            gDashboard.Name = "gDashboard";
            gDashboard.ReadOnly = true;
            dataGridViewCellStyle4.Padding = new Padding(0, 17, 0, 17);
            gDashboard.RowsDefaultCellStyle = dataGridViewCellStyle4;
            gDashboard.RowTemplate.Height = 25;
            gDashboard.ScrollBars = ScrollBars.None;
            gDashboard.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gDashboard.ShowCellErrors = false;
            gDashboard.ShowCellToolTips = false;
            gDashboard.ShowEditingIcon = false;
            gDashboard.ShowRowErrors = false;
            gDashboard.Size = new Size(590, 267);
            gDashboard.TabIndex = 10;
            gDashboard.TabStop = false;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Dock = DockStyle.Top;
            tblButtons.Location = new Point(3, 528);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(1184, 87);
            tblButtons.TabIndex = 3;
            // 
            // btnMealList
            // 
            btnMealList.BackColor = SystemColors.ActiveBorder;
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Location = new Point(507, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(170, 81);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            btnCookbookList.BackColor = SystemColors.ActiveBorder;
            btnCookbookList.Dock = DockStyle.Left;
            btnCookbookList.Location = new Point(710, 3);
            btnCookbookList.Margin = new Padding(30, 3, 3, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(170, 81);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // btnRecipeList
            // 
            btnRecipeList.BackColor = SystemColors.ActiveBorder;
            btnRecipeList.Dock = DockStyle.Right;
            btnRecipeList.Location = new Point(304, 3);
            btnRecipeList.Margin = new Padding(3, 3, 30, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(170, 81);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 641);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDashboard).EndInit();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblDesc;
        private TableLayoutPanel tblButtons;
        private Button btnMealList;
        private Button btnCookbookList;
        private Button btnRecipeList;
        protected DataGridView gDashboard;
    }
}