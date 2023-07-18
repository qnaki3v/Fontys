namespace Week_12___Lottery
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
            this.gbLotterySettings = new System.Windows.Forms.GroupBox();
            this.tbNrOfWantedNums = new System.Windows.Forms.TextBox();
            this.lblNrOfWantedNums = new System.Windows.Forms.Label();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnNextNum = new System.Windows.Forms.Button();
            this.btnDrawAllNums = new System.Windows.Forms.Button();
            this.lbLotteries = new System.Windows.Forms.ListBox();
            this.gbLotterySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLotterySettings
            // 
            this.gbLotterySettings.Controls.Add(this.tbNrOfWantedNums);
            this.gbLotterySettings.Controls.Add(this.lblNrOfWantedNums);
            this.gbLotterySettings.Controls.Add(this.tbMaxValue);
            this.gbLotterySettings.Controls.Add(this.lblMaxValue);
            this.gbLotterySettings.Location = new System.Drawing.Point(28, 23);
            this.gbLotterySettings.Name = "gbLotterySettings";
            this.gbLotterySettings.Size = new System.Drawing.Size(304, 140);
            this.gbLotterySettings.TabIndex = 0;
            this.gbLotterySettings.TabStop = false;
            this.gbLotterySettings.Text = "Lottery settings";
            // 
            // tbNrOfWantedNums
            // 
            this.tbNrOfWantedNums.Location = new System.Drawing.Point(172, 82);
            this.tbNrOfWantedNums.Name = "tbNrOfWantedNums";
            this.tbNrOfWantedNums.Size = new System.Drawing.Size(125, 27);
            this.tbNrOfWantedNums.TabIndex = 1;
            // 
            // lblNrOfWantedNums
            // 
            this.lblNrOfWantedNums.AutoSize = true;
            this.lblNrOfWantedNums.Location = new System.Drawing.Point(6, 85);
            this.lblNrOfWantedNums.Name = "lblNrOfWantedNums";
            this.lblNrOfWantedNums.Size = new System.Drawing.Size(160, 20);
            this.lblNrOfWantedNums.TabIndex = 2;
            this.lblNrOfWantedNums.Text = "Nr of wanted numbers:";
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Location = new System.Drawing.Point(91, 33);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(125, 27);
            this.tbMaxValue.TabIndex = 1;
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(6, 36);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(79, 20);
            this.lblMaxValue.TabIndex = 1;
            this.lblMaxValue.Text = "Max value:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(28, 169);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(304, 29);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create lottery object";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnNextNum
            // 
            this.btnNextNum.Location = new System.Drawing.Point(28, 204);
            this.btnNextNum.Name = "btnNextNum";
            this.btnNextNum.Size = new System.Drawing.Size(304, 29);
            this.btnNextNum.TabIndex = 2;
            this.btnNextNum.Text = "Draw next number";
            this.btnNextNum.UseVisualStyleBackColor = true;
            this.btnNextNum.Click += new System.EventHandler(this.BtnNextNum_Click);
            // 
            // btnDrawAllNums
            // 
            this.btnDrawAllNums.Location = new System.Drawing.Point(28, 239);
            this.btnDrawAllNums.Name = "btnDrawAllNums";
            this.btnDrawAllNums.Size = new System.Drawing.Size(304, 29);
            this.btnDrawAllNums.TabIndex = 3;
            this.btnDrawAllNums.Text = "Draw all numbers at once";
            this.btnDrawAllNums.UseVisualStyleBackColor = true;
            this.btnDrawAllNums.Click += new System.EventHandler(this.BtnDrawAllNums_Click);
            // 
            // lbLotteries
            // 
            this.lbLotteries.FormattingEnabled = true;
            this.lbLotteries.ItemHeight = 20;
            this.lbLotteries.Location = new System.Drawing.Point(355, 23);
            this.lbLotteries.Name = "lbLotteries";
            this.lbLotteries.Size = new System.Drawing.Size(264, 384);
            this.lbLotteries.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 423);
            this.Controls.Add(this.lbLotteries);
            this.Controls.Add(this.btnDrawAllNums);
            this.Controls.Add(this.btnNextNum);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbLotterySettings);
            this.Name = "Form1";
            this.Text = "Lottery";
            this.gbLotterySettings.ResumeLayout(false);
            this.gbLotterySettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbLotterySettings;
        private TextBox tbNrOfWantedNums;
        private Label lblNrOfWantedNums;
        private TextBox tbMaxValue;
        private Label lblMaxValue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnCreate;
        private Button btnNextNum;
        private Button btnDrawAllNums;
        private ListBox lbLotteries;
    }
}