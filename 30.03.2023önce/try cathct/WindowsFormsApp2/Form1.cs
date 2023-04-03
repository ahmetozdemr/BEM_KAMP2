using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
            derleme hatası
            runtime hataları
            mantıksal hatalar
             */






            try
            {

                
                int say1 = Convert.ToInt32(txtSay1.Text);
                int say2 = Convert.ToInt32(txtSay2.Text);
                int toplam = say1 + say2;
                txtSay1.Text = string.Empty;
                txtSay2.Text = string.Empty;
                lblSonuc.Text = toplam.ToString();
            }
            catch (FormatException pk)
            {

                MessageBox.Show(pk.Message+" Lütfen sayısal değerler giriniz");
            }
            catch (OverflowException pk)
            {
                MessageBox.Show(pk.Message +" daha küçük sayı giriniz");
            }



        }
    }
}
