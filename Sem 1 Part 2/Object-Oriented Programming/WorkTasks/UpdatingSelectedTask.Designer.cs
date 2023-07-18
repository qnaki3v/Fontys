namespace WorkTasks
{
    partial class UpdatingSelectedTask
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
            this.lbEmployeesToBeAssigned = new System.Windows.Forms.ListBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.rBtnCancelled = new System.Windows.Forms.RadioButton();
            this.rBtnBlocked = new System.Windows.Forms.RadioButton();
            this.rBtnCompleted = new System.Windows.Forms.RadioButton();
            this.rBtnInProgress = new System.Windows.Forms.RadioButton();
            this.rBtnOpen = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmployeesToBeAssigned
            // 
            this.lbEmployeesToBeAssigned.FormattingEnabled = true;
            this.lbEmployeesToBeAssigned.ItemHeight = 20;
            this.lbEmployeesToBeAssigned.Location = new System.Drawing.Point(12, 12);
            this.lbEmployeesToBeAssigned.Name = "lbEmployeesToBeAssigned";
            this.lbEmployeesToBeAssigned.Size = new System.Drawing.Size(337, 264);
            this.lbEmployeesToBeAssigned.TabIndex = 0;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(12, 282);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(337, 42);
            this.btnAssign.TabIndex = 1;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // rBtnCancelled
            // 
            this.rBtnCancelled.AutoSize = true;
            this.rBtnCancelled.Location = new System.Drawing.Point(378, 150);
            this.rBtnCancelled.Name = "rBtnCancelled";
            this.rBtnCancelled.Size = new System.Drawing.Size(95, 24);
            this.rBtnCancelled.TabIndex = 26;
            this.rBtnCancelled.TabStop = true;
            this.rBtnCancelled.Text = "Cancelled";
            this.rBtnCancelled.UseVisualStyleBackColor = true;
            // 
            // rBtnBlocked
            // 
            this.rBtnBlocked.AutoSize = true;
            this.rBtnBlocked.Location = new System.Drawing.Point(378, 191);
            this.rBtnBlocked.Name = "rBtnBlocked";
            this.rBtnBlocked.Size = new System.Drawing.Size(83, 24);
            this.rBtnBlocked.TabIndex = 25;
            this.rBtnBlocked.TabStop = true;
            this.rBtnBlocked.Text = "Blocked";
            this.rBtnBlocked.UseVisualStyleBackColor = true;
            // 
            // rBtnCompleted
            // 
            this.rBtnCompleted.AutoSize = true;
            this.rBtnCompleted.Location = new System.Drawing.Point(378, 231);
            this.rBtnCompleted.Name = "rBtnCompleted";
            this.rBtnCompleted.Size = new System.Drawing.Size(104, 24);
            this.rBtnCompleted.TabIndex = 24;
            this.rBtnCompleted.TabStop = true;
            this.rBtnCompleted.Text = "Completed";
            this.rBtnCompleted.UseVisualStyleBackColor = true;
            // 
            // rBtnInProgress
            // 
            this.rBtnInProgress.AutoSize = true;
            this.rBtnInProgress.Location = new System.Drawing.Point(378, 107);
            this.rBtnInProgress.Name = "rBtnInProgress";
            this.rBtnInProgress.Size = new System.Drawing.Size(102, 24);
            this.rBtnInProgress.TabIndex = 23;
            this.rBtnInProgress.TabStop = true;
            this.rBtnInProgress.Text = "In Progress";
            this.rBtnInProgress.UseVisualStyleBackColor = true;
            // 
            // rBtnOpen
            // 
            this.rBtnOpen.AutoSize = true;
            this.rBtnOpen.Location = new System.Drawing.Point(378, 63);
            this.rBtnOpen.Name = "rBtnOpen";
            this.rBtnOpen.Size = new System.Drawing.Size(66, 24);
            this.rBtnOpen.TabIndex = 22;
            this.rBtnOpen.TabStop = true;
            this.rBtnOpen.Text = "Open";
            this.rBtnOpen.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(380, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 20);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Status:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 42);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.Location = new System.Drawing.Point(12, 330);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(337, 42);
            this.btnUnassign.TabIndex = 29;
            this.btnUnassign.Text = "Unassign";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // UpdatingSelectedTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 398);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rBtnCancelled);
            this.Controls.Add(this.rBtnBlocked);
            this.Controls.Add(this.rBtnCompleted);
            this.Controls.Add(this.rBtnInProgress);
            this.Controls.Add(this.rBtnOpen);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lbEmployeesToBeAssigned);
            this.Name = "UpdatingSelectedTask";
            this.Text = "UpdatingSelectedTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbEmployeesToBeAssigned;
        private Button btnAssign;
        private RadioButton rBtnCancelled;
        private RadioButton rBtnBlocked;
        private RadioButton rBtnCompleted;
        private RadioButton rBtnInProgress;
        private RadioButton rBtnOpen;
        private Label lblStatus;
        private Button btnSave;
        private Button btnUnassign;
    }
}