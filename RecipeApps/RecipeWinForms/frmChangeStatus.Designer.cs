namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeStatus));
            tblMain = new TableLayoutPanel();
            tblButtons = new TableLayoutPanel();
            btnPublish = new Button();
            btnArchive = new Button();
            btnDraft = new Button();
            lblRecipeName = new Label();
            tblStatusCaption = new TableLayoutPanel();
            lblStatusCaption = new Label();
            lblRecipeStatus = new Label();
            tblStatus = new TableLayoutPanel();
            lblCaptionStatusDates = new Label();
            lblCaptionDateDrafted = new Label();
            lblDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblDateArchived = new Label();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblStatusCaption.SuspendLayout();
            tblStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(tblStatusCaption, 0, 1);
            tblMain.Controls.Add(tblStatus, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tblMain.Size = new Size(1080, 757);
            tblMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            tblButtons.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.Controls.Add(btnPublish, 1, 0);
            tblButtons.Controls.Add(btnArchive, 2, 0);
            tblButtons.Controls.Add(btnDraft, 0, 0);
            tblButtons.Location = new Point(3, 599);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(1074, 87);
            tblButtons.TabIndex = 29;
            // 
            // btnPublish
            // 
            btnPublish.BackColor = SystemColors.ActiveBorder;
            btnPublish.Dock = DockStyle.Fill;
            btnPublish.Location = new Point(452, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(170, 81);
            btnPublish.TabIndex = 1;
            btnPublish.Tag = "";
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = false;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = SystemColors.ActiveBorder;
            btnArchive.Dock = DockStyle.Left;
            btnArchive.Location = new Point(655, 3);
            btnArchive.Margin = new Padding(30, 3, 3, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(170, 81);
            btnArchive.TabIndex = 2;
            btnArchive.Tag = "";
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = false;
            // 
            // btnDraft
            // 
            btnDraft.BackColor = SystemColors.ActiveBorder;
            btnDraft.Dock = DockStyle.Right;
            btnDraft.Location = new Point(249, 3);
            btnDraft.Margin = new Padding(3, 3, 30, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(170, 81);
            btnDraft.TabIndex = 0;
            btnDraft.Tag = "";
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = false;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(1074, 151);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusCaption
            // 
            tblStatusCaption.ColumnCount = 2;
            tblStatusCaption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatusCaption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatusCaption.Controls.Add(lblStatusCaption, 0, 0);
            tblStatusCaption.Controls.Add(lblRecipeStatus, 1, 0);
            tblStatusCaption.Dock = DockStyle.Fill;
            tblStatusCaption.Location = new Point(3, 154);
            tblStatusCaption.Name = "tblStatusCaption";
            tblStatusCaption.RowCount = 1;
            tblStatusCaption.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusCaption.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblStatusCaption.Size = new Size(1074, 145);
            tblStatusCaption.TabIndex = 2;
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.Anchor = AnchorStyles.Right;
            lblStatusCaption.BackColor = SystemColors.Control;
            lblStatusCaption.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusCaption.Location = new Point(222, 35);
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new Size(312, 75);
            lblStatusCaption.TabIndex = 2;
            lblStatusCaption.Text = "Current Status:";
            lblStatusCaption.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Left;
            lblRecipeStatus.BackColor = SystemColors.Control;
            lblRecipeStatus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeStatus.Location = new Point(540, 35);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(312, 75);
            lblRecipeStatus.TabIndex = 1;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
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
            tblStatus.Location = new Point(3, 305);
            tblStatus.Name = "tblStatus";
            tblStatus.Padding = new Padding(0, 0, 200, 50);
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblStatus.Size = new Size(1074, 221);
            tblStatus.TabIndex = 28;
            // 
            // lblCaptionStatusDates
            // 
            lblCaptionStatusDates.AutoSize = true;
            lblCaptionStatusDates.Dock = DockStyle.Fill;
            lblCaptionStatusDates.Location = new Point(30, 0);
            lblCaptionStatusDates.Margin = new Padding(30, 0, 3, 0);
            lblCaptionStatusDates.Name = "lblCaptionStatusDates";
            tblStatus.SetRowSpan(lblCaptionStatusDates, 2);
            lblCaptionStatusDates.Size = new Size(228, 171);
            lblCaptionStatusDates.TabIndex = 0;
            lblCaptionStatusDates.Text = "Status Dates";
            lblCaptionStatusDates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Dock = DockStyle.Fill;
            lblCaptionDateDrafted.Location = new Point(265, 0);
            lblCaptionDateDrafted.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(216, 68);
            lblCaptionDateDrafted.TabIndex = 4;
            lblCaptionDateDrafted.Text = "Drafted";
            lblCaptionDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.BackColor = SystemColors.ControlDark;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(269, 76);
            lblDateDrafted.Margin = new Padding(8);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(208, 87);
            lblDateDrafted.TabIndex = 26;
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Dock = DockStyle.Fill;
            lblCaptionDatePublished.Location = new Point(489, 0);
            lblCaptionDatePublished.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(186, 68);
            lblCaptionDatePublished.TabIndex = 5;
            lblCaptionDatePublished.Text = "Published";
            lblCaptionDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.BackColor = SystemColors.ControlDark;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(493, 76);
            lblDatePublished.Margin = new Padding(8);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(178, 87);
            lblDatePublished.TabIndex = 21;
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Dock = DockStyle.Fill;
            lblCaptionDateArchived.Location = new Point(683, 0);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(187, 68);
            lblCaptionDateArchived.TabIndex = 6;
            lblCaptionDateArchived.Text = "Archived";
            lblCaptionDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.BackColor = SystemColors.ControlDark;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(687, 76);
            lblDateArchived.Margin = new Padding(8);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(179, 87);
            lblDateArchived.TabIndex = 22;
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 757);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmChangeStatus";
            Text = "Recipe - Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblStatusCaption.ResumeLayout(false);
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblStatusCaption;
        private Label lblStatusCaption;
        private TableLayoutPanel tblStatus;
        private Label lblCaptionStatusDates;
        private Label lblCaptionDateDrafted;
        private Label lblDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblDateArchived;
        private TableLayoutPanel tblButtons;
        private Button btnPublish;
        private Button btnArchive;
        private Button btnDraft;
    }
}