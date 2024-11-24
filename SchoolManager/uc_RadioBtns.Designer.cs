namespace SchoolManager
{
    partial class uc_RadioBtns
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radBtn1 = new System.Windows.Forms.RadioButton();
            this.radBtn2 = new System.Windows.Forms.RadioButton();
            this.radBtn3 = new System.Windows.Forms.RadioButton();
            this.radBtn4 = new System.Windows.Forms.RadioButton();
            this.radBtn5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radBtn1
            // 
            this.radBtn1.AutoSize = true;
            this.radBtn1.Location = new System.Drawing.Point(6, 3);
            this.radBtn1.Name = "radBtn1";
            this.radBtn1.Size = new System.Drawing.Size(31, 17);
            this.radBtn1.TabIndex = 0;
            this.radBtn1.TabStop = true;
            this.radBtn1.Text = "1";
            this.radBtn1.UseVisualStyleBackColor = true;
            this.radBtn1.CheckedChanged += new System.EventHandler(this.radBtn1_CheckedChanged);
            // 
            // radBtn2
            // 
            this.radBtn2.AutoSize = true;
            this.radBtn2.Location = new System.Drawing.Point(43, 3);
            this.radBtn2.Name = "radBtn2";
            this.radBtn2.Size = new System.Drawing.Size(31, 17);
            this.radBtn2.TabIndex = 1;
            this.radBtn2.TabStop = true;
            this.radBtn2.Text = "2";
            this.radBtn2.UseVisualStyleBackColor = true;
            this.radBtn2.CheckedChanged += new System.EventHandler(this.radBtn2_CheckedChanged);
            // 
            // radBtn3
            // 
            this.radBtn3.AutoSize = true;
            this.radBtn3.Location = new System.Drawing.Point(80, 3);
            this.radBtn3.Name = "radBtn3";
            this.radBtn3.Size = new System.Drawing.Size(31, 17);
            this.radBtn3.TabIndex = 2;
            this.radBtn3.TabStop = true;
            this.radBtn3.Text = "3";
            this.radBtn3.UseVisualStyleBackColor = true;
            this.radBtn3.CheckedChanged += new System.EventHandler(this.radBtn3_CheckedChanged);
            // 
            // radBtn4
            // 
            this.radBtn4.AutoSize = true;
            this.radBtn4.Location = new System.Drawing.Point(117, 3);
            this.radBtn4.Name = "radBtn4";
            this.radBtn4.Size = new System.Drawing.Size(31, 17);
            this.radBtn4.TabIndex = 3;
            this.radBtn4.TabStop = true;
            this.radBtn4.Text = "4";
            this.radBtn4.UseVisualStyleBackColor = true;
            this.radBtn4.CheckedChanged += new System.EventHandler(this.radBtn4_CheckedChanged);
            // 
            // radBtn5
            // 
            this.radBtn5.AutoSize = true;
            this.radBtn5.Location = new System.Drawing.Point(154, 3);
            this.radBtn5.Name = "radBtn5";
            this.radBtn5.Size = new System.Drawing.Size(31, 17);
            this.radBtn5.TabIndex = 4;
            this.radBtn5.TabStop = true;
            this.radBtn5.Text = "5";
            this.radBtn5.UseVisualStyleBackColor = true;
            this.radBtn5.CheckedChanged += new System.EventHandler(this.radBtn5_CheckedChanged);
            // 
            // uc_RadioBtns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radBtn5);
            this.Controls.Add(this.radBtn4);
            this.Controls.Add(this.radBtn3);
            this.Controls.Add(this.radBtn2);
            this.Controls.Add(this.radBtn1);
            this.Name = "uc_RadioBtns";
            this.Size = new System.Drawing.Size(185, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtn1;
        private System.Windows.Forms.RadioButton radBtn2;
        private System.Windows.Forms.RadioButton radBtn3;
        private System.Windows.Forms.RadioButton radBtn4;
        private System.Windows.Forms.RadioButton radBtn5;
    }
}
