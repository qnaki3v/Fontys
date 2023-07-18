namespace Week_12___Snackbar
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
            this.tcCustomerOwner = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbSnackTwo = new System.Windows.Forms.ComboBox();
            this.cbSnackThree = new System.Windows.Forms.ComboBox();
            this.lblSnackOne = new System.Windows.Forms.Label();
            this.lblSnackTwo = new System.Windows.Forms.Label();
            this.lblSnackThree = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cbSnackOne = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbSnacks = new System.Windows.Forms.ListBox();
            this.tcCustomerOwner.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCustomerOwner
            // 
            this.tcCustomerOwner.Controls.Add(this.tabPage1);
            this.tcCustomerOwner.Controls.Add(this.tabPage2);
            this.tcCustomerOwner.Location = new System.Drawing.Point(12, 12);
            this.tcCustomerOwner.Name = "tcCustomerOwner";
            this.tcCustomerOwner.SelectedIndex = 0;
            this.tcCustomerOwner.Size = new System.Drawing.Size(776, 426);
            this.tcCustomerOwner.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbSnackTwo);
            this.tabPage1.Controls.Add(this.cbSnackThree);
            this.tabPage1.Controls.Add(this.lblSnackOne);
            this.tabPage1.Controls.Add(this.lblSnackTwo);
            this.tabPage1.Controls.Add(this.lblSnackThree);
            this.tabPage1.Controls.Add(this.btnOrder);
            this.tabPage1.Controls.Add(this.cbSnackOne);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbSnackTwo
            // 
            this.cbSnackTwo.FormattingEnabled = true;
            this.cbSnackTwo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbSnackTwo.Location = new System.Drawing.Point(252, 159);
            this.cbSnackTwo.Name = "cbSnackTwo";
            this.cbSnackTwo.Size = new System.Drawing.Size(180, 28);
            this.cbSnackTwo.TabIndex = 5;
            // 
            // cbSnackThree
            // 
            this.cbSnackThree.FormattingEnabled = true;
            this.cbSnackThree.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbSnackThree.Location = new System.Drawing.Point(252, 189);
            this.cbSnackThree.Name = "cbSnackThree";
            this.cbSnackThree.Size = new System.Drawing.Size(180, 28);
            this.cbSnackThree.TabIndex = 6;
            // 
            // lblSnackOne
            // 
            this.lblSnackOne.AutoSize = true;
            this.lblSnackOne.Location = new System.Drawing.Point(165, 132);
            this.lblSnackOne.Name = "lblSnackOne";
            this.lblSnackOne.Size = new System.Drawing.Size(81, 20);
            this.lblSnackOne.TabIndex = 0;
            this.lblSnackOne.Text = "Snack One:";
            // 
            // lblSnackTwo
            // 
            this.lblSnackTwo.AutoSize = true;
            this.lblSnackTwo.Location = new System.Drawing.Point(165, 162);
            this.lblSnackTwo.Name = "lblSnackTwo";
            this.lblSnackTwo.Size = new System.Drawing.Size(81, 20);
            this.lblSnackTwo.TabIndex = 1;
            this.lblSnackTwo.Text = "Snack Two:";
            // 
            // lblSnackThree
            // 
            this.lblSnackThree.AutoSize = true;
            this.lblSnackThree.Location = new System.Drawing.Point(155, 194);
            this.lblSnackThree.Name = "lblSnackThree";
            this.lblSnackThree.Size = new System.Drawing.Size(91, 20);
            this.lblSnackThree.TabIndex = 2;
            this.lblSnackThree.Text = "Snack Three:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(252, 223);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(180, 39);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // cbSnackOne
            // 
            this.cbSnackOne.FormattingEnabled = true;
            this.cbSnackOne.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbSnackOne.Location = new System.Drawing.Point(252, 129);
            this.cbSnackOne.Name = "cbSnackOne";
            this.cbSnackOne.Size = new System.Drawing.Size(180, 28);
            this.cbSnackOne.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.lbSnacks);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Owner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(400, 295);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 29);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(328, 295);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 29);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(241, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lbSnacks
            // 
            this.lbSnacks.FormattingEnabled = true;
            this.lbSnacks.ItemHeight = 20;
            this.lbSnacks.Location = new System.Drawing.Point(241, 56);
            this.lbSnacks.Name = "lbSnacks";
            this.lbSnacks.Size = new System.Drawing.Size(236, 224);
            this.lbSnacks.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcCustomerOwner);
            this.Name = "Form1";
            this.Text = "MacSnack";
            this.tcCustomerOwner.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcCustomerOwner;
        private TabPage tabPage1;
        private ComboBox cbSnackTwo;
        private ComboBox cbSnackThree;
        private Label lblSnackOne;
        private Label lblSnackTwo;
        private Label lblSnackThree;
        private Button btnOrder;
        private ComboBox cbSnackOne;
        private TabPage tabPage2;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        private ListBox lbSnacks;
    }
}