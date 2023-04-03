namespace FormSecond
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
            this.rdBtnKadin = new System.Windows.Forms.RadioButton();
            this.rdBtnErkek = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBilgiGoster = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdUni = new System.Windows.Forms.RadioButton();
            this.rdLise = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdIlk = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txtBilgiAd = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBtnKadin
            // 
            this.rdBtnKadin.AutoSize = true;
            this.rdBtnKadin.Location = new System.Drawing.Point(18, 19);
            this.rdBtnKadin.Name = "rdBtnKadin";
            this.rdBtnKadin.Size = new System.Drawing.Size(52, 17);
            this.rdBtnKadin.TabIndex = 0;
            this.rdBtnKadin.TabStop = true;
            this.rdBtnKadin.Text = "Kadın";
            this.rdBtnKadin.UseVisualStyleBackColor = true;
            this.rdBtnKadin.CheckedChanged += new System.EventHandler(this.rdBtnKadin_CheckedChanged);
            this.rdBtnKadin.Click += new System.EventHandler(this.txtAd_TextChanged);
            this.rdBtnKadin.DragEnter += new System.Windows.Forms.DragEventHandler(this.radioButton1_DragEnter);
            // 
            // rdBtnErkek
            // 
            this.rdBtnErkek.AutoSize = true;
            this.rdBtnErkek.Location = new System.Drawing.Point(18, 57);
            this.rdBtnErkek.Name = "rdBtnErkek";
            this.rdBtnErkek.Size = new System.Drawing.Size(53, 17);
            this.rdBtnErkek.TabIndex = 1;
            this.rdBtnErkek.TabStop = true;
            this.rdBtnErkek.Text = "Erkek";
            this.rdBtnErkek.UseVisualStyleBackColor = true;
            this.rdBtnErkek.CheckedChanged += new System.EventHandler(this.rdBtnErkek_CheckedChanged);
            this.rdBtnErkek.Click += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnKadin);
            this.groupBox1.Controls.Add(this.rdBtnErkek);
            this.groupBox1.Location = new System.Drawing.Point(29, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // BtnBilgiGoster
            // 
            this.BtnBilgiGoster.Location = new System.Drawing.Point(266, 189);
            this.BtnBilgiGoster.Name = "BtnBilgiGoster";
            this.BtnBilgiGoster.Size = new System.Drawing.Size(75, 23);
            this.BtnBilgiGoster.TabIndex = 4;
            this.BtnBilgiGoster.Text = "Goster";
            this.BtnBilgiGoster.UseVisualStyleBackColor = true;
            this.BtnBilgiGoster.Click += new System.EventHandler(this.BtnBilgiGoster_Click);
            this.BtnBilgiGoster.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.BtnBilgiGoster.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdUni);
            this.groupBox2.Controls.Add(this.rdLise);
            this.groupBox2.Controls.Add(this.rdOrta);
            this.groupBox2.Controls.Add(this.rdIlk);
            this.groupBox2.Location = new System.Drawing.Point(29, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 154);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eğitim Durumu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdUni
            // 
            this.rdUni.AutoSize = true;
            this.rdUni.Location = new System.Drawing.Point(18, 84);
            this.rdUni.Name = "rdUni";
            this.rdUni.Size = new System.Drawing.Size(72, 17);
            this.rdUni.TabIndex = 3;
            this.rdUni.TabStop = true;
            this.rdUni.Text = "Üniversite";
            this.rdUni.UseVisualStyleBackColor = true;
            this.rdUni.Click += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // rdLise
            // 
            this.rdLise.AutoSize = true;
            this.rdLise.Location = new System.Drawing.Point(18, 63);
            this.rdLise.Name = "rdLise";
            this.rdLise.Size = new System.Drawing.Size(44, 17);
            this.rdLise.TabIndex = 2;
            this.rdLise.TabStop = true;
            this.rdLise.Text = "Lise";
            this.rdLise.UseVisualStyleBackColor = true;
            this.rdLise.Click += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(18, 42);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(65, 17);
            this.rdOrta.TabIndex = 1;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "Ortaokul";
            this.rdOrta.UseVisualStyleBackColor = true;
            this.rdOrta.Click += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // rdIlk
            // 
            this.rdIlk.AutoSize = true;
            this.rdIlk.Location = new System.Drawing.Point(18, 19);
            this.rdIlk.Name = "rdIlk";
            this.rdIlk.Size = new System.Drawing.Size(56, 17);
            this.rdIlk.TabIndex = 0;
            this.rdIlk.TabStop = true;
            this.rdIlk.Text = "İlkokul";
            this.rdIlk.UseVisualStyleBackColor = true;
            this.rdIlk.Click += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBilgi);
            this.groupBox3.Controls.Add(this.txtBilgiAd);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(446, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 239);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kişi Bilgileri";
            // 
            // lblBilgi
            // 
            this.lblBilgi.Location = new System.Drawing.Point(45, 94);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(207, 124);
            this.lblBilgi.TabIndex = 5;
            // 
            // txtBilgiAd
            // 
            this.txtBilgiAd.Enabled = false;
            this.txtBilgiAd.Location = new System.Drawing.Point(97, 22);
            this.txtBilgiAd.Name = "txtBilgiAd";
            this.txtBilgiAd.Size = new System.Drawing.Size(100, 20);
            this.txtBilgiAd.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(140, 48);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 7;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adınız";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(291, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Sigara Kullanıyormusunuz";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnBilgiGoster);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBtnKadin;
        private System.Windows.Forms.RadioButton rdBtnErkek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBilgiGoster;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdUni;
        private System.Windows.Forms.RadioButton rdLise;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.RadioButton rdIlk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TextBox txtBilgiAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
    }
}

