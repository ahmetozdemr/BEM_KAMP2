using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cizik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ciz;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int kalinlik=Convert.ToInt32(comboBox1.Text);
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(colorDialog1.Color, 10);
            Brush brush= new SolidBrush(colorDialog1.Color);
            p.Brush = brush;
            Point point1 = new Point(e.X, e.Y);
            Point point2 = new Point(e.X+kalinlik, e.Y-10);
            if (ciz)
            {
                g.DrawLine(p, point1, point2);
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
            ;
        }

        private void Renk_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                Renk.BackColor = colorDialog1.Color;
            }


        }
    }
}
