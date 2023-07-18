namespace SalarySystem
{
    partial class EditEmployee
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
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbMonthlySalary = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSelectedEmployee = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(75, 140);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Developer",
            "Janitor",
            "Boss"});
            this.cbType.Location = new System.Drawing.Point(124, 140);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(125, 28);
            this.cbType.TabIndex = 14;
            // 
            // tbMonthlySalary
            // 
            this.tbMonthlySalary.Location = new System.Drawing.Point(124, 107);
            this.tbMonthlySalary.Name = "tbMonthlySalary";
            this.tbMonthlySalary.Size = new System.Drawing.Size(125, 27);
            this.tbMonthlySalary.TabIndex = 13;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(124, 74);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(125, 27);
            this.tbAge.TabIndex = 12;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(124, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 11;
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.AutoSize = true;
            this.lblMonthlySalary.Location = new System.Drawing.Point(12, 106);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.Size = new System.Drawing.Size(110, 20);
            this.lblMonthlySalary.TabIndex = 10;
            this.lblMonthlySalary.Text = "Monthly Salary:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(79, 77);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 20);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // lblSelectedEmployee
            // 
            this.lblSelectedEmployee.AutoSize = true;
            this.lblSelectedEmployee.Location = new System.Drawing.Point(12, 9);
            this.lblSelectedEmployee.Name = "lblSelectedEmployee";
            this.lblSelectedEmployee.Size = new System.Drawing.Size(139, 20);
            this.lblSelectedEmployee.TabIndex = 16;
            this.lblSelectedEmployee.Text = "Selected Employee:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(66, 192);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 47);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 251);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSelectedEmployee);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbMonthlySalary);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblMonthlySalary);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblType;
        private ComboBox cbType;
        private TextBox tbMonthlySalary;
        private TextBox tbAge;
        private TextBox tbName;
        private Label lblMonthlySalary;
        private Label lblAge;
        private Label lblName;
        private Label lblSelectedEmployee;
        private Button btnSubmit;
    }
}