using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Temmuz_2016
{
    class Program
    {
        class AyakkabiFabrikasi
        {
            public int AyakkabiNum { get; set; }
            public string AyakkabiRenk { get; set; }
            public int Fiyat { get; set; }
            public Boolean Bagcik { get; set; }
            public string AyakkabiTürü { get; set; }

            virtual public void Ozellikler()
            {

            }
        }
        class Bot : AyakkabiFabrikasi
        {
            public override void Ozellikler()
            {
                string bagcik = (Bagcik == true) ? "var" : "yok";
                Console.Write("Ayakkabý türü: {0}\nAyakkabi Numarasý: {1}\nAyakkabý Rengi: {2}\nAyakkabýnýn Fiyatý: {3}TL\nBaðcýk: {4}", AyakkabiTürü, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);

            }
        }
        class Sandalet : AyakkabiFabrikasi
        {
            public override void Ozellikler()
            {
                string bagcik = (Bagcik == true) ? "var" : "yok";
                Console.Write("Ayakkabý türü: {0}\nSandalet Numarasý: {1}\nSandalet Rengi: {2}\nSandalet Fiyatý: {3}TL\nBaðcýk: {4} \n", AyakkabiTürü, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
            }
        }
        class SporAyakkabi : AyakkabiFabrikasi
        {
            public override void Ozellikler()
            {

            }
        }
        class Kosu : SporAyakkabi
        {
            public override void Ozellikler()
            {
                string bagcik = (Bagcik == true) ? "var" : "yok";
                Console.Write("Ayakkabý türü: {0}\nAyakkabi Numarasý: {1}\nAyakkabý Rengi: {2}\nAyakkabýnýn Fiyatý: {3}TL\n Baðcýk: {4}", AyakkabiTürü, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
            }
        }
        class Futbol : SporAyakkabi
        {
            public override void Ozellikler()
            {
                string bagcik = (Bagcik == true) ? "var" : "yok";
                Console.Write("Ayakkabý türü: {0}\nAyakkabi Numarasý: {1}\nAyakkabý Rengi: {2}\nAyakkabýnýn Fiyatý: {3}TL\n Baðcýk: {4}", AyakkabiTürü, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Kosu Run = new Kosu();
                Futbol Foot = new Futbol();
                Bot Bot = new Bot();
                Sandalet Terlik = new Sandalet();
                bidaha:
                Console.Clear();
                Console.WriteLine("**********Hoþgeldiniz**********\n\n\tAyakkabýTürü Seçiniz\n\t1-Bot\n\t2-Koþu\n\t3-Futbol\n\t4-Sandalet");
                byte Secim = byte.Parse(Console.ReadLine());
                if (Secim<1||Secim>4)
                {
                    Console.WriteLine("Geçersiz Bir Seçim\nProgram Tekrar Baþlatýlýyor.");
                    System.Threading.Thread.Sleep(2000);
                    goto bidaha;
                }
                Console.WriteLine("Ayakkabý Rengini Giriniz(Mavi,Yeþil,Siyah...)");
                string Renk = Console.ReadLine();

                Console.WriteLine("Baðcýk var mý? (true/false)");
                Boolean Bagcik = Boolean.Parse(Console.ReadLine());

                tekrar:
                Console.WriteLine("Ayakkabý Numarasý Seçiniz(1/47)");
                byte Numara = byte.Parse(Console.ReadLine());

                switch (Secim)
                {
                    case 1:
                        #region Bot
                        Bot.AyakkabiTürü = "Bot";
                        Bot.AyakkabiNum = Numara;
                        Bot.AyakkabiRenk = Renk;
                        Bot.Bagcik = Bagcik;
                        if (Numara < 30 && Numara > 18)
                        {
                            Bot.Fiyat = 79;
                        }
                        else if (Numara >= 30 && Numara < 40)
                        {
                            Bot.Fiyat = 89;
                        }
                        else if (Numara >= 40 && Numara <= 47)
                        {
                            Bot.Fiyat = 109;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir numara");
                            goto tekrar;
                        }
                        Bot.Ozellikler();
                        break;
#endregion
                    case 2:
                        #region Koþu Ayakkabýsý
                        Run.AyakkabiTürü = "Koþu Ayakkabýsý";
                        Run.AyakkabiNum = Numara;
                        Run.AyakkabiRenk = Renk;
                        Run.Bagcik = Bagcik;
                        if (Numara < 30 && Numara > 0)
                        {
                            Run.Fiyat = 129;
                        }
                        else if (Numara >= 30 && Numara < 40)
                        {
                            Run.Fiyat = 139;
                        }
                        else if (Numara >= 40 && Numara <= 47)
                        {
                            Run.Fiyat = 159;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir numara");
                            goto tekrar;
                        }
                        Run.Ozellikler();
                        break;
#endregion 
                    case 3:
                        #region Futbol Ayakkabýsý
                        Foot.AyakkabiTürü = "Futbol Ayakkabýsý";
                        Foot.AyakkabiNum = Numara;
                        Foot.AyakkabiRenk = Renk;
                        Foot.Bagcik = Bagcik;
                        if (Numara < 30 && Numara > 0)
                        {
                            Foot.Fiyat = 170;
                        }
                        else if (Numara >= 30 && Numara < 40)
                        {
                            Foot.Fiyat = 185;
                        }
                        else if (Numara >= 40 && Numara <= 47)
                        {
                            Foot.Fiyat = 199;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir numara");
                            goto tekrar;
                        }
                        Foot.Ozellikler();
                        break;
#endregion
                    case 4:
                        #region Terlik
                        Terlik.AyakkabiTürü = "Sandalet";
                        Terlik.AyakkabiNum = Numara;
                        Terlik.AyakkabiRenk = Renk;
                        Terlik.Bagcik = Bagcik;
                        if (Numara < 30 && Numara > 0)
                        {
                            Terlik.Fiyat = 29;
                        }
                        else if (Numara >= 30 && Numara < 40)
                        {
                            Terlik.Fiyat = 39;
                        }
                        else if (Numara >= 40 && Numara <= 47)
                        {
                            Terlik.Fiyat = 49;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir numara");
                            goto tekrar;
                        }
                        Terlik.Ozellikler();
                        break;
                    #endregion
                    default:
                        break;
                }
            }
            catch (Exception abc)
            {
                Console.WriteLine("Hata Türü: {0}", abc);

            }
        }
    }
}
