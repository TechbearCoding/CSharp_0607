
namespace Day17_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnDemo = new System.Windows.Forms.Button();
            this.EditNumber1 = new System.Windows.Forms.TextBox();
            this.EditNumber2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(900, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(637, 110);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(92, 17);
            this.LblResult.TabIndex = 1;
            this.LblResult.Text = "                     ";
            // 
            // BtnDemo
            // 
            this.BtnDemo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDemo.Location = new System.Drawing.Point(185, 107);
            this.BtnDemo.Name = "BtnDemo";
            this.BtnDemo.Size = new System.Drawing.Size(167, 102);
            this.BtnDemo.TabIndex = 2;
            this.BtnDemo.Text = "Uzspied šeit!";
            this.BtnDemo.UseVisualStyleBackColor = false;
            this.BtnDemo.Click += new System.EventHandler(this.BtnDemo_Click);
            // 
            // EditNumber1
            // 
            this.EditNumber1.Location = new System.Drawing.Point(379, 107);
            this.EditNumber1.Name = "EditNumber1";
            this.EditNumber1.Size = new System.Drawing.Size(100, 22);
            this.EditNumber1.TabIndex = 3;
            // 
            // EditNumber2
            // 
            this.EditNumber2.Location = new System.Drawing.Point(502, 107);
            this.EditNumber2.Name = "EditNumber2";
            this.EditNumber2.Size = new System.Drawing.Size(100, 22);
            this.EditNumber2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 447);
            this.Controls.Add(this.EditNumber2);
            this.Controls.Add(this.EditNumber1);
            this.Controls.Add(this.BtnDemo);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnDemo;
        private System.Windows.Forms.TextBox EditNumber1;
        private System.Windows.Forms.TextBox EditNumber2;
    }
}

