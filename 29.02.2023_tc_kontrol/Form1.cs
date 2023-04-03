using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29._02._2023_tc_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ad, soyad, Tc;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int toplam = 0, onluk = 0;
            string text = "";
            text = mtxtTC.Text;
            if (text.Length == 11)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i < 10)
                        toplam += int.Parse(text[i].ToString());
                }
                onluk = toplam / 10;
                toplam = toplam - onluk * 10;
                if (toplam.ToString() == text[10].ToString())
                {
                    ad = txtAd.Text;
                    soyad = txtSoyad.Text;
                    Tc = mtxtTC.Text;
                    if (lstPerson.Items.Count > 2)
                        lstPerson.Items.Clear();
                    lstPerson.Items.Add(ad + " " + soyad + " " + Tc);
                }

                else
                    MessageBox.Show("Tc no yanlış");

            }
            else
                MessageBox.Show("11 haneli giriniz");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEnter.Enabled = false;
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (txtAd.Text != string.Empty && txtSoyad.Text != string.Empty && mtxtTC.Text != string.Empty)
                btnEnter.Enabled = true;
            else
                btnEnter.Enabled = false;
        }

    }
}
