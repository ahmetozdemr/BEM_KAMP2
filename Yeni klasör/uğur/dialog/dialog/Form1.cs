using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
           DialogResult sonuc= fontDialog1.ShowDialog();

           if (sonuc==DialogResult.OK)
           {
               lblDeneme.Font = fontDialog1.Font;
           }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = fontDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                lblDeneme.Font = fontDialog1.Font;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"";

            openFileDialog1.Filter = "Jpeg dosyası (*.jpeg)|*.jpeg|Jpg Dosyası(*.jpg)|*.jpg|Png Dosyası(*.png)|*.png";

            openFileDialog1.Title = "Resim Dosyası";
            DialogResult sonuc = openFileDialog1.ShowDialog();

            if (sonuc==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                lblDeneme.Text = openFileDialog1.FileName;
                lblDeneme.Text = openFileDialog1.SafeFileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydet";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                lblDeneme.Text = saveFileDialog1.FileName;
            }
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                lblDeneme.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();

            if (sonuc==DialogResult.OK)
            {
                lblDeneme.BackColor = colorDialog1.Color;
            }
        }
    }
}
