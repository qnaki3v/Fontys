namespace Calculator
{
    partial class Title
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
            this.lblNumOne = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblNumTwo = new System.Windows.Forms.Label();
            this.txtNumOne = new System.Windows.Forms.TextBox();
            this.btnRecallNumOne = new System.Windows.Forms.Button();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnSubtract = new System.Windows.Forms.RadioButton();
            this.rbtnMultiply = new System.Windows.Forms.RadioButton();
            this.rbtnDevide = new System.Windows.Forms.RadioButton();
            this.txtNumTwo = new System.Windows.Forms.TextBox();
            this.btnRecallNumTwo = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRecallResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumOne
            // 
            this.lblNumOne.AutoSize = true;
            this.lblNumOne.Location = new System.Drawing.Point(23, 30);
            this.lblNumOne.Name = "lblNumOne";
            this.lblNumOne.Size = new System.Drawing.Size(80, 20);
            this.lblNumOne.TabIndex = 0;
            this.lblNumOne.Text = "Number A:";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(23, 79);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(72, 20);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "Operator:";
            // 
            // lblNumTwo
            // 
            this.lblNumTwo.AutoSize = true;
            this.lblNumTwo.Location = new System.Drawing.Point(23, 206);
            this.lblNumTwo.Name = "lblNumTwo";
            this.lblNumTwo.Size = new System.Drawing.Size(79, 20);
            this.lblNumTwo.TabIndex = 2;
            this.lblNumTwo.Text = "Number B:";
            // 
            // txtNumOne
            // 
            this.txtNumOne.Location = new System.Drawing.Point(109, 27);
            this.txtNumOne.Name = "txtNumOne";
            this.txtNumOne.Size = new System.Drawing.Size(125, 27);
            this.txtNumOne.TabIndex = 3;
            // 
            // btnRecallNumOne
            // 
            this.btnRecallNumOne.Location = new System.Drawing.Point(253, 27);
            this.btnRecallNumOne.Name = "btnRecallNumOne";
            this.btnRecallNumOne.Size = new System.Drawing.Size(110, 27);
            this.btnRecallNumOne.TabIndex = 4;
            this.btnRecallNumOne.Text = "MR (Recall)";
            this.btnRecallNumOne.UseVisualStyleBackColor = true;
            this.btnRecallNumOne.Click += new System.EventHandler(this.btnRecallNumOne_Click);
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(109, 77);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(40, 24);
            this.rbtnAdd.TabIndex = 6;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "+";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtract
            // 
            this.rbtnSubtract.AutoSize = true;
            this.rbtnSubtract.Location = new System.Drawing.Point(109, 107);
            this.rbtnSubtract.Name = "rbtnSubtract";
            this.rbtnSubtract.Size = new System.Drawing.Size(36, 24);
            this.rbtnSubtract.TabIndex = 7;
            this.rbtnSubtract.TabStop = true;
            this.rbtnSubtract.Text = "-";
            this.rbtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiply
            // 
            this.rbtnMultiply.AutoSize = true;
            this.rbtnMultiply.Location = new System.Drawing.Point(109, 137);
            this.rbtnMultiply.Name = "rbtnMultiply";
            this.rbtnMultiply.Size = new System.Drawing.Size(36, 24);
            this.rbtnMultiply.TabIndex = 8;
            this.rbtnMultiply.TabStop = true;
            this.rbtnMultiply.Text = "*";
            this.rbtnMultiply.UseVisualStyleBackColor = true;
            // 
            // rbtnDevide
            // 
            this.rbtnDevide.AutoSize = true;
            this.rbtnDevide.Location = new System.Drawing.Point(109, 167);
            this.rbtnDevide.Name = "rbtnDevide";
            this.rbtnDevide.Size = new System.Drawing.Size(36, 24);
            this.rbtnDevide.TabIndex = 9;
            this.rbtnDevide.TabStop = true;
            this.rbtnDevide.Text = "/";
            this.rbtnDevide.UseVisualStyleBackColor = true;
            // 
            // txtNumTwo
            // 
            this.txtNumTwo.Location = new System.Drawing.Point(108, 203);
            this.txtNumTwo.Name = "txtNumTwo";
            this.txtNumTwo.Size = new System.Drawing.Size(125, 27);
            this.txtNumTwo.TabIndex = 10;
            // 
            // btnRecallNumTwo
            // 
            this.btnRecallNumTwo.Location = new System.Drawing.Point(253, 200);
            this.btnRecallNumTwo.Name = "btnRecallNumTwo";
            this.btnRecallNumTwo.Size = new System.Drawing.Size(110, 33);
            this.btnRecallNumTwo.TabIndex = 11;
            this.btnRecallNumTwo.Text = "MR (Recall)";
            this.btnRecallNumTwo.UseVisualStyleBackColor = true;
            this.btnRecallNumTwo.Click += new System.EventHandler(this.btnRecallNumTwo_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(23, 254);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(340, 29);
            this.btnEquals.TabIndex = 12;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(23, 289);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(224, 27);
            this.txtResult.TabIndex = 13;
            // 
            // btnRecallResult
            // 
            this.btnRecallResult.Location = new System.Drawing.Point(253, 289);
            this.btnRecallResult.Name = "btnRecallResult";
            this.btnRecallResult.Size = new System.Drawing.Size(110, 27);
            this.btnRecallResult.TabIndex = 14;
            this.btnRecallResult.Text = "MS (Save)";
            this.btnRecallResult.UseVisualStyleBackColor = true;
            this.btnRecallResult.Click += new System.EventHandler(this.btnRecallResult_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 338);
            this.Controls.Add(this.btnRecallResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnRecallNumTwo);
            this.Controls.Add(this.txtNumTwo);
            this.Controls.Add(this.rbtnDevide);
            this.Controls.Add(this.rbtnMultiply);
            this.Controls.Add(this.rbtnSubtract);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.btnRecallNumOne);
            this.Controls.Add(this.txtNumOne);
            this.Controls.Add(this.lblNumTwo);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblNumOne);
            this.Name = "Title";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumOne;
        private Label lblOperator;
        private Label lblNumTwo;
        private TextBox txtNumOne;
        private Button btnRecallNumOne;
        private RadioButton rbtnAdd;
        private RadioButton rbtnSubtract;
        private RadioButton rbtnMultiply;
        private RadioButton rbtnDevide;
        private TextBox txtNumTwo;
        private Button btnRecallNumTwo;
        private Button btnEquals;
        private TextBox txtResult;
        private Button btnRecallResult;
    }
}