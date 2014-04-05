namespace Zad1
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
            this.lbl_BrRedaka = new System.Windows.Forms.Label();
            this.lbl_BrStupaca = new System.Windows.Forms.Label();
            this.lbl_DonjaGr = new System.Windows.Forms.Label();
            this.lbl_GornjaGrr = new System.Windows.Forms.Label();
            this.rtbx_Matrica = new System.Windows.Forms.RichTextBox();
            this.btn_Generiraj = new System.Windows.Forms.Button();
            this.btn_UcitajDat = new System.Windows.Forms.Button();
            this.btn_ZapisiDat = new System.Windows.Forms.Button();
            this.btn_MnoziSkalarom = new System.Windows.Forms.Button();
            this.btn_Transponiraj = new System.Windows.Forms.Button();
            this.btn_Izlaz = new System.Windows.Forms.Button();
            this.tbx_BrRedaka = new System.Windows.Forms.TextBox();
            this.tbx_BrStupaca = new System.Windows.Forms.TextBox();
            this.tbx_DonjaGr = new System.Windows.Forms.TextBox();
            this.tbx_GornjaGr = new System.Windows.Forms.TextBox();
            this.tbx_UlaznaDat = new System.Windows.Forms.TextBox();
            this.tbx_IzlaznaDat = new System.Windows.Forms.TextBox();
            this.tbx_Skalar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_BrRedaka
            // 
            this.lbl_BrRedaka.AutoSize = true;
            this.lbl_BrRedaka.Location = new System.Drawing.Point(30, 25);
            this.lbl_BrRedaka.Name = "lbl_BrRedaka";
            this.lbl_BrRedaka.Size = new System.Drawing.Size(38, 13);
            this.lbl_BrRedaka.TabIndex = 0;
            this.lbl_BrRedaka.Text = "Redci:";
            // 
            // lbl_BrStupaca
            // 
            this.lbl_BrStupaca.AutoSize = true;
            this.lbl_BrStupaca.Location = new System.Drawing.Point(30, 68);
            this.lbl_BrStupaca.Name = "lbl_BrStupaca";
            this.lbl_BrStupaca.Size = new System.Drawing.Size(40, 13);
            this.lbl_BrStupaca.TabIndex = 1;
            this.lbl_BrStupaca.Text = "Stupci:";
            // 
            // lbl_DonjaGr
            // 
            this.lbl_DonjaGr.AutoSize = true;
            this.lbl_DonjaGr.Location = new System.Drawing.Point(12, 130);
            this.lbl_DonjaGr.Name = "lbl_DonjaGr";
            this.lbl_DonjaGr.Size = new System.Drawing.Size(76, 13);
            this.lbl_DonjaGr.TabIndex = 2;
            this.lbl_DonjaGr.Text = "Donja granica:";
            // 
            // lbl_GornjaGrr
            // 
            this.lbl_GornjaGrr.AutoSize = true;
            this.lbl_GornjaGrr.Location = new System.Drawing.Point(12, 166);
            this.lbl_GornjaGrr.Name = "lbl_GornjaGrr";
            this.lbl_GornjaGrr.Size = new System.Drawing.Size(79, 13);
            this.lbl_GornjaGrr.TabIndex = 3;
            this.lbl_GornjaGrr.Text = "Gornja granica:";
            // 
            // rtbx_Matrica
            // 
            this.rtbx_Matrica.Location = new System.Drawing.Point(279, 11);
            this.rtbx_Matrica.Name = "rtbx_Matrica";
            this.rtbx_Matrica.Size = new System.Drawing.Size(338, 238);
            this.rtbx_Matrica.TabIndex = 4;
            this.rtbx_Matrica.Text = "";
            // 
            // btn_Generiraj
            // 
            this.btn_Generiraj.Location = new System.Drawing.Point(141, 203);
            this.btn_Generiraj.Name = "btn_Generiraj";
            this.btn_Generiraj.Size = new System.Drawing.Size(75, 23);
            this.btn_Generiraj.TabIndex = 5;
            this.btn_Generiraj.Text = "Generiraj";
            this.btn_Generiraj.UseVisualStyleBackColor = true;
            this.btn_Generiraj.Click += new System.EventHandler(this.btn_Generiraj_Click);
            // 
            // btn_UcitajDat
            // 
            this.btn_UcitajDat.Location = new System.Drawing.Point(141, 255);
            this.btn_UcitajDat.Name = "btn_UcitajDat";
            this.btn_UcitajDat.Size = new System.Drawing.Size(75, 23);
            this.btn_UcitajDat.TabIndex = 6;
            this.btn_UcitajDat.Text = "Ucitaj";
            this.btn_UcitajDat.UseVisualStyleBackColor = true;
            this.btn_UcitajDat.Click += new System.EventHandler(this.btn_UcitajDat_Click);
            // 
            // btn_ZapisiDat
            // 
            this.btn_ZapisiDat.Location = new System.Drawing.Point(141, 334);
            this.btn_ZapisiDat.Name = "btn_ZapisiDat";
            this.btn_ZapisiDat.Size = new System.Drawing.Size(75, 23);
            this.btn_ZapisiDat.TabIndex = 7;
            this.btn_ZapisiDat.Text = "Zapisi";
            this.btn_ZapisiDat.UseVisualStyleBackColor = true;
            this.btn_ZapisiDat.Click += new System.EventHandler(this.btn_ZapisiDat_Click);
            // 
            // btn_MnoziSkalarom
            // 
            this.btn_MnoziSkalarom.Location = new System.Drawing.Point(388, 291);
            this.btn_MnoziSkalarom.Name = "btn_MnoziSkalarom";
            this.btn_MnoziSkalarom.Size = new System.Drawing.Size(75, 23);
            this.btn_MnoziSkalarom.TabIndex = 8;
            this.btn_MnoziSkalarom.Text = "Mnozi";
            this.btn_MnoziSkalarom.UseVisualStyleBackColor = true;
            this.btn_MnoziSkalarom.Click += new System.EventHandler(this.btn_MnoziSkalarom_Click);
            // 
            // btn_Transponiraj
            // 
            this.btn_Transponiraj.Location = new System.Drawing.Point(533, 291);
            this.btn_Transponiraj.Name = "btn_Transponiraj";
            this.btn_Transponiraj.Size = new System.Drawing.Size(75, 23);
            this.btn_Transponiraj.TabIndex = 9;
            this.btn_Transponiraj.Text = "Transponiraj";
            this.btn_Transponiraj.UseVisualStyleBackColor = true;
            this.btn_Transponiraj.Click += new System.EventHandler(this.btn_Transponiraj_Click);
            // 
            // btn_Izlaz
            // 
            this.btn_Izlaz.Location = new System.Drawing.Point(533, 358);
            this.btn_Izlaz.Name = "btn_Izlaz";
            this.btn_Izlaz.Size = new System.Drawing.Size(75, 23);
            this.btn_Izlaz.TabIndex = 10;
            this.btn_Izlaz.Text = "Izlaz";
            this.btn_Izlaz.UseVisualStyleBackColor = true;
            this.btn_Izlaz.Click += new System.EventHandler(this.btn_Izlaz_Click);
            // 
            // tbx_BrRedaka
            // 
            this.tbx_BrRedaka.Location = new System.Drawing.Point(65, 22);
            this.tbx_BrRedaka.Name = "tbx_BrRedaka";
            this.tbx_BrRedaka.Size = new System.Drawing.Size(100, 20);
            this.tbx_BrRedaka.TabIndex = 11;
            // 
            // tbx_BrStupaca
            // 
            this.tbx_BrStupaca.Location = new System.Drawing.Point(65, 65);
            this.tbx_BrStupaca.Name = "tbx_BrStupaca";
            this.tbx_BrStupaca.Size = new System.Drawing.Size(100, 20);
            this.tbx_BrStupaca.TabIndex = 12;
            // 
            // tbx_DonjaGr
            // 
            this.tbx_DonjaGr.Location = new System.Drawing.Point(116, 127);
            this.tbx_DonjaGr.Name = "tbx_DonjaGr";
            this.tbx_DonjaGr.Size = new System.Drawing.Size(100, 20);
            this.tbx_DonjaGr.TabIndex = 13;
            // 
            // tbx_GornjaGr
            // 
            this.tbx_GornjaGr.Location = new System.Drawing.Point(116, 163);
            this.tbx_GornjaGr.Name = "tbx_GornjaGr";
            this.tbx_GornjaGr.Size = new System.Drawing.Size(100, 20);
            this.tbx_GornjaGr.TabIndex = 14;
            // 
            // tbx_UlaznaDat
            // 
            this.tbx_UlaznaDat.Location = new System.Drawing.Point(33, 257);
            this.tbx_UlaznaDat.Name = "tbx_UlaznaDat";
            this.tbx_UlaznaDat.Size = new System.Drawing.Size(100, 20);
            this.tbx_UlaznaDat.TabIndex = 15;
            // 
            // tbx_IzlaznaDat
            // 
            this.tbx_IzlaznaDat.Location = new System.Drawing.Point(33, 337);
            this.tbx_IzlaznaDat.Name = "tbx_IzlaznaDat";
            this.tbx_IzlaznaDat.Size = new System.Drawing.Size(100, 20);
            this.tbx_IzlaznaDat.TabIndex = 16;
            // 
            // tbx_Skalar
            // 
            this.tbx_Skalar.Location = new System.Drawing.Point(262, 293);
            this.tbx_Skalar.Name = "tbx_Skalar";
            this.tbx_Skalar.Size = new System.Drawing.Size(100, 20);
            this.tbx_Skalar.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 404);
            this.Controls.Add(this.tbx_Skalar);
            this.Controls.Add(this.tbx_IzlaznaDat);
            this.Controls.Add(this.tbx_UlaznaDat);
            this.Controls.Add(this.tbx_GornjaGr);
            this.Controls.Add(this.tbx_DonjaGr);
            this.Controls.Add(this.tbx_BrStupaca);
            this.Controls.Add(this.tbx_BrRedaka);
            this.Controls.Add(this.btn_Izlaz);
            this.Controls.Add(this.btn_Transponiraj);
            this.Controls.Add(this.btn_MnoziSkalarom);
            this.Controls.Add(this.btn_ZapisiDat);
            this.Controls.Add(this.btn_UcitajDat);
            this.Controls.Add(this.btn_Generiraj);
            this.Controls.Add(this.rtbx_Matrica);
            this.Controls.Add(this.lbl_GornjaGrr);
            this.Controls.Add(this.lbl_DonjaGr);
            this.Controls.Add(this.lbl_BrStupaca);
            this.Controls.Add(this.lbl_BrRedaka);
            this.Name = "Form1";
            this.Text = "Matricni kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BrRedaka;
        private System.Windows.Forms.Label lbl_BrStupaca;
        private System.Windows.Forms.Label lbl_DonjaGr;
        private System.Windows.Forms.Label lbl_GornjaGrr;
        private System.Windows.Forms.RichTextBox rtbx_Matrica;
        private System.Windows.Forms.Button btn_Generiraj;
        private System.Windows.Forms.Button btn_UcitajDat;
        private System.Windows.Forms.Button btn_ZapisiDat;
        private System.Windows.Forms.Button btn_MnoziSkalarom;
        private System.Windows.Forms.Button btn_Transponiraj;
        private System.Windows.Forms.Button btn_Izlaz;
        private System.Windows.Forms.TextBox tbx_BrRedaka;
        private System.Windows.Forms.TextBox tbx_BrStupaca;
        private System.Windows.Forms.TextBox tbx_DonjaGr;
        private System.Windows.Forms.TextBox tbx_GornjaGr;
        private System.Windows.Forms.TextBox tbx_UlaznaDat;
        private System.Windows.Forms.TextBox tbx_IzlaznaDat;
        private System.Windows.Forms.TextBox tbx_Skalar;
    }
}

