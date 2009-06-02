namespace emleecher
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
          this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
          this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
          this.groupBox1 = new System.Windows.Forms.GroupBox();
          this.textBox2 = new System.Windows.Forms.TextBox();
          this.button1 = new System.Windows.Forms.Button();
          this.groupBox2 = new System.Windows.Forms.GroupBox();
          this.textBox1 = new System.Windows.Forms.TextBox();
          this.button2 = new System.Windows.Forms.Button();
          this.button3 = new System.Windows.Forms.Button();
          this.progressBar1 = new System.Windows.Forms.ProgressBar();
          this.label1 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.progressBar2 = new System.Windows.Forms.ProgressBar();
          this.groupBox1.SuspendLayout();
          this.groupBox2.SuspendLayout();
          this.SuspendLayout();
          // 
          // groupBox1
          // 
          this.groupBox1.Controls.Add(this.textBox1);
          this.groupBox1.Controls.Add(this.button1);
          this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
          this.groupBox1.Location = new System.Drawing.Point(0, 0);
          this.groupBox1.Name = "groupBox1";
          this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
          this.groupBox1.Size = new System.Drawing.Size(584, 53);
          this.groupBox1.TabIndex = 0;
          this.groupBox1.TabStop = false;
          this.groupBox1.Text = "Input Path";
          // 
          // textBox2
          // 
          this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.textBox2.Location = new System.Drawing.Point(10, 23);
          this.textBox2.Name = "textBox2";
          this.textBox2.Size = new System.Drawing.Size(489, 20);
          this.textBox2.TabIndex = 2;
          // 
          // button1
          // 
          this.button1.Dock = System.Windows.Forms.DockStyle.Right;
          this.button1.Location = new System.Drawing.Point(499, 23);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(75, 20);
          this.button1.TabIndex = 0;
          this.button1.Text = "browse";
          this.button1.UseVisualStyleBackColor = true;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // groupBox2
          // 
          this.groupBox2.Controls.Add(this.textBox2);
          this.groupBox2.Controls.Add(this.button2);
          this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
          this.groupBox2.Location = new System.Drawing.Point(0, 53);
          this.groupBox2.Name = "groupBox2";
          this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
          this.groupBox2.Size = new System.Drawing.Size(584, 53);
          this.groupBox2.TabIndex = 1;
          this.groupBox2.TabStop = false;
          this.groupBox2.Text = "Output Path";
          // 
          // textBox1
          // 
          this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.textBox1.Location = new System.Drawing.Point(10, 23);
          this.textBox1.Name = "textBox1";
          this.textBox1.Size = new System.Drawing.Size(489, 20);
          this.textBox1.TabIndex = 2;
          // 
          // button2
          // 
          this.button2.Dock = System.Windows.Forms.DockStyle.Right;
          this.button2.Location = new System.Drawing.Point(499, 23);
          this.button2.Name = "button2";
          this.button2.Size = new System.Drawing.Size(75, 20);
          this.button2.TabIndex = 0;
          this.button2.Text = "browse";
          this.button2.UseVisualStyleBackColor = true;
          this.button2.Click += new System.EventHandler(this.button2_Click);
          // 
          // button3
          // 
          this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
          this.button3.Location = new System.Drawing.Point(0, 106);
          this.button3.Name = "button3";
          this.button3.Size = new System.Drawing.Size(584, 37);
          this.button3.TabIndex = 2;
          this.button3.Text = "extract";
          this.button3.UseVisualStyleBackColor = true;
          this.button3.Click += new System.EventHandler(this.button3_Click);
          // 
          // progressBar1
          // 
          this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.progressBar1.Location = new System.Drawing.Point(0, 156);
          this.progressBar1.Name = "progressBar1";
          this.progressBar1.Size = new System.Drawing.Size(584, 23);
          this.progressBar1.TabIndex = 3;
          // 
          // label1
          // 
          this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.label1.Location = new System.Drawing.Point(0, 143);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(584, 13);
          this.label1.TabIndex = 4;
          this.label1.Text = "label1";
          // 
          // label2
          // 
          this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.label2.Location = new System.Drawing.Point(0, 179);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(584, 13);
          this.label2.TabIndex = 6;
          this.label2.Text = "label2";
          // 
          // progressBar2
          // 
          this.progressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.progressBar2.Location = new System.Drawing.Point(0, 192);
          this.progressBar2.Name = "progressBar2";
          this.progressBar2.Size = new System.Drawing.Size(584, 23);
          this.progressBar2.TabIndex = 5;
          // 
          // Form1
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(584, 215);
          this.Controls.Add(this.button3);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.progressBar1);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.progressBar2);
          this.Controls.Add(this.groupBox2);
          this.Controls.Add(this.groupBox1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
          this.Name = "Form1";
          this.Text = "Form1";
          this.groupBox1.ResumeLayout(false);
          this.groupBox1.PerformLayout();
          this.groupBox2.ResumeLayout(false);
          this.groupBox2.PerformLayout();
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

