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
            this.formulaBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formulaBtn
            // 
            this.formulaBtn.Enabled = false;
            this.formulaBtn.Location = new System.Drawing.Point(478, 13);
            this.formulaBtn.Name = "formulaBtn";
            this.formulaBtn.Size = new System.Drawing.Size(75, 23);
            this.formulaBtn.TabIndex = 20;
            this.formulaBtn.Text = "Formula";
            this.formulaBtn.UseVisualStyleBackColor = true;
            this.formulaBtn.Click += new System.EventHandler(this.formulaBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(376, 13);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 19;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 55);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(556, 247);
            this.textBox3.TabIndex = 18;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(275, 13);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 17;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Date";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "20010117";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 311);
            this.Controls.Add(this.formulaBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "New Formula";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formulaBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

