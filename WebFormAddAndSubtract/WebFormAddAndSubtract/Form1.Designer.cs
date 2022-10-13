
namespace WebFormAddAndSubtract
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SubBtn = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter a number";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Enter a number";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(258, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Result";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(258, 228);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 29);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // SubBtn
            // 
            this.SubBtn.Location = new System.Drawing.Point(358, 228);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(94, 29);
            this.SubBtn.TabIndex = 4;
            this.SubBtn.Text = "Subtract";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(469, 228);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(94, 29);
            this.reset.TabIndex = 5;
            this.reset.Text = "Clear";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button reset;
    }
}

