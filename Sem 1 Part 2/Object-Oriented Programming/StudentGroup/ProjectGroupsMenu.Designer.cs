namespace StudentGroup
{
    partial class ProjectGroupsMenu
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
            this.btnAddGroupProject = new System.Windows.Forms.Button();
            this.btnSelectProjectGroup = new System.Windows.Forms.Button();
            this.lbGroupProjects = new System.Windows.Forms.ListBox();
            this.btnDeleteProjectGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddGroupProject
            // 
            this.btnAddGroupProject.Location = new System.Drawing.Point(95, 402);
            this.btnAddGroupProject.Name = "btnAddGroupProject";
            this.btnAddGroupProject.Size = new System.Drawing.Size(152, 29);
            this.btnAddGroupProject.TabIndex = 5;
            this.btnAddGroupProject.Text = "Add Project Group";
            this.btnAddGroupProject.UseVisualStyleBackColor = true;
            this.btnAddGroupProject.Click += new System.EventHandler(this.btnAddGroupProject_Click);
            // 
            // btnSelectProjectGroup
            // 
            this.btnSelectProjectGroup.Location = new System.Drawing.Point(15, 402);
            this.btnSelectProjectGroup.Name = "btnSelectProjectGroup";
            this.btnSelectProjectGroup.Size = new System.Drawing.Size(74, 29);
            this.btnSelectProjectGroup.TabIndex = 4;
            this.btnSelectProjectGroup.Text = "Select";
            this.btnSelectProjectGroup.UseVisualStyleBackColor = true;
            this.btnSelectProjectGroup.Click += new System.EventHandler(this.btnSelectProjectGroup_Click);
            // 
            // lbGroupProjects
            // 
            this.lbGroupProjects.FormattingEnabled = true;
            this.lbGroupProjects.ItemHeight = 20;
            this.lbGroupProjects.Location = new System.Drawing.Point(15, 12);
            this.lbGroupProjects.Name = "lbGroupProjects";
            this.lbGroupProjects.Size = new System.Drawing.Size(395, 384);
            this.lbGroupProjects.TabIndex = 3;
            // 
            // btnDeleteProjectGroup
            // 
            this.btnDeleteProjectGroup.Location = new System.Drawing.Point(253, 402);
            this.btnDeleteProjectGroup.Name = "btnDeleteProjectGroup";
            this.btnDeleteProjectGroup.Size = new System.Drawing.Size(158, 29);
            this.btnDeleteProjectGroup.TabIndex = 6;
            this.btnDeleteProjectGroup.Text = "Delete Project Group";
            this.btnDeleteProjectGroup.UseVisualStyleBackColor = true;
            this.btnDeleteProjectGroup.Click += new System.EventHandler(this.btnDeleteProjectGroup_Click);
            // 
            // ProjectGroupsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 449);
            this.Controls.Add(this.btnDeleteProjectGroup);
            this.Controls.Add(this.btnAddGroupProject);
            this.Controls.Add(this.btnSelectProjectGroup);
            this.Controls.Add(this.lbGroupProjects);
            this.Name = "ProjectGroupsMenu";
            this.Text = "Project Group Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddGroupProject;
        private Button btnSelectProjectGroup;
        private ListBox lbGroupProjects;
        private Button btnDeleteProjectGroup;
    }
}