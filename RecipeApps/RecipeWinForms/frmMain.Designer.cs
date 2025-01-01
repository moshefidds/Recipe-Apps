namespace RecipeWinForms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuDashboard = new ToolStripMenuItem();
            mnuRecipes = new ToolStripMenuItem();
            mnuRecipesList = new ToolStripMenuItem();
            mnuNewRecipe = new ToolStripMenuItem();
            mnuCloneAREcipe = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealsList = new ToolStripMenuItem();
            mnuCookBooks = new ToolStripMenuItem();
            mnuCookbooksList = new ToolStripMenuItem();
            mnuNewCookbook = new ToolStripMenuItem();
            mnuAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            mnuTile = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipes, mnuMeals, mnuCookBooks, mnuDataMaintenance, mnuWindows });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1112, 29);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuDashboard });
            mnuFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 25);
            mnuFile.Text = "&File";
            // 
            // mnuDashboard
            // 
            mnuDashboard.Name = "mnuDashboard";
            mnuDashboard.Size = new Size(156, 26);
            mnuDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            mnuRecipes.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipesList, mnuNewRecipe, mnuCloneAREcipe });
            mnuRecipes.Name = "mnuRecipes";
            mnuRecipes.Size = new Size(75, 25);
            mnuRecipes.Text = "&Recipes";
            // 
            // mnuRecipesList
            // 
            mnuRecipesList.Name = "mnuRecipesList";
            mnuRecipesList.Size = new Size(182, 26);
            mnuRecipesList.Text = "List";
            // 
            // mnuNewRecipe
            // 
            mnuNewRecipe.Name = "mnuNewRecipe";
            mnuNewRecipe.Size = new Size(182, 26);
            mnuNewRecipe.Text = "New Recipe";
            // 
            // mnuCloneAREcipe
            // 
            mnuCloneAREcipe.Name = "mnuCloneAREcipe";
            mnuCloneAREcipe.Size = new Size(182, 26);
            mnuCloneAREcipe.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(63, 25);
            mnuMeals.Text = "&Meals";
            // 
            // mnuMealsList
            // 
            mnuMealsList.Name = "mnuMealsList";
            mnuMealsList.Size = new Size(104, 26);
            mnuMealsList.Text = "List";
            // 
            // mnuCookBooks
            // 
            mnuCookBooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbooksList, mnuNewCookbook, mnuAutoCreate });
            mnuCookBooks.Name = "mnuCookBooks";
            mnuCookBooks.Size = new Size(100, 25);
            mnuCookBooks.Text = "&Cookbooks";
            // 
            // mnuCookbooksList
            // 
            mnuCookbooksList.Name = "mnuCookbooksList";
            mnuCookbooksList.Size = new Size(187, 26);
            mnuCookbooksList.Text = "List";
            // 
            // mnuNewCookbook
            // 
            mnuNewCookbook.Name = "mnuNewCookbook";
            mnuNewCookbook.Size = new Size(187, 26);
            mnuNewCookbook.Text = "New Cookbook";
            // 
            // mnuAutoCreate
            // 
            mnuAutoCreate.Name = "mnuAutoCreate";
            mnuAutoCreate.Size = new Size(187, 26);
            mnuAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuEditData });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(147, 25);
            mnuDataMaintenance.Text = "&Data Maintenance";
            // 
            // mnuEditData
            // 
            mnuEditData.Name = "mnuEditData";
            mnuEditData.Size = new Size(142, 26);
            mnuEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuTile, mnuCascade });
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(87, 25);
            mnuWindows.Text = "&Windows";
            // 
            // mnuTile
            // 
            mnuTile.Name = "mnuTile";
            mnuTile.Size = new Size(137, 26);
            mnuTile.Text = "Tile";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(137, 26);
            mnuCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.Location = new Point(0, 29);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1112, 25);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1112, 985);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Hearty Hearth";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipesList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneAREcipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem mnuCookBooks;
        private ToolStripMenuItem mnuCookbooksList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuTile;
        private ToolStripMenuItem mnuCascade;
        private ToolStrip tsMain;
    }
}