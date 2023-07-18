namespace Week_11___Car_application
{
    partial class CarController
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
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lbGarage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(29, 114);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(210, 51);
            this.btnAccelerate.TabIndex = 0;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(258, 114);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(210, 51);
            this.btnBreak.TabIndex = 1;
            this.btnBreak.Text = "Use the breaks";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(29, 30);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(50, 20);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "label1";
            // 
            // lbGarage
            // 
            this.lbGarage.FormattingEnabled = true;
            this.lbGarage.ItemHeight = 20;
            this.lbGarage.Location = new System.Drawing.Point(494, 20);
            this.lbGarage.Name = "lbGarage";
            this.lbGarage.Size = new System.Drawing.Size(133, 184);
            this.lbGarage.TabIndex = 3;
            this.lbGarage.SelectedIndexChanged += new System.EventHandler(this.lbGarage_SelectedIndexChanged);
            // 
            // CarController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 223);
            this.Controls.Add(this.lbGarage);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnAccelerate);
            this.Name = "CarController";
            this.Text = "Car Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAccelerate;
        private Button btnBreak;
        private Label lblSpeed;
        private ListBox lbGarage;
    }
}