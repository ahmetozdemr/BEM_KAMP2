using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Etcil aslan = new Etcil();
            aslan.Adi = "Aslan";
            aslan.BeslenmeSekli = "Etçil";
            aslan.Turu = "Memeli";
            aslan.AyakSayisi = 4;
            aslan.HayatSuresi = 10;
            aslan.Info();
            Otcul zebra = new Otcul();
            zebra.Adi = "zebra";
            zebra.BeslenmeSekli = "otcul";
            zebra.Info();



            Console.ReadLine();


        }
    }

    public abstract class Hayvan
    {
        public abstract string Adi { get; set; }
        public abstract string BeslenmeSekli { get; set; }
        public short HayatSuresi { get; set; }
        public string Turu { get; set; }
        public short AyakSayisi { get; set; }
        public abstract void Info();

       


    }
    class Etcil : Hayvan
    {
        public override string Adi { get; set; }
        public override string BeslenmeSekli { get; set; }

        public override void Info()
        {
            Console.WriteLine($"{this.Adi} {this.BeslenmeSekli} bir hayvandır");
            if (this.Turu != null)
                Console.WriteLine("Türü=" + Turu);
            if (this.AyakSayisi > -1)
                Console.WriteLine("Ayak Sayısı=" + AyakSayisi);
            if (this.HayatSuresi > -1)
                Console.WriteLine("Hayat Suresi=" + HayatSuresi + " yıl");
        }
        public Etcil()
        {
            AyakSayisi = -1;
            HayatSuresi = -1;
        }


    }
    class Otcul : Hayvan
    {
        public override string Adi { get; set; }
        public override string BeslenmeSekli { get; set; }

        public override void Info()
        {
            Console.WriteLine($"{this.Adi} {this.BeslenmeSekli} bir hayvandır");
            if (this.Turu != null)
                Console.WriteLine("Türü=" + Turu);
            if (this.AyakSayisi > -1)
                Console.WriteLine("Ayak Sayısı=" + AyakSayisi);
            if (this.HayatSuresi > -1)
                Console.WriteLine("Hayat Suresi=" + HayatSuresi + " yıl");
        }
        public Otcul()
        {
            AyakSayisi = -1;
            HayatSuresi = -1;
        }


    }


}
