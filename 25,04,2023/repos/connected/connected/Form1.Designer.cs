namespace connected
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
            this.LstUrunler = new System.Windows.Forms.ListBox();
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.lstTedarikciler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstUrunler
            // 
            this.LstUrunler.FormattingEnabled = true;
            this.LstUrunler.Location = new System.Drawing.Point(31, 32);
            this.LstUrunler.Name = "LstUrunler";
            this.LstUrunler.Size = new System.Drawing.Size(207, 329);
            this.LstUrunler.TabIndex = 0;
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.Location = new System.Drawing.Point(264, 32);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(191, 329);
            this.lstKategoriler.TabIndex = 1;
            // 
            // lstTedarikciler
            // 
            this.lstTedarikciler.FormattingEnabled = true;
            this.lstTedarikciler.Location = new System.Drawing.Point(481, 32);
            this.lstTedarikciler.Name = "lstTedarikciler";
            this.lstTedarikciler.Size = new System.Drawing.Size(202, 329);
            this.lstTedarikciler.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.lstTedarikciler);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.LstUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstUrunler;
        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.ListBox lstTedarikciler;
    }
}

