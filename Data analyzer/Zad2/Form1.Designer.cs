namespace Zad2
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
            this.dat = new System.Windows.Forms.TextBox();
            this.kv = new System.Windows.Forms.TextBox();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.Datoteka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dat
            // 
            this.dat.Location = new System.Drawing.Point(108, 19);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(256, 20);
            this.dat.TabIndex = 0;
            this.dat.Text = "dat.txt";
            // 
            // kv
            // 
            this.kv.Location = new System.Drawing.Point(108, 64);
            this.kv.Name = "kv";
            this.kv.Size = new System.Drawing.Size(256, 20);
            this.kv.TabIndex = 1;
            this.kv.Text = "10";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(108, 104);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(293, 286);
            this.rtb.TabIndex = 2;
            this.rtb.Text = "";
            // 
            // btn_start
            // 
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_start.Location = new System.Drawing.Point(315, 431);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Datoteka
            // 
            this.Datoteka.AutoSize = true;
            this.Datoteka.Location = new System.Drawing.Point(18, 22);
            this.Datoteka.Name = "Datoteka";
            this.Datoteka.Size = new System.Drawing.Size(51, 13);
            this.Datoteka.TabIndex = 4;
            this.Datoteka.Text = "Datoteka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kriticno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datoteka);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.kv);
            this.Controls.Add(this.dat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dat;
        private System.Windows.Forms.TextBox kv;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label Datoteka;
        private System.Windows.Forms.Label label1;
    }
}

