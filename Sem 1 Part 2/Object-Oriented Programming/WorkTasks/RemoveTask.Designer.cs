namespace WorkTasks
{
    partial class RemoveTask
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
            this.lbTasksToRemove = new System.Windows.Forms.ListBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTasksToRemove
            // 
            this.lbTasksToRemove.FormattingEnabled = true;
            this.lbTasksToRemove.ItemHeight = 20;
            this.lbTasksToRemove.Location = new System.Drawing.Point(12, 12);
            this.lbTasksToRemove.Name = "lbTasksToRemove";
            this.lbTasksToRemove.Size = new System.Drawing.Size(388, 304);
            this.lbTasksToRemove.TabIndex = 0;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(134, 322);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(132, 29);
            this.btnRemoveTask.TabIndex = 1;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // RemoveTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 373);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.lbTasksToRemove);
            this.Name = "RemoveTask";
            this.Text = "RemoveTask";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbTasksToRemove;
        private Button btnRemoveTask;
    }
}