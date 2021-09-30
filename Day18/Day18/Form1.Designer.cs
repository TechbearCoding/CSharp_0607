
namespace Day18
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
            this.btnCounter = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCounter
            // 
            this.btnCounter.Location = new System.Drawing.Point(21, 23);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(75, 54);
            this.btnCounter.TabIndex = 0;
            this.btnCounter.Text = "Push me";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(123, 42);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(20, 21);
            this.lblRes.TabIndex = 1;
            this.lblRes.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 735);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnCounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.Label lblRes;
    }
}

