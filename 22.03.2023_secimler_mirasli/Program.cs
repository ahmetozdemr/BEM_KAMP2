using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03._2023_secimler_mirasli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cumhurbaskani ahmet = new Cumhurbaskani("ahmet", "aslan", 55);
            Cumhurbaskani mehmet = new Cumhurbaskani("mehmet", "kısa", 49);
            Milletvekili fatih = new Milletvekili("fatih", "polat", 26);
            Milletvekili beyza = new Milletvekili("beyza", "daldal", 22);
            Vatandas furkan = new Vatandas("furkan", "ertantu", 26);
            Vatandas akif = new Vatandas("akif", "sezer", 53);
            Vatandas sezgin = new Vatandas("sezgin", "bezgin", 17);
            Vatandas ilker = new Vatandas("ilker", "şenel", 26);



            ahmet.OyKullan(beyza, ahmet);
            mehmet.OyKullan(beyza, mehmet);
            beyza.OyKullan(beyza, ahmet);
            fatih.OyKullan(fatih, ahmet);
            ilker.OyKullan(fatih, ahmet);
            furkan.OyKullan(fatih, mehmet);
            akif.OyKullan(fatih, ahmet);
            sezgin.OyKullan(fatih, mehmet);


            Secim2023.CbEkle(mehmet);
            Secim2023.CbEkle(ahmet);
            Secim2023.MvEkle(beyza);
            Secim2023.MvEkle(fatih);

            Secim2023.SonucGoster();

            Console.ReadLine();
        }

    }
    interface IAd
    {
        string Ad { get; set; }
    }
    interface ISoyad
    {
        string Soyad { get; set; }
    }
    interface IYas
    {
        byte Yas { get; set; }
    }
    interface IOyKullanabilme
    {
        void OyKullan(Milletvekili mv, Cumhurbaskani cb);
    }
    interface IOySayisi
    {
        int OySayisi { get; set; }
    }
}
