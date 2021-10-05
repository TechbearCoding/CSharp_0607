
namespace Day19_homework
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnDel3 = new System.Windows.Forms.Button();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(49, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(328, 260);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(431, 82);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(328, 260);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(804, 82);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(328, 260);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "";
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(49, 375);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(328, 51);
            this.btnAdd1.TabIndex = 3;
            this.btnAdd1.Text = "Pievienot";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnDel1
            // 
            this.btnDel1.Location = new System.Drawing.Point(49, 453);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(328, 51);
            this.btnDel1.TabIndex = 4;
            this.btnDel1.Text = "Dzēst";
            this.btnDel1.UseVisualStyleBackColor = true;
            this.btnDel1.Click += new System.EventHandler(this.btnDel1_Click);
            // 
            // btnDel2
            // 
            this.btnDel2.Location = new System.Drawing.Point(431, 453);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(328, 51);
            this.btnDel2.TabIndex = 6;
            this.btnDel2.Text = "Dzēst";
            this.btnDel2.UseVisualStyleBackColor = true;
            this.btnDel2.Click += new System.EventHandler(this.btnDel2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(431, 375);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(328, 51);
            this.btnAdd2.TabIndex = 5;
            this.btnAdd2.Text = "Pievienot";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnDel3
            // 
            this.btnDel3.Location = new System.Drawing.Point(804, 453);
            this.btnDel3.Name = "btnDel3";
            this.btnDel3.Size = new System.Drawing.Size(328, 51);
            this.btnDel3.TabIndex = 8;
            this.btnDel3.Text = "Dzēst";
            this.btnDel3.UseVisualStyleBackColor = true;
            this.btnDel3.Click += new System.EventHandler(this.btnDel3_Click);
            // 
            // btnAdd3
            // 
            this.btnAdd3.Location = new System.Drawing.Point(804, 375);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(328, 51);
            this.btnAdd3.TabIndex = 7;
            this.btnAdd3.Text = "Pievienot";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(49, 542);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(444, 238);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 542);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDel3);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.btnDel2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnDel1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnDel1;
        private System.Windows.Forms.Button btnDel2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnDel3;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}

