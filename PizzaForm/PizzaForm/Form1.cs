using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal ek;
        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat { Adi = "Küçük", Carpan = 1 };
            Ebat orta = new Ebat { Adi = "Orta", Carpan = 1.25 };
            Ebat buyuk = new Ebat { Adi = "Büyük", Carpan = 1.75 };
            Ebat maxi = new Ebat { Adi = "Maxi", Carpan = 2 };
            cmbEbat.Items.Add(kucuk);
            cmbEbat.Items.Add(orta);
            cmbEbat.Items.Add(buyuk);
            cmbEbat.Items.Add(maxi);




            KenarTip ince = new KenarTip { Adi = "İnce Kenar", ekFiyat = 0 };
            rbInceKenar.Tag = ince;
            KenarTip kalin = new KenarTip { Adi = "Kalın Kenar", ekFiyat = 2 };
            rbKalinKenar.Tag = kalin;
            ek = kalin.ekFiyat;

            Pizza Klasik = new Pizza { Adi = "Klasik", Fiyat = 80 };
            Pizza karma = new Pizza { Adi = "Karma", Fiyat = 100 };
            Pizza Turkish = new Pizza { Adi = "Turkish", Fiyat = 200 };
            Pizza Tuna = new Pizza { Adi = "Tuna", Fiyat = 120 };
            Pizza Akdeniz = new Pizza { Adi = "Akdeniz", Fiyat = 100 };
            Pizza karadeniz = new Pizza { Adi = "Karadeniz", Fiyat = 250 };
            listPizzalar.Items.Add(Klasik);
            listPizzalar.Items.Add(karma);
            listPizzalar.Items.Add(Turkish);
            listPizzalar.Items.Add(Tuna);
            listPizzalar.Items.Add(Akdeniz);
            listPizzalar.Items.Add(karadeniz);






        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Pizza p = listPizzalar.SelectedItem as Pizza;
            //yada
            // Pizza pt = (Pizza)listPizzalar.SelectedItem;
            p.Ebati = cmbEbat.SelectedItem as Ebat;
            p.KenarTipi = rbInceKenar.Checked ? (KenarTip)rbInceKenar.Tag : (KenarTip)rbKalinKenar.Tag;
            p.Malzemeler = new List<string>();

            foreach (CheckBox ctrl in groupBox1.Controls)
            {
                if (ctrl.Checked)
                {
                    p.Malzemeler.Add(ctrl.Text);
                }

            }

            decimal tutar = nudAdet.Value * p.Fiyat + 
                (decimal)p.Ebati.Carpan + p.KenarTipi.ekFiyat; 
            txtTuta.Text = tutar.ToString();


            //if (rbKalinKenar.Checked)
            //{
            //    decimal tutar = nudAdet.Value * p.Fiyat + ek; 
            //    txtTuta.Text = tutar.ToString();
            //}
            //else
            //{
            //    decimal tutar = nudAdet.Value * p.Fiyat;
            //    txtTuta.Text = tutar.ToString();
            //}


            


        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
