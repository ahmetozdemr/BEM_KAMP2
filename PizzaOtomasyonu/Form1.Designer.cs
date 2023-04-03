namespace PizzaOtomasyonu
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
            this.comboEbat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPizzalar = new System.Windows.Forms.ListBox();
            this.radioButtonInceKenar = new System.Windows.Forms.RadioButton();
            this.radioButtonKalinKenar = new System.Windows.Forms.RadioButton();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTutar = new System.Windows.Forms.TextBox();
            this.buttonSepetEkle = new System.Windows.Forms.Button();
            this.listBoxSepet = new System.Windows.Forms.ListBox();
            this.buttonSiparisOnayla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelToplamTutar = new System.Windows.Forms.Label();
            this.checkedListBoxMalzemeler = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboEbat
            // 
            this.comboEbat.FormattingEnabled = true;
            this.comboEbat.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük",
            "Max"});
            this.comboEbat.Location = new System.Drawing.Point(19, 72);
            this.comboEbat.Name = "comboEbat";
            this.comboEbat.Size = new System.Drawing.Size(206, 23);
            this.comboEbat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ebat";
            // 
            // listBoxPizzalar
            // 
            this.listBoxPizzalar.FormattingEnabled = true;
            this.listBoxPizzalar.ItemHeight = 15;
            this.listBoxPizzalar.Items.AddRange(new object[] {
            "Klasik",
            "Karışık",
            "Turkish",
            "Tuna",
            "Akdeniz",
            "Karadeniz"});
            this.listBoxPizzalar.Location = new System.Drawing.Point(19, 106);
            this.listBoxPizzalar.Name = "listBoxPizzalar";
            this.listBoxPizzalar.Size = new System.Drawing.Size(205, 109);
            this.listBoxPizzalar.TabIndex = 2;
            // 
            // radioButtonInceKenar
            // 
            this.radioButtonInceKenar.AutoSize = true;
            this.radioButtonInceKenar.Location = new System.Drawing.Point(19, 221);
            this.radioButtonInceKenar.Name = "radioButtonInceKenar";
            this.radioButtonInceKenar.Size = new System.Drawing.Size(80, 19);
            this.radioButtonInceKenar.TabIndex = 3;
            this.radioButtonInceKenar.TabStop = true;
            this.radioButtonInceKenar.Text = "İnce Kenar";
            this.radioButtonInceKenar.UseVisualStyleBackColor = true;
            // 
            // radioButtonKalinKenar
            // 
            this.radioButtonKalinKenar.AutoSize = true;
            this.radioButtonKalinKenar.Location = new System.Drawing.Point(128, 221);
            this.radioButtonKalinKenar.Name = "radioButtonKalinKenar";
            this.radioButtonKalinKenar.Size = new System.Drawing.Size(84, 19);
            this.radioButtonKalinKenar.TabIndex = 4;
            this.radioButtonKalinKenar.TabStop = true;
            this.radioButtonKalinKenar.Text = "Kalın Kenar";
            this.radioButtonKalinKenar.UseVisualStyleBackColor = true;
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(128, 424);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(75, 23);
            this.buttonHesapla.TabIndex = 6;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adet";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(56, 424);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tutar";
            // 
            // textBoxTutar
            // 
            this.textBoxTutar.Location = new System.Drawing.Point(296, 425);
            this.textBoxTutar.Name = "textBoxTutar";
            this.textBoxTutar.Size = new System.Drawing.Size(77, 23);
            this.textBoxTutar.TabIndex = 11;
            // 
            // buttonSepetEkle
            // 
            this.buttonSepetEkle.Location = new System.Drawing.Point(397, 424);
            this.buttonSepetEkle.Name = "buttonSepetEkle";
            this.buttonSepetEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonSepetEkle.TabIndex = 12;
            this.buttonSepetEkle.Text = "Sepete Ekle";
            this.buttonSepetEkle.UseVisualStyleBackColor = true;
            this.buttonSepetEkle.Click += new System.EventHandler(this.buttonSepetEkle_Click);
            // 
            // listBoxSepet
            // 
            this.listBoxSepet.FormattingEnabled = true;
            this.listBoxSepet.HorizontalScrollbar = true;
            this.listBoxSepet.ItemHeight = 15;
            this.listBoxSepet.Location = new System.Drawing.Point(247, 72);
            this.listBoxSepet.Name = "listBoxSepet";
            this.listBoxSepet.Size = new System.Drawing.Size(514, 304);
            this.listBoxSepet.TabIndex = 13;
            // 
            // buttonSiparisOnayla
            // 
            this.buttonSiparisOnayla.Location = new System.Drawing.Point(614, 422);
            this.buttonSiparisOnayla.Name = "buttonSiparisOnayla";
            this.buttonSiparisOnayla.Size = new System.Drawing.Size(100, 23);
            this.buttonSiparisOnayla.TabIndex = 14;
            this.buttonSiparisOnayla.Text = "Sipariş Onayla";
            this.buttonSiparisOnayla.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Toplam Tutar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.Location = new System.Drawing.Point(699, 400);
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(34, 15);
            this.labelToplamTutar.TabIndex = 16;
            this.labelToplamTutar.Text = "Tutar";
            // 
            // checkedListBoxMalzemeler
            // 
            this.checkedListBoxMalzemeler.FormattingEnabled = true;
            this.checkedListBoxMalzemeler.Items.AddRange(new object[] {
            "Dana Jambon",
            "Sosis",
            "Mısır",
            "Ancuez",
            "Zeytin",
            "Salam",
            "Sucuk",
            "Mantar",
            "Ton Balığı",
            "Peynir"});
            this.checkedListBoxMalzemeler.Location = new System.Drawing.Point(19, 255);
            this.checkedListBoxMalzemeler.Name = "checkedListBoxMalzemeler";
            this.checkedListBoxMalzemeler.Size = new System.Drawing.Size(201, 148);
            this.checkedListBoxMalzemeler.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.checkedListBoxMalzemeler);
            this.Controls.Add(this.labelToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSiparisOnayla);
            this.Controls.Add(this.listBoxSepet);
            this.Controls.Add(this.buttonSepetEkle);
            this.Controls.Add(this.textBoxTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.radioButtonKalinKenar);
            this.Controls.Add(this.radioButtonInceKenar);
            this.Controls.Add(this.listBoxPizzalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEbat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboEbat;
        private Label label1;
        private ListBox listBoxPizzalar;
        private RadioButton radioButtonInceKenar;
        private RadioButton radioButtonKalinKenar;
        private Button buttonHesapla;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private TextBox textBoxTutar;
        private Button buttonSepetEkle;
        private ListBox listBoxSepet;
        private Button buttonSiparisOnayla;
        private Label label4;
        private Label labelToplamTutar;
        private CheckedListBox checkedListBoxMalzemeler;
    }
}