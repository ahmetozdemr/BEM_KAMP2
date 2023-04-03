using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                comboBox5.BackColor = colorDialog1.Color;
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMarka.Text)
            {
                case "VOLKSWAGEN":
                    cmbModel.Items.Add("Passat");
                    cmbModel.Items.Add("Golf");
                    cmbModel.Items.Add("Cadyy");
                    break;
                case "OPEL":
                    cmbModel.Items.Add("Insignia");
                    cmbModel.Items.Add("Astra");
                    cmbModel.Items.Add("Mocca");
                    break;
                case "RENAULT":
                    cmbModel.Items.Add("Clio");
                    cmbModel.Items.Add("Megane");
                    cmbModel.Items.Add("Laguna");
                    break;
                case "AUDI":
                    cmbModel.Items.Add(Audi);
                    break;
                default:
                    break;
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string[] Audi;
        private void Form1_Load(object sender, EventArgs e)
        {
            Audi = new string[] { "A4", "q7", "A6" };
        }

        private void cmbMarka_Click(object sender, EventArgs e)
        {
            switch (cmbMarka.Text)
            {
                case "VOLKSWAGEN":
                    cmbModel.Items.Add("Passat");
                    cmbModel.Items.Add("Golf");
                    cmbModel.Items.Add("Cadyy");
                    break;
                case "OPEL":
                    cmbModel.Items.Add("Insignia");
                    cmbModel.Items.Add("Astra");
                    cmbModel.Items.Add("Mocca");
                    break;
                case "RENAULT":
                    cmbModel.Items.Add("Clio");
                    cmbModel.Items.Add("Megane");
                    cmbModel.Items.Add("Laguna");
                    break;
                case "AUDI":
                    cmbModel.Items.Add(Audi);
                    break;
                default:
                    break;
            }
        }

        private void cmbModel_Click(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            switch (cmbMarka.Text)
            {
                case "VOLKSWAGEN":

                    cmbModel.Items.Add("Passat");
                    cmbModel.Items.Add("Golf");
                    cmbModel.Items.Add("Cadyy");
                    break;
                case "OPEL":
                    cmbModel.Items.Add("Insignia");
                    cmbModel.Items.Add("Astra");
                    cmbModel.Items.Add("Mocca");
                    break;
                case "RENAULT":
                    cmbModel.Items.Add("Clio");
                    cmbModel.Items.Add("Megane");
                    cmbModel.Items.Add("Laguna");
                    break;
                case "AUDI":
                    foreach (var item in Audi)
                    {
                        cmbModel.Items.Add(item);
                    }

                    break;
                default:
                    break;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text=cmbMarka.Text;
            lvi.SubItems.Add(cmbModel.Text);
            lvi.SubItems.Add(cmbYakit.Text);
            lvi.SubItems.Add(dateTimePicker1.Text);
            lvi.SubItems[2].BackColor = button2.BackColor;



            listView1.Items[0].SubItems[0]
            listView1.Items.Add(lvi);   
        }
    }
}
