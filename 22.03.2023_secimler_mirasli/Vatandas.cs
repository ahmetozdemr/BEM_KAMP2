using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03._2023_secimler_mirasli
{
    internal class Vatandas : _Vatandas
    {
        public override string Ad { get; set; }
        public override string Soyad { get; set; }
        public override byte Yas { get; set; }
        public Vatandas()
        {

        }
        public Vatandas(string ad, string soyad, byte yas)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Yas = yas;
        }

        public override void OyKullan(Milletvekili mv, Cumhurbaskani cb)
        {
            if (this.Yas > 17)
            {
                mv.OySayisi++;
                cb.OySayisi++;
            }
            else
                Console.WriteLine(this.Ad + " " + this.Soyad + " yaşı küçük olduğu için oy kullanamaz");
        }
    }
}
