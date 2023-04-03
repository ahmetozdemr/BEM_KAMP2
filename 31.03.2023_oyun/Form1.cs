using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31._03._2023_oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Location = new System.Drawing.Point(100, 100);
            button1.BackColor = Color.Red;
            timer1.Start();
            this.BackColor = Color.Yellow;
        }
        List<Point> list = new List<Point>();
        bool ciz;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Color.Red,4);
            Graphics graphics = this.CreateGraphics();
            Point point1 = new Point(e.X + 10, e.Y + 10);
            Point point2 = new Point(e.X, e.Y);
            graphics.DrawLine(pen, point1, point2);
            list.Add(point1);
            list.Add(point2);
            if (list.Count > 150)
            {
                for (byte i = 0; i < list.Count; i += 2)
                {
                    pen = new Pen(Color.Yellow, 4);
                    graphics.DrawLine(pen, list[i], list[i + 1]);

                }
                list.Clear();
            }
            //if (ciz)
            //{
            //    //g.DrawLine(p, point1, point2);              

            //}
            GC.Collect();
        }
        //private void Form1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    ciz = false;
        //}
        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ciz = true;

        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Random rnd = new Random();
            button1.Location = new System.Drawing.Point(rnd.Next(40, 500), rnd.Next(70, 350));
            label1.Text = button1.Location.X.ToString();
            label2.Text = button1.Location.Y.ToString();
            GC.Collect();
        }

        int point = 0;

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            point += 5;
            label3.Text = point.ToString();           
        }
    }

}
