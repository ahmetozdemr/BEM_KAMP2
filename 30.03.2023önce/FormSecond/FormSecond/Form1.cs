using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSecond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_DragEnter(object sender, DragEventArgs e)
        {
            groupBox1.BackColor = Color.White;
        }

        private void rdBtnKadin_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rdBtnErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Beige;
        }


        string bilgi, egitimdurumu;

        private void BtnBilgiGoster_Click(object sender, EventArgs e)
        {




            txtBilgiAd.Text = txtAd.Text;
            if (rdBtnErkek.Checked)
            {
                bilgi = "Erkek";
            }
            else
            {
                bilgi = "Kadın";
            }

            if (rdIlk.Checked)
            {
                egitimdurumu = "İlkokul";
            }
            else if (rdOrta.Checked)
            {
                egitimdurumu = "Ortaokul";
            }
            else if (rdLise.Checked)
            {
                egitimdurumu = "Lise";
            }
            else if (rdUni.Checked)
            {
                egitimdurumu = "Üniversite";
            }
            else
            {
                egitimdurumu = "seçilmedi";
            }

            lblBilgi.Text = txtBilgiAd.Text + " adlı kişinin" + " cinsiyeti " + bilgi + "dir " +
                " Eğitim durumu " + egitimdurumu + " ";

        }

        bool Btnaktif;


        private void Form1_Load(object sender, EventArgs e)
        {
            BtnBilgiGoster.Enabled = ButonAktif();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            
                BtnBilgiGoster.Enabled = ButonAktif();

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           BtnBilgiGoster.Enabled= ButonAktif();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            BtnBilgiGoster.Enabled = ButonAktif();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Lütfen sağlığınız için sigarayı bırakın");

            }
            else { MessageBox.Show("Sigaranın ölümcül olduğuna dair bilimsel bir kanıt yoktur."); }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        bool ButonAktif()
        {

            if ((rdBtnKadin.Checked||rdBtnErkek.Checked) &&
                (rdIlk.Checked||rdOrta.Checked||rdLise.Checked||rdUni.Checked))
            {
                return true;
            }
            else { return false; }
        
        }
    }
}
