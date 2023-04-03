using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //bütün dialog pencerelerinde show dialog isminde metot
            //lar bulunur
            //bu metotlar dialog penceresini açmayı sağlar
            // tüm dialog pencereleri geriye dialog result tipinde değer döndürür
            //messagebox.show bir dialog penceresidir.


            DialogResult sonuc = fontDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                label1.Text = sonuc.ToString();

                label1.Font = fontDialog1.Font;

                //fontdialog font özelliğinde font dialog penceresinden seçilen font değerleri tutulur.
            }
            else if (sonuc == DialogResult.Cancel)
            {
                label1.Text = "Herhangi bir seçim yapılmadı";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnOpen_Click(object sender, EventArgs e)
        { 
            
           
            openFileDialog1.Filter = "png (*.png)|*.png|All files (*.*)|*.*";

            openFileDialog1.Title = "Dosya açınız";
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                label1.Text=openFileDialog1.FileName;//dizin ve dosya ismi
              string dosyaad = openFileDialog1.SafeFileName;//sadecedosya adı
               
            }
        }

        private void btnsakla_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Saklanacak dosya";
           DialogResult deger= saveFileDialog1.ShowDialog();
          saveFileDialog1.Filter = "png (*.png)|*.png|All files (*.*)|*.*";
            if (DialogResult.OK==deger)
            {

 string adres= saveFileDialog1.FileName;
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                button1.ForeColor = colorDialog1.Color;
                this.BackColor= colorDialog1.Color; 
            }
        }
    }
}
