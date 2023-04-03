namespace _3
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soy = new System.Windows.Forms.TextBox();
            this.rdkd = new System.Windows.Forms.RadioButton();
            this.rder = new System.Windows.Forms.RadioButton();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_misir = new System.Windows.Forms.CheckBox();
            this.chk_kola = new System.Windows.Forms.CheckBox();
            this.chk_cips = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdhizli = new System.Windows.Forms.RadioButton();
            this.rdyenil = new System.Windows.Forms.RadioButton();
            this.rdjohn = new System.Windows.Forms.RadioButton();
            this.listbilgi = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(55, 19);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(126, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // txt_soy
            // 
            this.txt_soy.Location = new System.Drawing.Point(55, 45);
            this.txt_soy.Name = "txt_soy";
            this.txt_soy.Size = new System.Drawing.Size(126, 20);
            this.txt_soy.TabIndex = 1;
            // 
            // rdkd
            // 
            this.rdkd.AutoSize = true;
            this.rdkd.Location = new System.Drawing.Point(55, 85);
            this.rdkd.Name = "rdkd";
            this.rdkd.Size = new System.Drawing.Size(52, 17);
            this.rdkd.TabIndex = 2;
            this.rdkd.TabStop = true;
            this.rdkd.Text = "Kadın";
            this.rdkd.UseVisualStyleBackColor = true;
            // 
            // rder
            // 
            this.rder.AutoSize = true;
            this.rder.Location = new System.Drawing.Point(128, 85);
            this.rder.Name = "rder";
            this.rder.Size = new System.Drawing.Size(53, 17);
            this.rder.TabIndex = 3;
            this.rder.TabStop = true;
            this.rder.Text = "Erkek";
            this.rder.UseVisualStyleBackColor = true;
            // 
            // btnsonuc
            // 
            this.btnsonuc.Location = new System.Drawing.Point(139, 280);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(137, 23);
            this.btnsonuc.TabIndex = 0;
            this.btnsonuc.Text = "Bilgi ve Fiyat Göster";
            this.btnsonuc.UseVisualStyleBackColor = true;
            this.btnsonuc.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_soy);
            this.groupBox1.Controls.Add(this.rder);
            this.groupBox1.Controls.Add(this.rdkd);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ad Soyad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_misir);
            this.groupBox3.Controls.Add(this.chk_kola);
            this.groupBox3.Controls.Add(this.chk_cips);
            this.groupBox3.Location = new System.Drawing.Point(25, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yiyecekler";
            // 
            // chk_misir
            // 
            this.chk_misir.AutoSize = true;
            this.chk_misir.Location = new System.Drawing.Point(6, 66);
            this.chk_misir.Name = "chk_misir";
            this.chk_misir.Size = new System.Drawing.Size(111, 17);
            this.chk_misir.TabIndex = 2;
            this.chk_misir.Text = "Patlamış mısır 20 tl";
            this.chk_misir.UseVisualStyleBackColor = true;
            // 
            // chk_kola
            // 
            this.chk_kola.AutoSize = true;
            this.chk_kola.Location = new System.Drawing.Point(7, 43);
            this.chk_kola.Name = "chk_kola";
            this.chk_kola.Size = new System.Drawing.Size(64, 17);
            this.chk_kola.TabIndex = 1;
            this.chk_kola.Text = "Kola 4 tl";
            this.chk_kola.UseVisualStyleBackColor = true;
            // 
            // chk_cips
            // 
            this.chk_cips.AutoSize = true;
            this.chk_cips.Location = new System.Drawing.Point(7, 20);
            this.chk_cips.Name = "chk_cips";
            this.chk_cips.Size = new System.Drawing.Size(63, 17);
            this.chk_cips.TabIndex = 0;
            this.chk_cips.Text = "Cips 8 tl";
            this.chk_cips.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdhizli);
            this.groupBox4.Controls.Add(this.rdyenil);
            this.groupBox4.Controls.Add(this.rdjohn);
            this.groupBox4.Location = new System.Drawing.Point(245, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 115);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filmler";
            // 
            // rdhizli
            // 
            this.rdhizli.AutoSize = true;
            this.rdhizli.Location = new System.Drawing.Point(11, 69);
            this.rdhizli.Name = "rdhizli";
            this.rdhizli.Size = new System.Drawing.Size(89, 17);
            this.rdhizli.TabIndex = 2;
            this.rdhizli.TabStop = true;
            this.rdhizli.Text = "Hızlı ve Öfkeli";
            this.rdhizli.UseVisualStyleBackColor = true;
            // 
            // rdyenil
            // 
            this.rdyenil.AutoSize = true;
            this.rdyenil.Location = new System.Drawing.Point(11, 46);
            this.rdyenil.Name = "rdyenil";
            this.rdyenil.Size = new System.Drawing.Size(78, 17);
            this.rdyenil.TabIndex = 1;
            this.rdyenil.TabStop = true;
            this.rdyenil.Text = "Yenilmezler";
            this.rdyenil.UseVisualStyleBackColor = true;
            // 
            // rdjohn
            // 
            this.rdjohn.AutoSize = true;
            this.rdjohn.Location = new System.Drawing.Point(11, 19);
            this.rdjohn.Name = "rdjohn";
            this.rdjohn.Size = new System.Drawing.Size(82, 17);
            this.rdjohn.TabIndex = 0;
            this.rdjohn.TabStop = true;
            this.rdjohn.Text = "John Wick4";
            this.rdjohn.UseVisualStyleBackColor = true;
            // 
            // listbilgi
            // 
            this.listbilgi.FormattingEnabled = true;
            this.listbilgi.Location = new System.Drawing.Point(256, 147);
            this.listbilgi.Name = "listbilgi";
            this.listbilgi.Size = new System.Drawing.Size(189, 95);
            this.listbilgi.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 315);
            this.Controls.Add(this.listbilgi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soy;
        private System.Windows.Forms.RadioButton rdkd;
        private System.Windows.Forms.RadioButton rder;
        private System.Windows.Forms.Button btnsonuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_misir;
        private System.Windows.Forms.CheckBox chk_kola;
        private System.Windows.Forms.CheckBox chk_cips;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdhizli;
        private System.Windows.Forms.RadioButton rdyenil;
        private System.Windows.Forms.RadioButton rdjohn;
        private System.Windows.Forms.ListBox listbilgi;
    }
}

