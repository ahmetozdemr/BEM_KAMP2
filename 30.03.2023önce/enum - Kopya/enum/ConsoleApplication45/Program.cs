using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            Ders ders1 = new Ders();
            ders1.dersin_ad = "matematik";
            ders1.dersin_akts = 7;

            Ders ders2 = new Ders();
            ders2.dersin_ad = "fizik";
            ders2.dersin_akts = 6;

            Ders ders3 = new Ders();
            ders2.dersin_ad = "kimya";
            ders2.dersin_akts = 5;

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ogrenci_adi = "Ali";
            ogrenci.ogrenci_numarasi = 1287;
            ogrenci.aldigi_dersler = ders1;

            Console.WriteLine("Adı: " + ogrenci.ogrenci_adi + " olan öğrencinin numarası : " + ogrenci.ogrenci_numarasi);
            Console.WriteLine(ogrenci.ogrenci_adi + " nin en sevdiği ders " + ogrenci.aldigi_dersler.dersin_ad + " ve bu dersin akts'si: " + ogrenci.aldigi_dersler.dersin_akts);
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Toplam alınan ders sayısı " + Ders.ders_sayisi);
            Console.ReadKey();

        }
    }

    class Ogrenci
    {

        public string ogrenci_adi { get; set; }
        public int ogrenci_numarasi { get; set; }
        public Ders aldigi_dersler { get; set; }

        public Ogretmen ogretmen { get; set; }


    }
    struct Ogretmen
    {
        public byte ogrenci_sayisi { get; set; }
        public string ogretmen_adi { get; set; }
        public Ders verdigi_dersler { get; set; }

    }

    class Ders
    {

        public Ders()
        {
            ders_sayisi++;
        }
        public static int ders_sayisi { get; set; }
        public byte dersin_akts { get; set; }
        public string dersin_ad { get; set; }


    }

}
