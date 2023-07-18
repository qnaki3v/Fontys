namespace WorkTasks
{
    partial class BrowseTasks
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSearchbar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rBtnOpen = new System.Windows.Forms.RadioButton();
            this.rBtnInProgress = new System.Windows.Forms.RadioButton();
            this.rBtnCompleted = new System.Windows.Forms.RadioButton();
            this.rBtnBlocked = new System.Windows.Forms.RadioButton();
            this.rBtnCancelled = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxHumanResources = new System.Windows.Forms.RadioButton();
            this.cbxResearchDevelopment = new System.Windows.Forms.RadioButton();
            this.cbxSupport = new System.Windows.Forms.RadioButton();
            this.cbxMarketing = new System.Windows.Forms.RadioButton();
            this.cbxSales = new System.Windows.Forms.RadioButton();
            this.lbxTasks = new System.Windows.Forms.ListBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gbDepartment = new System.Windows.Forms.GroupBox();
            this.gbStatus.SuspendLayout();
            this.gbDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchbar
            // 
            this.tbSearchbar.Location = new System.Drawing.Point(116, 21);
            this.tbSearchbar.Name = "tbSearchbar";
            this.tbSearchbar.Size = new System.Drawing.Size(284, 27);
            this.tbSearchbar.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(135, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rBtnOpen
            // 
            this.rBtnOpen.AutoSize = true;
            this.rBtnOpen.Location = new System.Drawing.Point(19, 57);
            this.rBtnOpen.Name = "rBtnOpen";
            this.rBtnOpen.Size = new System.Drawing.Size(66, 24);
            this.rBtnOpen.TabIndex = 2;
            this.rBtnOpen.TabStop = true;
            this.rBtnOpen.Text = "Open";
            this.rBtnOpen.UseVisualStyleBackColor = true;
            // 
            // rBtnInProgress
            // 
            this.rBtnInProgress.AutoSize = true;
            this.rBtnInProgress.Location = new System.Drawing.Point(19, 27);
            this.rBtnInProgress.Name = "rBtnInProgress";
            this.rBtnInProgress.Size = new System.Drawing.Size(102, 24);
            this.rBtnInProgress.TabIndex = 3;
            this.rBtnInProgress.TabStop = true;
            this.rBtnInProgress.Text = "In Progress";
            this.rBtnInProgress.UseVisualStyleBackColor = true;
            // 
            // rBtnCompleted
            // 
            this.rBtnCompleted.AutoSize = true;
            this.rBtnCompleted.Location = new System.Drawing.Point(127, 27);
            this.rBtnCompleted.Name = "rBtnCompleted";
            this.rBtnCompleted.Size = new System.Drawing.Size(104, 24);
            this.rBtnCompleted.TabIndex = 4;
            this.rBtnCompleted.TabStop = true;
            this.rBtnCompleted.Text = "Completed";
            this.rBtnCompleted.UseVisualStyleBackColor = true;
            // 
            // rBtnBlocked
            // 
            this.rBtnBlocked.AutoSize = true;
            this.rBtnBlocked.Location = new System.Drawing.Point(91, 57);
            this.rBtnBlocked.Name = "rBtnBlocked";
            this.rBtnBlocked.Size = new System.Drawing.Size(83, 24);
            this.rBtnBlocked.TabIndex = 5;
            this.rBtnBlocked.TabStop = true;
            this.rBtnBlocked.Text = "Blocked";
            this.rBtnBlocked.UseVisualStyleBackColor = true;
            // 
            // rBtnCancelled
            // 
            this.rBtnCancelled.AutoSize = true;
            this.rBtnCancelled.Location = new System.Drawing.Point(180, 57);
            this.rBtnCancelled.Name = "rBtnCancelled";
            this.rBtnCancelled.Size = new System.Drawing.Size(95, 24);
            this.rBtnCancelled.TabIndex = 6;
            this.rBtnCancelled.TabStop = true;
            this.rBtnCancelled.Text = "Cancelled";
            this.rBtnCancelled.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(64, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            // 
            // cbxHumanResources
            // 
            this.cbxHumanResources.AutoSize = true;
            this.cbxHumanResources.Location = new System.Drawing.Point(21, 60);
            this.cbxHumanResources.Name = "cbxHumanResources";
            this.cbxHumanResources.Size = new System.Drawing.Size(148, 24);
            this.cbxHumanResources.TabIndex = 11;
            this.cbxHumanResources.Text = "Human Resources";
            this.cbxHumanResources.UseVisualStyleBackColor = true;
            // 
            // cbxResearchDevelopment
            // 
            this.cbxResearchDevelopment.AutoSize = true;
            this.cbxResearchDevelopment.Location = new System.Drawing.Point(21, 30);
            this.cbxResearchDevelopment.Name = "cbxResearchDevelopment";
            this.cbxResearchDevelopment.Size = new System.Drawing.Size(212, 24);
            this.cbxResearchDevelopment.TabIndex = 12;
            this.cbxResearchDevelopment.Text = "Research and Development";
            this.cbxResearchDevelopment.UseVisualStyleBackColor = true;
            // 
            // cbxSupport
            // 
            this.cbxSupport.AutoSize = true;
            this.cbxSupport.Location = new System.Drawing.Point(177, 60);
            this.cbxSupport.Name = "cbxSupport";
            this.cbxSupport.Size = new System.Drawing.Size(83, 24);
            this.cbxSupport.TabIndex = 13;
            this.cbxSupport.Text = "Support";
            this.cbxSupport.UseVisualStyleBackColor = true;
            // 
            // cbxMarketing
            // 
            this.cbxMarketing.AutoSize = true;
            this.cbxMarketing.Location = new System.Drawing.Point(240, 30);
            this.cbxMarketing.Name = "cbxMarketing";
            this.cbxMarketing.Size = new System.Drawing.Size(97, 24);
            this.cbxMarketing.TabIndex = 14;
            this.cbxMarketing.Text = "Marketing";
            this.cbxMarketing.UseVisualStyleBackColor = true;
            // 
            // cbxSales
            // 
            this.cbxSales.AutoSize = true;
            this.cbxSales.Location = new System.Drawing.Point(267, 60);
            this.cbxSales.Name = "cbxSales";
            this.cbxSales.Size = new System.Drawing.Size(64, 24);
            this.cbxSales.TabIndex = 15;
            this.cbxSales.Text = "Sales";
            this.cbxSales.UseVisualStyleBackColor = true;
            // 
            // lbxTasks
            // 
            this.lbxTasks.FormattingEnabled = true;
            this.lbxTasks.ItemHeight = 20;
            this.lbxTasks.Location = new System.Drawing.Point(444, 12);
            this.lbxTasks.Name = "lbxTasks";
            this.lbxTasks.Size = new System.Drawing.Size(489, 324);
            this.lbxTasks.TabIndex = 16;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rBtnCompleted);
            this.gbStatus.Controls.Add(this.rBtnOpen);
            this.gbStatus.Controls.Add(this.rBtnInProgress);
            this.gbStatus.Controls.Add(this.rBtnBlocked);
            this.gbStatus.Controls.Add(this.rBtnCancelled);
            this.gbStatus.Location = new System.Drawing.Point(64, 58);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(292, 94);
            this.gbStatus.TabIndex = 17;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // gbDepartment
            // 
            this.gbDepartment.Controls.Add(this.cbxResearchDevelopment);
            this.gbDepartment.Controls.Add(this.cbxHumanResources);
            this.gbDepartment.Controls.Add(this.cbxSupport);
            this.gbDepartment.Controls.Add(this.cbxSales);
            this.gbDepartment.Controls.Add(this.cbxMarketing);
            this.gbDepartment.Location = new System.Drawing.Point(45, 168);
            this.gbDepartment.Name = "gbDepartment";
            this.gbDepartment.Size = new System.Drawing.Size(355, 96);
            this.gbDepartment.TabIndex = 18;
            this.gbDepartment.TabStop = false;
            this.gbDepartment.Text = "Department";
            // 
            // BrowseTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 371);
            this.Controls.Add(this.gbDepartment);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.lbxTasks);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchbar);
            this.Name = "BrowseTasks";
            this.Text = "Browse Tasks";
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbDepartment.ResumeLayout(false);
            this.gbDepartment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbSearchbar;
        private Button btnSearch;
        private RadioButton rBtnOpen;
        private RadioButton rBtnInProgress;
        private RadioButton rBtnCompleted;
        private RadioButton rBtnBlocked;
        private RadioButton rBtnCancelled;
        private Label lblTitle;
        private RadioButton cbxHumanResources;
        private RadioButton cbxResearchDevelopment;
        private RadioButton cbxSupport;
        private RadioButton cbxMarketing;
        private RadioButton cbxSales;
        private ListBox lbxTasks;
        private GroupBox gbStatus;
        private GroupBox gbDepartment;
    }
}