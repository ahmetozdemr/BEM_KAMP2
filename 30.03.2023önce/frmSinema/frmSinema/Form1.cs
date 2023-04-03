using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0; string film, yiyecek = ""; double hesap = 0; double Toplam = 0; double[] fiyat = new double[4];

        private void Form1_Load(object sender, EventArgs e)
        {
            fiyat[0] = 30;
            fiyat[1] = 10;
            fiyat[2] = 20;
            fiyat[3] = 30;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            sayac += 1;

            if (rdFilm1.Checked)
            {
                film = rdFilm1.Text; hesap += 50;
            }
            else if (rdFilm2.Checked)
            {
                film = rdFilm2.Text; hesap += 40;
            }
            else if (rdFilm3.Checked)
            {
                film = rdFilm3.Text; hesap += 60;
            }
            else if (rdFilm4.Checked)
            {
                film = rdFilm4.Text; hesap += 35;
            }


            foreach (var kontrol in groupBox1.Controls)

            {

                //Seçili olan bütün checkboxların

                //seçili olma durumunu kaldırıyoruz.

                CheckBox cbox = new CheckBox();

                if (kontrol is CheckBox)

                {
                    cbox = (CheckBox)kontrol;
                    if (cbox.Checked)
                    {
                        Toplam = Toplam + fiyat[cbox.TabIndex];
                    }





                    //cbox.Checked = false;

                }

            }



            //if (checkBox1.Checked)
            //{
            //    yiyecek += checkBox1.Text;hesap += 20;
            //}
            //if (checkBox2.Checked)
            //{
            //    yiyecek += checkBox2.Text;hesap += 35;

            //}
            //if (checkBox3.Checked)
            //{
            //    yiyecek += checkBox3.Text;hesap += 90;
            //}
            //if (checkBox4.Checked)
            //{
            //    yiyecek += checkBox4.Text;hesap += 90;
            //}



            lstListe.Items.Add(sayac + ". " + txtAd.Text + " " + txtSoyAd.Text + " " + " " +
                   comboBox1.Text + " " + film + " " + yiyecek);

            label3.Text = Toplam.ToString();
        }
    }
}
