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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Date_Text = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.Time2_Text = new System.Windows.Forms.TextBox();
            this.Time1_Text = new System.Windows.Forms.TextBox();
            this.Check_Text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.column = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Formula1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Date_Text
            // 
            this.Date_Text.Location = new System.Drawing.Point(29, 29);
            this.Date_Text.Name = "Date_Text";
            this.Date_Text.Size = new System.Drawing.Size(106, 20);
            this.Date_Text.TabIndex = 1;
            this.Date_Text.Text = "20010105";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(29, 159);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(575, 549);
            this.log.TabIndex = 2;
            // 
            // Time2_Text
            // 
            this.Time2_Text.Location = new System.Drawing.Point(236, 29);
            this.Time2_Text.Name = "Time2_Text";
            this.Time2_Text.Size = new System.Drawing.Size(72, 20);
            this.Time2_Text.TabIndex = 3;
            this.Time2_Text.Text = "08:00";
            // 
            // Time1_Text
            // 
            this.Time1_Text.Location = new System.Drawing.Point(155, 29);
            this.Time1_Text.Name = "Time1_Text";
            this.Time1_Text.Size = new System.Drawing.Size(75, 20);
            this.Time1_Text.TabIndex = 4;
            this.Time1_Text.Text = "07:00";
            // 
            // Check_Text
            // 
            this.Check_Text.Location = new System.Drawing.Point(314, 29);
            this.Check_Text.Name = "Check_Text";
            this.Check_Text.Size = new System.Drawing.Size(20, 20);
            this.Check_Text.TabIndex = 5;
            this.Check_Text.Text = "5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(361, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // column
            // 
            this.column.Location = new System.Drawing.Point(150, 132);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(38, 20);
            this.column.TabIndex = 11;
            this.column.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "column";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(490, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(375, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "New Formula2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(375, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "New Formula3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 720);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.column);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Check_Text);
            this.Controls.Add(this.Time1_Text);
            this.Controls.Add(this.Time2_Text);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Date_Text);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "New Formula";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox column;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

