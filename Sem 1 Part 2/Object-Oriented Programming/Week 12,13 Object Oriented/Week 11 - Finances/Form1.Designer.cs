namespace Week_11___Finances
{
    partial class Form1
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
            this.grpBoxExpenses = new System.Windows.Forms.GroupBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.dmnUDAmount = new System.Windows.Forms.DomainUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnShowExpenses = new System.Windows.Forms.Button();
            this.lblSameAmount = new System.Windows.Forms.Label();
            this.dmnUDSameAmount = new System.Windows.Forms.DomainUpDown();
            this.btnSameAmountExpenses = new System.Windows.Forms.Button();
            this.lbTransactionLog = new System.Windows.Forms.ListBox();
            this.grpBoxExpenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxExpenses
            // 
            this.grpBoxExpenses.Controls.Add(this.btnAddExpense);
            this.grpBoxExpenses.Controls.Add(this.dmnUDAmount);
            this.grpBoxExpenses.Controls.Add(this.tbName);
            this.grpBoxExpenses.Controls.Add(this.lblAmount);
            this.grpBoxExpenses.Controls.Add(this.lblName);
            this.grpBoxExpenses.Location = new System.Drawing.Point(12, 12);
            this.grpBoxExpenses.Name = "grpBoxExpenses";
            this.grpBoxExpenses.Size = new System.Drawing.Size(298, 154);
            this.grpBoxExpenses.TabIndex = 0;
            this.grpBoxExpenses.TabStop = false;
            this.grpBoxExpenses.Text = "Expense form";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(84, 87);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(201, 58);
            this.btnAddExpense.TabIndex = 1;
            this.btnAddExpense.Text = "Add expense to transaction log";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // dmnUDAmount
            // 
            this.dmnUDAmount.Items.Add("1");
            this.dmnUDAmount.Items.Add("5");
            this.dmnUDAmount.Items.Add("10");
            this.dmnUDAmount.Items.Add("15");
            this.dmnUDAmount.Location = new System.Drawing.Point(84, 54);
            this.dmnUDAmount.Name = "dmnUDAmount";
            this.dmnUDAmount.Size = new System.Drawing.Size(85, 27);
            this.dmnUDAmount.TabIndex = 1;
            this.dmnUDAmount.Text = "domainUpDown1";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(84, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(201, 27);
            this.tbName.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 56);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // btnShowExpenses
            // 
            this.btnShowExpenses.Location = new System.Drawing.Point(18, 176);
            this.btnShowExpenses.Name = "btnShowExpenses";
            this.btnShowExpenses.Size = new System.Drawing.Size(292, 29);
            this.btnShowExpenses.TabIndex = 1;
            this.btnShowExpenses.Text = "Show all expenses";
            this.btnShowExpenses.UseVisualStyleBackColor = true;
            this.btnShowExpenses.Click += new System.EventHandler(this.btnShowExpenses_Click);
            // 
            // lblSameAmount
            // 
            this.lblSameAmount.AutoSize = true;
            this.lblSameAmount.Location = new System.Drawing.Point(18, 301);
            this.lblSameAmount.Name = "lblSameAmount";
            this.lblSameAmount.Size = new System.Drawing.Size(65, 20);
            this.lblSameAmount.TabIndex = 2;
            this.lblSameAmount.Text = "Amount:";
            // 
            // dmnUDSameAmount
            // 
            this.dmnUDSameAmount.Items.Add("1");
            this.dmnUDSameAmount.Items.Add("5");
            this.dmnUDSameAmount.Items.Add("10");
            this.dmnUDSameAmount.Items.Add("15");
            this.dmnUDSameAmount.Location = new System.Drawing.Point(89, 299);
            this.dmnUDSameAmount.Name = "dmnUDSameAmount";
            this.dmnUDSameAmount.Size = new System.Drawing.Size(221, 27);
            this.dmnUDSameAmount.TabIndex = 2;
            this.dmnUDSameAmount.Text = "domainUpDown1";
            // 
            // btnSameAmountExpenses
            // 
            this.btnSameAmountExpenses.Location = new System.Drawing.Point(18, 332);
            this.btnSameAmountExpenses.Name = "btnSameAmountExpenses";
            this.btnSameAmountExpenses.Size = new System.Drawing.Size(292, 29);
            this.btnSameAmountExpenses.TabIndex = 3;
            this.btnSameAmountExpenses.Text = "Show all expenses with same amount";
            this.btnSameAmountExpenses.UseVisualStyleBackColor = true;
            this.btnSameAmountExpenses.Click += new System.EventHandler(this.btnSameAmountExpenses_Click);
            // 
            // lbTransactionLog
            // 
            this.lbTransactionLog.FormattingEnabled = true;
            this.lbTransactionLog.ItemHeight = 20;
            this.lbTransactionLog.Location = new System.Drawing.Point(336, 22);
            this.lbTransactionLog.Name = "lbTransactionLog";
            this.lbTransactionLog.Size = new System.Drawing.Size(279, 344);
            this.lbTransactionLog.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 378);
            this.Controls.Add(this.lbTransactionLog);
            this.Controls.Add(this.btnSameAmountExpenses);
            this.Controls.Add(this.dmnUDSameAmount);
            this.Controls.Add(this.lblSameAmount);
            this.Controls.Add(this.btnShowExpenses);
            this.Controls.Add(this.grpBoxExpenses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxExpenses.ResumeLayout(false);
            this.grpBoxExpenses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpBoxExpenses;
        private Button btnAddExpense;
        private DomainUpDown dmnUDAmount;
        private TextBox tbName;
        private Label lblAmount;
        private Label lblName;
        private Button btnShowExpenses;
        private Label lblSameAmount;
        private DomainUpDown dmnUDSameAmount;
        private Button btnSameAmountExpenses;
        private ListBox lbTransactionLog;
    }
}