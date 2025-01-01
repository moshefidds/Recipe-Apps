namespace RecipeWinForms
{
    partial class frmCloneARecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCloneARecipe));
            tblMain = new TableLayoutPanel();
            lstRecipe = new ComboBox();
            btnClone = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.Controls.Add(lstRecipe, 1, 1);
            tblMain.Controls.Add(btnClone, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.Size = new Size(950, 630);
            tblMain.TabIndex = 0;
            // 
            // lstRecipe
            // 
            lstRecipe.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstRecipe.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lstRecipe.FormattingEnabled = true;
            lstRecipe.Location = new Point(205, 200);
            lstRecipe.Margin = new Padding(15, 3, 15, 3);
            lstRecipe.Name = "lstRecipe";
            lstRecipe.Size = new Size(540, 40);
            lstRecipe.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Anchor = AnchorStyles.Right;
            btnClone.BackColor = SystemColors.AppWorkspace;
            btnClone.Location = new Point(600, 384);
            btnClone.Margin = new Padding(15);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(145, 50);
            btnClone.TabIndex = 1;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = false;
            // 
            // frmCloneARecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmCloneARecipe";
            Text = "Clone A Recipe";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstRecipe;
        private Button btnClone;
    }
}