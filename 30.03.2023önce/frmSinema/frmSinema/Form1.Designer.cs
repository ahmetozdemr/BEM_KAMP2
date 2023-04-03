namespace frmSinema
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
            this.grboxKisisel = new System.Windows.Forms.GroupBox();
            this.txtSoyAd = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grboxFilm = new System.Windows.Forms.GroupBox();
            this.rdFilm4 = new System.Windows.Forms.RadioButton();
            this.rdFilm3 = new System.Windows.Forms.RadioButton();
            this.rdFilm2 = new System.Windows.Forms.RadioButton();
            this.rdFilm1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grboxKisisel.SuspendLayout();
            this.grboxFilm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grboxKisisel
            // 
            this.grboxKisisel.Controls.Add(this.txtSoyAd);
            this.grboxKisisel.Controls.Add(this.txtAd);
            this.grboxKisisel.Controls.Add(this.label2);
            this.grboxKisisel.Controls.Add(this.label1);
            this.grboxKisisel.Location = new System.Drawing.Point(13, 13);
            this.grboxKisisel.Name = "grboxKisisel";
            this.grboxKisisel.Size = new System.Drawing.Size(200, 142);
            this.grboxKisisel.TabIndex = 0;
            this.grboxKisisel.TabStop = false;
            this.grboxKisisel.Text = "Kişisel Bilgiler";
            // 
            // txtSoyAd
            // 
            this.txtSoyAd.Location = new System.Drawing.Point(78, 73);
            this.txtSoyAd.Name = "txtSoyAd";
            this.txtSoyAd.Size = new System.Drawing.Size(100, 20);
            this.txtSoyAd.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(78, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // grboxFilm
            // 
            this.grboxFilm.Controls.Add(this.rdFilm4);
            this.grboxFilm.Controls.Add(this.rdFilm3);
            this.grboxFilm.Controls.Add(this.rdFilm2);
            this.grboxFilm.Controls.Add(this.rdFilm1);
            this.grboxFilm.Location = new System.Drawing.Point(244, 13);
            this.grboxFilm.Name = "grboxFilm";
            this.grboxFilm.Size = new System.Drawing.Size(160, 193);
            this.grboxFilm.TabIndex = 1;
            this.grboxFilm.TabStop = false;
            this.grboxFilm.Text = "Filmler";
            // 
            // rdFilm4
            // 
            this.rdFilm4.AutoSize = true;
            this.rdFilm4.Location = new System.Drawing.Point(40, 149);
            this.rdFilm4.Name = "rdFilm4";
            this.rdFilm4.Size = new System.Drawing.Size(74, 17);
            this.rdFilm4.TabIndex = 3;
            this.rdFilm4.TabStop = true;
            this.rdFilm4.Text = "Anlaşılmaz";
            this.rdFilm4.UseVisualStyleBackColor = true;
            // 
            // rdFilm3
            // 
            this.rdFilm3.AutoSize = true;
            this.rdFilm3.Location = new System.Drawing.Point(40, 112);
            this.rdFilm3.Name = "rdFilm3";
            this.rdFilm3.Size = new System.Drawing.Size(98, 17);
            this.rdFilm3.TabIndex = 2;
            this.rdFilm3.TabStop = true;
            this.rdFilm3.Text = "12 Kızgın Adam";
            this.rdFilm3.UseVisualStyleBackColor = true;
            // 
            // rdFilm2
            // 
            this.rdFilm2.AutoSize = true;
            this.rdFilm2.Location = new System.Drawing.Point(41, 70);
            this.rdFilm2.Name = "rdFilm2";
            this.rdFilm2.Size = new System.Drawing.Size(73, 17);
            this.rdFilm2.TabIndex = 1;
            this.rdFilm2.TabStop = true;
            this.rdFilm2.Text = "Yenilmez3";
            this.rdFilm2.UseVisualStyleBackColor = true;
            // 
            // rdFilm1
            // 
            this.rdFilm1.AutoSize = true;
            this.rdFilm1.Location = new System.Drawing.Point(41, 27);
            this.rdFilm1.Name = "rdFilm1";
            this.rdFilm1.Size = new System.Drawing.Size(82, 17);
            this.rdFilm1.TabIndex = 0;
            this.rdFilm1.TabStop = true;
            this.rdFilm1.Text = "John Wick4";
            this.rdFilm1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(244, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yiyecekler";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(34, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Hamburger";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(34, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Kola";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(34, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Cips";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Patlamış Mısır";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 59);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstListe);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(420, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 389);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap";
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(15, 149);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(335, 199);
            this.lstListe.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(233, 112);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmSinema.Properties.Resources.Ekran_Alıntısı;
            this.pictureBox1.Location = new System.Drawing.Point(12, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Saat 14.00",
            "Saat 18.00",
            "Saat 20.00"});
            this.comboBox1.Location = new System.Drawing.Point(244, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grboxFilm);
            this.Controls.Add(this.grboxKisisel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grboxKisisel.ResumeLayout(false);
            this.grboxKisisel.PerformLayout();
            this.grboxFilm.ResumeLayout(false);
            this.grboxFilm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxKisisel;
        private System.Windows.Forms.TextBox txtSoyAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grboxFilm;
        private System.Windows.Forms.RadioButton rdFilm4;
        private System.Windows.Forms.RadioButton rdFilm3;
        private System.Windows.Forms.RadioButton rdFilm2;
        private System.Windows.Forms.RadioButton rdFilm1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

