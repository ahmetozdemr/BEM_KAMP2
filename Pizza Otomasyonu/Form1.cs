using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Otomasyonu
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
            Ebat kucuk = new Ebat { adi = "Küçük", carpan = 1 };
            Ebat orta = new Ebat { adi = "Orta", carpan = 1.25 };
            Ebat buyuk = new Ebat { adi = "Büyük", carpan = 1.75 };
            Ebat maxi = new Ebat { adi = "Maxi", carpan = 2 };

            cmb_ebat.Items.Add(kucuk);
            cmb_ebat.Items.Add(orta);
            cmb_ebat.Items.Add(buyuk);
            cmb_ebat.Items.Add(maxi);

            KenarTip ince = new KenarTip { adi = "İnce Kenar", ek_fiyat = 0 };
            rd_ince.Tag = ince;
            KenarTip kalin = new KenarTip { adi = "Kalın Kenar", ek_fiyat = 2 };
            rd_kalin.Tag = kalin;
            ek = kalin.ek_fiyat;

            Pizza Klasik = new Pizza { adi = "Klasik", fiyat = 80 };
            Pizza Karma = new Pizza { adi = "Karmaşık", fiyat = 100 };
            Pizza Turkish = new Pizza { adi = "Turkish", fiyat = 200 };
            Pizza Tuna = new Pizza { adi = "Tuna", fiyat = 120 };
            Pizza Akdeniz = new Pizza { adi = "Akdeniz", fiyat = 100 };
            Pizza Karadeniz = new Pizza { adi = "Karadeniz", fiyat = 250 };

            ListPizzalar.Items.Add(Klasik);
            ListPizzalar.Items.Add(Karma);
            ListPizzalar.Items.Add(Turkish);
            ListPizzalar.Items.Add(Tuna);
            ListPizzalar.Items.Add(Akdeniz);
            ListPizzalar.Items.Add(Karadeniz);

        }
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            Pizza p = ListPizzalar.SelectedItem as Pizza;
            p.Ebati = cmb_ebat.SelectedItem as Ebat;
            p.KenarTipi = rd_ince.Checked ? (KenarTip)rd_ince.Tag : (KenarTip)rd_kalin.Tag;

            p.Malzemeler = new List<string>();


            foreach (CheckBox ctrl in grp_malzemeler.Controls)
            {
                if (ctrl.Checked)
                {
                    p.Malzemeler.Add(ctrl.Text);
                }

            }
            decimal tutar = numeric_adet.Value * p.Tutar;

            txt_tutar.Text = tutar.ToString();

            s = new Siparis();
            s.Pizza = p;
            s.Adet = (int)numeric_adet.Value;

        }
        Siparis s;
        private void btn_sepete_ekle_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                listSepet.Items.Add(s);
            }

        }
    }
}
