using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timerr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;
        int dakika = 0;
        int saat = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;    
            if(saniye == 60)
            {
                saniye = 0;
                dakika++;
                label2.Text = dakika.ToString();
                if(dakika == 60)
                {
                    dakika = 0;
                    saat++;
                    label3.Text = saat.ToString();
                }
            }
            label1.Text = saniye.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();  
        }
    }
}
