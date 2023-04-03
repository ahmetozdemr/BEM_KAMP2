using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        #region

        bool ciz;
        int baslaX, baslaY;//mouse bulunduğu koordinatı tutacak

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            baslaX = e.X;
            baslaY = e.Y;
            /*MouseDown yani farenin bir tuşuna tıklandığı anda mouseın yaptığı işlemler  e değişkeninde saklanır e.X ile x  e.Y ile y koordinatını almış olduk.*/

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            /*Mouse move  mouse basılı iken mouse taşıma işlemi yaparken yapılacak işlemlerdir 
             */

            Graphics g = this.CreateGraphics();
            /*çizimi yapabilmek için çizimin nerede yapılacağını belirtik form üzerinde olacağı belirtildi     */
            Pen p = new Pen(Color.Yellow, 3);
            Point point1 = new Point(baslaX, baslaY);//başlangıç noktasını aldık
            Point point2 = new Point(e.X, e.Y);

            if (ciz)
            {
                g.DrawLine(p, point1, point2);//g drawline düz çizgi çizer

                baslaX = e.X;
                baslaY = e.Y;//mouse nin durduğu son nokta tekrar başlangıç değerlei yaptık

                Rectangle myRectangle = new Rectangle(20, 20, 250, 200);

                g.DrawRectangle(p, myRectangle);

                g.DrawEllipse(p, myRectangle);


                Font myFont = new System.Drawing.Font("Helvetica", 36);

                Brush myBrush = new SolidBrush(System.Drawing.Color.Red);

                g.DrawString("Merhaba C#", myFont, myBrush, 30, 30);

            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }
    }
}
