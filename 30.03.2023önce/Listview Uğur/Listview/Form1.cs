using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi=new ListViewItem();
            
            lvi.Text=txtAd.Text;
            lvi.SubItems.Add (txtSoyad.Text);
            lvi.SubItems.Add(maskedTextBox1.Text);
            lvi.SubItems.Add(dateTimePicker1.Value.ToShortDateString());
            lvi.SubItems.Add(string.Empty);
            lvi.SubItems[3].BackColor = btnRenk.BackColor;
           

            listView1.Items.Add(lvi);
            txtAd.Text = "";
            txtSoyad.Text = "";
            maskedTextBox1.Text = "";
    
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.Items.Count>0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtAd.Text = item.SubItems[0].Text;
                txtSoyad.Text = item.SubItems[1].Text;
                maskedTextBox1.Text = item.SubItems[2].Text;
               }
      }

        private void btnRenk_Click(object sender, EventArgs e)
        {
          DialogResult sonuc =  colorDialog1.ShowDialog();
          if (sonuc==DialogResult.OK)
          {
              btnRenk.BackColor = colorDialog1.Color;
          }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult sonuc= colorDialog1.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                txtAd.BackColor = colorDialog1.Color;   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSoyad.BackColor= Color.Bisque; 
        }
    }
    }

