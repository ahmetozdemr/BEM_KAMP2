using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ciz;
        int mx, my;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Random ran = new Random();
            
            Graphics g = this.CreateGraphics();
            int deneme=ran.Next(1,6);
            Pen p=new Pen(Color.Black, 3);
            if (deneme == 5) {
                p = new Pen(Color.Black, 3);
            }
            else if (deneme == 1)
            {
                p = new Pen(Color.MediumBlue, 3);

            }
            else if (deneme == 2)
            {
                 p = new Pen(Color.Red, 3);
            }
            else if (deneme == 3)
            {
                p = new Pen(Color.Yellow, 3);
            }
            else if (deneme == 4)
            {
                p = new Pen(Color.Green, 3);
            }
            mx = e.X;
            my = e.Y;
            Point point1 = new Point(e.X, e.Y);
            Point point2 = new Point(e.X+30, e.Y-30);
           
            if (ciz)
            {
                g.DrawLine(p, point1, point2);
               
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            mx = e.X;
            my = e.Y;
        }
    }
}
