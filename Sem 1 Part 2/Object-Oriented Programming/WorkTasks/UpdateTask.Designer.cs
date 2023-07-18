namespace WorkTasks
{
    partial class UpdateTask
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
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.lbTasksToUpdate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(116, 331);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(132, 29);
            this.btnUpdateTask.TabIndex = 3;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // lbTasksToUpdate
            // 
            this.lbTasksToUpdate.FormattingEnabled = true;
            this.lbTasksToUpdate.ItemHeight = 20;
            this.lbTasksToUpdate.Location = new System.Drawing.Point(12, 12);
            this.lbTasksToUpdate.Name = "lbTasksToUpdate";
            this.lbTasksToUpdate.Size = new System.Drawing.Size(388, 304);
            this.lbTasksToUpdate.TabIndex = 2;
            // 
            // UpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 374);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.lbTasksToUpdate);
            this.Name = "UpdateTask";
            this.Text = "UpdateTask";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUpdateTask;
        private ListBox lbTasksToUpdate;
    }
}