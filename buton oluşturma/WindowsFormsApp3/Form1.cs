using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            Random rnd=new Random();
            Button btn=new Button();
            btn.Text= sayac.ToString();
            int x=rnd.Next(0,this.ClientSize.Width-btn.Width);   
            btn.Width = btn.Height = 30;
            btn.Left = x;

            int y=rnd.Next(0,this.ClientSize.Height-btn.Height);
            btn.Top = y;

            btn.Click += Btn_Click1;
            btn.MouseDoubleClick += Btn_MouseDoubleClick;



            this.Controls.Add(btn);
        }

        private void Btn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            //Button yakalanan=sender as Button;
            Button yakalanan = (Button)sender ;
            yakalanan.BackColor= Color.Red;
            this.Controls.Remove(yakalanan);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
