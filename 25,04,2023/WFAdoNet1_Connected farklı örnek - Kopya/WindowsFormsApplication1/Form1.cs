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

namespace WindowsFormsApplication1
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
            SqlCommand cmd = new SqlCommand("Select * from urunler");
            cmd.Connection = conn;
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listView1.Items.Add(dr["urunadi"].ToString());
                    listView1.Items[flag].SubItems.Add(dr["birimfiyati"].ToString());
                    comboBox1.Items.Add(dr["urunadi"].ToString());
                    comboBox2.Items.Add(dr["birimfiyati"].ToString());
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
