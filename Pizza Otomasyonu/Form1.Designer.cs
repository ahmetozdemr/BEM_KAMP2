namespace Pizza_Otomasyonu
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
            this.cmb_ebat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListPizzalar = new System.Windows.Forms.ListBox();
            this.rd_ince = new System.Windows.Forms.RadioButton();
            this.rd_kalin = new System.Windows.Forms.RadioButton();
            this.grp_malzemeler = new System.Windows.Forms.GroupBox();
            this.chck_peynir = new System.Windows.Forms.CheckBox();
            this.chck_zeytin = new System.Windows.Forms.CheckBox();
            this.chck_mantar = new System.Windows.Forms.CheckBox();
            this.chck_misir = new System.Windows.Forms.CheckBox();
            this.chck_sosis = new System.Windows.Forms.CheckBox();
            this.chck_sucuk = new System.Windows.Forms.CheckBox();
            this.chck_salam = new System.Windows.Forms.CheckBox();
            this.chck_jambon = new System.Windows.Forms.CheckBox();
            this.numeric_adet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_sepete_ekle = new System.Windows.Forms.Button();
            this.btn_siparisi_onayla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listSepet = new System.Windows.Forms.ListBox();
            this.lbl_toplam_tutar = new System.Windows.Forms.Label();
            this.grp_malzemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_adet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_ebat
            // 
            this.cmb_ebat.FormattingEnabled = true;
            this.cmb_ebat.Location = new System.Drawing.Point(17, 90);
            this.cmb_ebat.Name = "cmb_ebat";
            this.cmb_ebat.Size = new System.Drawing.Size(121, 21);
            this.cmb_ebat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ebat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pizza Çeşitleri";
            // 
            // ListPizzalar
            // 
            this.ListPizzalar.FormattingEnabled = true;
            this.ListPizzalar.Location = new System.Drawing.Point(21, 146);
            this.ListPizzalar.Name = "ListPizzalar";
            this.ListPizzalar.Size = new System.Drawing.Size(120, 95);
            this.ListPizzalar.TabIndex = 3;
            // 
            // rd_ince
            // 
            this.rd_ince.AutoSize = true;
            this.rd_ince.Location = new System.Drawing.Point(22, 247);
            this.rd_ince.Name = "rd_ince";
            this.rd_ince.Size = new System.Drawing.Size(77, 17);
            this.rd_ince.TabIndex = 4;
            this.rd_ince.TabStop = true;
            this.rd_ince.Tag = "0";
            this.rd_ince.Text = "İnce Kenar";
            this.rd_ince.UseVisualStyleBackColor = true;
            // 
            // rd_kalin
            // 
            this.rd_kalin.AutoSize = true;
            this.rd_kalin.Location = new System.Drawing.Point(105, 247);
            this.rd_kalin.Name = "rd_kalin";
            this.rd_kalin.Size = new System.Drawing.Size(79, 17);
            this.rd_kalin.TabIndex = 5;
            this.rd_kalin.TabStop = true;
            this.rd_kalin.Tag = "2";
            this.rd_kalin.Text = "Kalın Kenar";
            this.rd_kalin.UseVisualStyleBackColor = true;
            // 
            // grp_malzemeler
            // 
            this.grp_malzemeler.Controls.Add(this.chck_peynir);
            this.grp_malzemeler.Controls.Add(this.chck_zeytin);
            this.grp_malzemeler.Controls.Add(this.chck_mantar);
            this.grp_malzemeler.Controls.Add(this.chck_misir);
            this.grp_malzemeler.Controls.Add(this.chck_sosis);
            this.grp_malzemeler.Controls.Add(this.chck_sucuk);
            this.grp_malzemeler.Controls.Add(this.chck_salam);
            this.grp_malzemeler.Controls.Add(this.chck_jambon);
            this.grp_malzemeler.Location = new System.Drawing.Point(17, 278);
            this.grp_malzemeler.Name = "grp_malzemeler";
            this.grp_malzemeler.Size = new System.Drawing.Size(205, 127);
            this.grp_malzemeler.TabIndex = 6;
            this.grp_malzemeler.TabStop = false;
            this.grp_malzemeler.Text = "Malzemeler";
            // 
            // chck_peynir
            // 
            this.chck_peynir.AutoSize = true;
            this.chck_peynir.Location = new System.Drawing.Point(109, 99);
            this.chck_peynir.Name = "chck_peynir";
            this.chck_peynir.Size = new System.Drawing.Size(54, 17);
            this.chck_peynir.TabIndex = 7;
            this.chck_peynir.Text = "peynir";
            this.chck_peynir.UseVisualStyleBackColor = true;
            // 
            // chck_zeytin
            // 
            this.chck_zeytin.AutoSize = true;
            this.chck_zeytin.Location = new System.Drawing.Point(109, 76);
            this.chck_zeytin.Name = "chck_zeytin";
            this.chck_zeytin.Size = new System.Drawing.Size(53, 17);
            this.chck_zeytin.TabIndex = 6;
            this.chck_zeytin.Text = "zeytin";
            this.chck_zeytin.UseVisualStyleBackColor = true;
            // 
            // chck_mantar
            // 
            this.chck_mantar.AutoSize = true;
            this.chck_mantar.Location = new System.Drawing.Point(109, 53);
            this.chck_mantar.Name = "chck_mantar";
            this.chck_mantar.Size = new System.Drawing.Size(58, 17);
            this.chck_mantar.TabIndex = 5;
            this.chck_mantar.Text = "mantar";
            this.chck_mantar.UseVisualStyleBackColor = true;
            // 
            // chck_misir
            // 
            this.chck_misir.AutoSize = true;
            this.chck_misir.Location = new System.Drawing.Point(109, 30);
            this.chck_misir.Name = "chck_misir";
            this.chck_misir.Size = new System.Drawing.Size(46, 17);
            this.chck_misir.TabIndex = 4;
            this.chck_misir.Text = "mısır";
            this.chck_misir.UseVisualStyleBackColor = true;
            // 
            // chck_sosis
            // 
            this.chck_sosis.AutoSize = true;
            this.chck_sosis.Location = new System.Drawing.Point(6, 99);
            this.chck_sosis.Name = "chck_sosis";
            this.chck_sosis.Size = new System.Drawing.Size(49, 17);
            this.chck_sosis.TabIndex = 3;
            this.chck_sosis.Text = "sosis";
            this.chck_sosis.UseVisualStyleBackColor = true;
            // 
            // chck_sucuk
            // 
            this.chck_sucuk.AutoSize = true;
            this.chck_sucuk.Location = new System.Drawing.Point(6, 76);
            this.chck_sucuk.Name = "chck_sucuk";
            this.chck_sucuk.Size = new System.Drawing.Size(55, 17);
            this.chck_sucuk.TabIndex = 2;
            this.chck_sucuk.Text = "sucuk";
            this.chck_sucuk.UseVisualStyleBackColor = true;
            // 
            // chck_salam
            // 
            this.chck_salam.AutoSize = true;
            this.chck_salam.Location = new System.Drawing.Point(6, 53);
            this.chck_salam.Name = "chck_salam";
            this.chck_salam.Size = new System.Drawing.Size(53, 17);
            this.chck_salam.TabIndex = 1;
            this.chck_salam.Text = "salam";
            this.chck_salam.UseVisualStyleBackColor = true;
            // 
            // chck_jambon
            // 
            this.chck_jambon.AutoSize = true;
            this.chck_jambon.Location = new System.Drawing.Point(6, 30);
            this.chck_jambon.Name = "chck_jambon";
            this.chck_jambon.Size = new System.Drawing.Size(60, 17);
            this.chck_jambon.TabIndex = 0;
            this.chck_jambon.Text = "jambon";
            this.chck_jambon.UseVisualStyleBackColor = true;
            // 
            // numeric_adet
            // 
            this.numeric_adet.Location = new System.Drawing.Point(21, 427);
            this.numeric_adet.Name = "numeric_adet";
            this.numeric_adet.Size = new System.Drawing.Size(120, 20);
            this.numeric_adet.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(147, 424);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 9;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_sepete_ekle
            // 
            this.btn_sepete_ekle.Location = new System.Drawing.Point(390, 417);
            this.btn_sepete_ekle.Name = "btn_sepete_ekle";
            this.btn_sepete_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_sepete_ekle.TabIndex = 10;
            this.btn_sepete_ekle.Text = "Sepete Ekle";
            this.btn_sepete_ekle.UseVisualStyleBackColor = true;
            this.btn_sepete_ekle.Click += new System.EventHandler(this.btn_sepete_ekle_Click);
            // 
            // btn_siparisi_onayla
            // 
            this.btn_siparisi_onayla.Location = new System.Drawing.Point(569, 417);
            this.btn_siparisi_onayla.Name = "btn_siparisi_onayla";
            this.btn_siparisi_onayla.Size = new System.Drawing.Size(108, 23);
            this.btn_siparisi_onayla.TabIndex = 11;
            this.btn_siparisi_onayla.Text = "Siparişi Onayla";
            this.btn_siparisi_onayla.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "tutar";
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(257, 420);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(100, 20);
            this.txt_tutar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "toplam tutar";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(798, 57);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pizza Otomasyonu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listSepet
            // 
            this.listSepet.FormattingEnabled = true;
            this.listSepet.Location = new System.Drawing.Point(257, 90);
            this.listSepet.Name = "listSepet";
            this.listSepet.Size = new System.Drawing.Size(541, 251);
            this.listSepet.TabIndex = 18;
            // 
            // lbl_toplam_tutar
            // 
            this.lbl_toplam_tutar.AutoSize = true;
            this.lbl_toplam_tutar.Location = new System.Drawing.Point(582, 361);
            this.lbl_toplam_tutar.Name = "lbl_toplam_tutar";
            this.lbl_toplam_tutar.Size = new System.Drawing.Size(13, 13);
            this.lbl_toplam_tutar.TabIndex = 19;
            this.lbl_toplam_tutar.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_toplam_tutar);
            this.Controls.Add(this.listSepet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_siparisi_onayla);
            this.Controls.Add(this.btn_sepete_ekle);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeric_adet);
            this.Controls.Add(this.grp_malzemeler);
            this.Controls.Add(this.rd_kalin);
            this.Controls.Add(this.rd_ince);
            this.Controls.Add(this.ListPizzalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ebat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_malzemeler.ResumeLayout(false);
            this.grp_malzemeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_ebat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListPizzalar;
        private System.Windows.Forms.RadioButton rd_ince;
        private System.Windows.Forms.RadioButton rd_kalin;
        private System.Windows.Forms.GroupBox grp_malzemeler;
        private System.Windows.Forms.CheckBox chck_peynir;
        private System.Windows.Forms.CheckBox chck_zeytin;
        private System.Windows.Forms.CheckBox chck_mantar;
        private System.Windows.Forms.CheckBox chck_misir;
        private System.Windows.Forms.CheckBox chck_sosis;
        private System.Windows.Forms.CheckBox chck_sucuk;
        private System.Windows.Forms.CheckBox chck_salam;
        private System.Windows.Forms.CheckBox chck_jambon;
        private System.Windows.Forms.NumericUpDown numeric_adet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_sepete_ekle;
        private System.Windows.Forms.Button btn_siparisi_onayla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listSepet;
        private System.Windows.Forms.Label lbl_toplam_tutar;
    }
}

