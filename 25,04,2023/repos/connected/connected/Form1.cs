using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace connected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=Northwind;User=sa;Pwd=123");

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunLıstele();
            KategoriListele();
            TedarikListele();
        }

        private void TedarikListele()
        {
            SqlCommand cmd = new SqlCommand("Select * from tedarikciler",baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lstTedarikciler.Items.Add(reader[1].ToString());
                }
            baglanti.Close();
        }

        private void UrunLıstele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Urunler";
            cmd.Connection = baglanti;
            baglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string adi = reader["UrunAdi"].ToString();
                string fiyat = reader["BirimFiyati"].ToString();
                string stok = reader["HedefStokDuzeyi"].ToString();
                LstUrunler.Items.Add(string.Format("{0}-{1}-{2}", adi, fiyat, stok));

            }

            baglanti.Close();
        }

        private void KategoriListele()
        {
            SqlCommand cmd = new SqlCommand("Select * from Kategoriler", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lstKategoriler.Items.Add(reader[1].ToString());
            }
            baglanti.Close();
        }
    }
}
