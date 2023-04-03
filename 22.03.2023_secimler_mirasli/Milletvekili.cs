using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03._2023_secimler_mirasli
{
    internal class Milletvekili : _Vatandas
    {
        public override string Ad { get; set; }
        public override string Soyad { get; set; }
        public override byte Yas { get; set; }
        public override int OySayisi { get => base.OySayisi; set => base.OySayisi = value; }

        public Milletvekili() : base()
        {

        }
        public Milletvekili(string ad, string soyad, byte yas) : base()
        {
            if (yas < 18)
            {
                this.Ad = null;
                this.Soyad = null;
                this.Yas = 0;
                Console.WriteLine($"yaşı 18'den küçük olduğu için aday olamaz  ");
            }
            else
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.Yas = yas;
            }

            OySayisi = 0;
        }



        public override void OyKullan(Milletvekili mv, Cumhurbaskani cb)
        {
            mv.OySayisi++;
            cb.OySayisi++;
        }
    }
}
