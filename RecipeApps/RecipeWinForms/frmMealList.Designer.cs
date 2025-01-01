namespace RecipeWinForms
{
    partial class frmMealList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMealList));
            gMealList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gMealList).BeginInit();
            SuspendLayout();
            // 
            // gMealList
            // 
            gMealList.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gMealList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gMealList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gMealList.Dock = DockStyle.Fill;
            gMealList.Location = new Point(0, 0);
            gMealList.Margin = new Padding(15);
            gMealList.Name = "gMealList";
            gMealList.RowTemplate.Height = 25;
            gMealList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gMealList.Size = new Size(1029, 630);
            gMealList.TabIndex = 2;
            // 
            // frmMealList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(gMealList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmMealList";
            Text = "Meal List";
            ((System.ComponentModel.ISupportInitialize)gMealList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gMealList;
    }
}