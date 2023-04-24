using System.Data.SqlClient;

namespace AdoNet1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Server=.;Database=NorthwindTR;Trusted_Connection=true";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Urunler";
            cmd.Connection = baglanti;
           // baglanti.Close();
            baglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string adi = reader["UrunAdi"].ToString();
                string fiyat = reader["BirimFiyati"].ToString();
                string stok = reader["HedefStokDuzeyi"].ToString();
                listBox1.Items.Add(string.Format("{0}-{1}-{2}", adi, fiyat, stok));
                Console.WriteLine();
            }
            baglanti.Close();
        }
    }
}

/*using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNet1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //baglanti.ConnectionString = "Server=DESKTOP-S9B1IE8;Database=Northwind;Intagrated Security=true";//WýnowsAutohebntýcatýon


            //SqlConnection bglt = new SqlConnection(@"server=DESKTOP-2P0M1AR;initial catalog=Northwind;integrated security=false;user id=sa;password=123");
            //bglt.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Urunler", bglt);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read()) 
            //{
            //    Console.WriteLine(reader["UrunAdi"].ToString());

            //}
            //bglt.Close();

            Product product = new Product();
            SqlConnection baglanti = product.BaglantiKur();
            //product.TabloyaGoreListele("Kategoriler", baglanti);

            // product.TabloOlustur(baglanti);
            //product.KayýtEkleme("melahat",8,baglanti);
            product.KayýtSil(baglanti);





            Console.ReadLine();


        }

        public class Product
        {
            public SqlConnection BaglantiKur()
            {
                SqlConnection bglt = new SqlConnection(@"server=DESKTOP-2P0M1AR;initial catalog=Northwind;integrated security=false;user id=sa;password=123");
                if (bglt.State == ConnectionState.Closed)
                {
                    bglt.Open();
                }
                return bglt;

            }
            public void TabloyaGoreListele(string tabload, SqlConnection conn)
            {
                conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from " + tabload, conn);
                SqlDataReader liste = cmd.ExecuteReader();
                while (liste.Read())
                {
                    Console.WriteLine("{0}-{1}", liste[0].ToString(), liste[1].ToString());
                }
                conn.Close();
            }
            public void UrunListele(SqlConnection conn)
            {
                conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from urunler", conn);
                SqlDataReader liste = cmd.ExecuteReader();
                while (liste.Read())
                {
                    Console.WriteLine(liste[1].ToString());
                }
                conn.Close();
            }
            public void TabloOlustur(SqlConnection conn)
            {
                //conn.Close();
                conn.Open();

                try
                {
                    Console.WriteLine("Bir tablo ismi yazýnýz");
                    string tabload = Console.ReadLine();
                    SqlCommand sql = new SqlCommand(@"Create Table " + tabload + "(id int identity(1, 1) not null, ogrenciAd nvarchar(50), ogrenciNo smallint)", conn);
                    sql.ExecuteNonQuery();
                    Console.WriteLine(tabload + "  isminde bir tablo oluþturuldu");
                    conn.Close();
                }
                catch (Exception)
                {

                    Console.WriteLine("Bir hata oluþtu");
                }


            }
            public void KayýtEkleme(string ogrAd, int ogrNo, SqlConnection connection)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into ogr (ogrenciAd,ogrenciNo) values ('" + ogrAd + "','" + ogrNo + "')", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine(ogrAd + " Listeye bir kayýt eklendi");
                connection.Close();



            }
            public void KayýtSil(SqlConnection bglnt)
            {
                TabloyaGoreListele("ogr", bglnt);
                if (bglnt.State == ConnectionState.Closed)
                {
                    bglnt.Open();

                }


                Console.WriteLine("Kaç nolu kaydý silmek istersin");
                int deger = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd = new SqlCommand("Delete from ogr where id=" + deger, bglnt);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Kayýt silindi");
            }

        }

    }
}


 */

