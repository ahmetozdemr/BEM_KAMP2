using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        bool ciz;
        int mx, my;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
             int kalinlik=Convert.ToInt32(comboBox1.Text);
            Graphics g =this.CreateGraphics();
            Pen p =new Pen(button1.BackColor, 4);
            mx = e.X;
            my = e.Y;
            Point point1 = new Point(e.X+10, e.Y+10);
            Point point2 = new Point(10 , 10);

            if (ciz)
            {
                //g.DrawLine(p, point1, point2);
                g.DrawLine(p, point1, point2);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          DialogResult renk=  colorDialog1.ShowDialog();
            if (renk==DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            mx = e.X;
            my = e.Y;
        }
    }
}
