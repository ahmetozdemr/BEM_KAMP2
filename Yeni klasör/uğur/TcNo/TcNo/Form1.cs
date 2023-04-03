﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (maskedTextBox1.MaskFull)
            {
                string sonHane = maskedTextBox1.Text[10].ToString();

                int sonHaneNum = Convert.ToInt32(sonHane);
                if (sonHaneNum % 2 != 0)
                {
                    MessageBox.Show("Tc Kimlik no Hatalıdır");
                }
                else
                {
                    int toplam = 0;
                    for (int i = 0; i < maskedTextBox1.Text.Length - 1; i++)
                    {
                        string rakam = maskedTextBox1.Text[i].ToString();
                        toplam += Convert.ToInt32(rakam);

                    }
                    if (toplam % 10 == sonHaneNum)
                    {
                        MessageBox.Show("TCKN Doğrudur!");
                    }
                    else
                    {
                        MessageBox.Show("Tc Kimlik no Hatalıdır");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen 11 haneli no giriniz");
            }





        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
