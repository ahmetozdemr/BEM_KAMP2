using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int hesap = 0;
        string cinsiyet, secilenfilm, secilenyiyecek;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_ad.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rder.Checked)
            {
                cinsiyet = rder.Text;
            }
            else if (rdkd.Checked)
            {
                cinsiyet = rdkd.Text;
            }

            if (rdjohn.Checked)
            {
                hesap += 20;
                secilenfilm = rdjohn.Text;
            }
            else if (rdhizli.Checked)
            {
                hesap += 20;
                secilenfilm = rdhizli.Text;
            }
            else if (rdyenil.Checked)
            {

                hesap += 20;
                secilenfilm = rdyenil.Text;
            }

            if (chk_cips.Checked)
            {
                hesap += 8;
                secilenyiyecek = chk_cips.Text;
            }
            if (chk_kola.Checked)
            {
                hesap += 4;
                secilenyiyecek = chk_kola.Text;
            }
            if (chk_misir.Checked)
            {
                hesap += 20;
                secilenyiyecek = chk_misir.Text;
            }
            listbilgi.Items.Add(txt_ad.Text);
            listbilgi.Items.Add(txt_soy.Text);
            listbilgi.Items.Add(cinsiyet);
            listbilgi.Items.Add(secilenfilm);
            listbilgi.Items.Add(secilenyiyecek);
            listbilgi.Items.Add("Toplam tutar="+hesap.ToString());

            
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox)
                {
                    groupBox1.Controls[i].Text =string.Empty;
                }
                if (groupBox1.Controls[i] is RadioButton)
                {
                   
                    rder.Checked = false;  
                    rdkd.Checked = false;  
                }
            }
            chk_cips.Checked = false;
            chk_kola.Checked = false;
            chk_misir.Checked = false;
            rdhizli.Checked = false;
            rdjohn.Checked = false;
            rdyenil.Checked = false;
            hesap = 0;
        }
    }
}
