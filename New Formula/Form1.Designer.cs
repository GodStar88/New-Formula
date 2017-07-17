namespace New_Formula
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Date_Text = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.Time2_Text = new System.Windows.Forms.TextBox();
            this.Time1_Text = new System.Windows.Forms.TextBox();
            this.Check_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Formula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Date_Text
            // 
            this.Date_Text.Location = new System.Drawing.Point(29, 28);
            this.Date_Text.Name = "Date_Text";
            this.Date_Text.Size = new System.Drawing.Size(106, 20);
            this.Date_Text.TabIndex = 1;
            this.Date_Text.Text = "20170111";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(29, 76);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(488, 360);
            this.log.TabIndex = 2;
            // 
            // Time2_Text
            // 
            this.Time2_Text.Location = new System.Drawing.Point(236, 28);
            this.Time2_Text.Name = "Time2_Text";
            this.Time2_Text.Size = new System.Drawing.Size(72, 20);
            this.Time2_Text.TabIndex = 3;
            this.Time2_Text.Text = "00:15";
            // 
            // Time1_Text
            // 
            this.Time1_Text.Location = new System.Drawing.Point(155, 28);
            this.Time1_Text.Name = "Time1_Text";
            this.Time1_Text.Size = new System.Drawing.Size(75, 20);
            this.Time1_Text.TabIndex = 4;
            this.Time1_Text.Text = "00:14";
            // 
            // Check_Text
            // 
            this.Check_Text.Location = new System.Drawing.Point(314, 28);
            this.Check_Text.Name = "Check_Text";
            this.Check_Text.Size = new System.Drawing.Size(20, 20);
            this.Check_Text.TabIndex = 5;
            this.Check_Text.Text = "9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 458);
            this.Controls.Add(this.Check_Text);
            this.Controls.Add(this.Time1_Text);
            this.Controls.Add(this.Time2_Text);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Date_Text);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "New Formula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Date_Text;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox Time2_Text;
        private System.Windows.Forms.TextBox Time1_Text;
        private System.Windows.Forms.TextBox Check_Text;
    }
}

