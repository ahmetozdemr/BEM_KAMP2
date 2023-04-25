using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int flag = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=Northwind;User=sa;Password=123");
            SqlCommand cmd = new SqlCommand("Select * from Kategoriler");
            SqlCommand cmd2 = new SqlCommand("Select * from Tedarikciler");
            SqlCommand cmd3 = new SqlCommand("Select * from Musteriler");
            cmd.Connection = conn;
            cmd2.Connection = conn;
            cmd3.Connection = conn;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
             

                while (dr.Read())
                {
                    listView2.Items.Add(dr["kategoriadi"].ToString());
                    listView2.Items[flag].SubItems.Add(dr["tanimi"].ToString());
                    flag++;
                }
                dr.Close();
                flag = 0;
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    listView1.Items.Add(dr2["sirketadi"].ToString());
                    listView1.Items[flag].SubItems.Add(dr2["musteriadi"].ToString());
                    listView1.Items[flag].SubItems.Add(dr2["musteriunvani"].ToString());
                    listView1.Items[flag].SubItems.Add(dr2["adres"].ToString());
                    listView1.Items[flag].SubItems.Add(dr2["sehir"].ToString());
                    flag++;
                }
                dr2.Close();
                flag = 0;
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    listView3.Items.Add(dr3["MusteriID"].ToString());
                    listView3.Items[flag].SubItems.Add(dr3["sirketadi"].ToString());
                    listView3.Items[flag].SubItems.Add(dr3["musteriadi"].ToString());
                    listView3.Items[flag].SubItems.Add(dr3["musteriunvani"].ToString());
                    listView3.Items[flag].SubItems.Add(dr3["adres"].ToString());
                    listView3.Items[flag].SubItems.Add(dr3["sehir"].ToString());
                    flag++;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
