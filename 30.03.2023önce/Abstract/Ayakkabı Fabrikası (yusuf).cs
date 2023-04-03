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
            public string AyakkabiT�r� { get; set; }

            virtual public void Ozellikler()
            {

            }
        }
        class Bot : AyakkabiFabrikasi
        {
            public override void Ozellikler()
            {
                string bagcik = (Bagcik == true) ? "var" : "yok";
                Console.Write("Ayakkab� t�r�: {0}\nAyakkabi Numaras�: {1}\nAyakkab� Rengi: {2}\nAyakkab�n�n Fiyat�: {3}TL\nBa�c�k: {4}", AyakkabiT�r�, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);

            }
        }
        class Sandalet : AyakkabiFabrikasi
        {
            public override void Ozellikler()
            {
                string bagcik = (Bagcik == true) ? "var" : "yok";
                Console.Write("Ayakkab� t�r�: {0}\nSandalet Numaras�: {1}\nSandalet Rengi: {2}\nSandalet Fiyat�: {3}TL\nBa�c�k: {4} \n", AyakkabiT�r�, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
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
                Console.Write("Ayakkab� t�r�: {0}\nAyakkabi Numaras�: {1}\nAyakkab� Rengi: {2}\nAyakkab�n�n Fiyat�: {3}TL\n Ba�c�k: {4}", AyakkabiT�r�, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
            }
        }
        class Futbol : SporAyakkabi
        {
            public override void Ozellikler()
            {
                string bagcik = (Bagcik == true) ? "var" : "yok";
                Console.Write("Ayakkab� t�r�: {0}\nAyakkabi Numaras�: {1}\nAyakkab� Rengi: {2}\nAyakkab�n�n Fiyat�: {3}TL\n Ba�c�k: {4}", AyakkabiT�r�, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
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
                Console.WriteLine("**********Ho�geldiniz**********\n\n\tAyakkab�T�r� Se�iniz\n\t1-Bot\n\t2-Ko�u\n\t3-Futbol\n\t4-Sandalet");
                byte Secim = byte.Parse(Console.ReadLine());
                if (Secim<1||Secim>4)
                {
                    Console.WriteLine("Ge�ersiz Bir Se�im\nProgram Tekrar Ba�lat�l�yor.");
                    System.Threading.Thread.Sleep(2000);
                    goto bidaha;
                }
                Console.WriteLine("Ayakkab� Rengini Giriniz(Mavi,Ye�il,Siyah...)");
                string Renk = Console.ReadLine();

                Console.WriteLine("Ba�c�k var m�? (true/false)");
                Boolean Bagcik = Boolean.Parse(Console.ReadLine());

                tekrar:
                Console.WriteLine("Ayakkab� Numaras� Se�iniz(1/47)");
                byte Numara = byte.Parse(Console.ReadLine());

                switch (Secim)
                {
                    case 1:
                        #region Bot
                        Bot.AyakkabiT�r� = "Bot";
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
                            Console.WriteLine("Ge�ersiz bir numara");
                            goto tekrar;
                        }
                        Bot.Ozellikler();
                        break;
#endregion
                    case 2:
                        #region Ko�u Ayakkab�s�
                        Run.AyakkabiT�r� = "Ko�u Ayakkab�s�";
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
                            Console.WriteLine("Ge�ersiz bir numara");
                            goto tekrar;
                        }
                        Run.Ozellikler();
                        break;
#endregion 
                    case 3:
                        #region Futbol Ayakkab�s�
                        Foot.AyakkabiT�r� = "Futbol Ayakkab�s�";
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
                            Console.WriteLine("Ge�ersiz bir numara");
                            goto tekrar;
                        }
                        Foot.Ozellikler();
                        break;
#endregion
                    case 4:
                        #region Terlik
                        Terlik.AyakkabiT�r� = "Sandalet";
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
                            Console.WriteLine("Ge�ersiz bir numara");
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
                Console.WriteLine("Hata T�r�: {0}", abc);

            }
        }
    }
}
