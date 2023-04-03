using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumKadro
{
    class Program
    {
        enum Kadrolar : byte
        {
            İdareci,        // 0
            Öğretmen, // 1
            Memur, // 2
            Hizmetli   // 3
        }

        static void PersonelBul(Kadrolar e)
        {
            switch (e)
            {
                case Kadrolar.Öğretmen:
                    Console.WriteLine("Öğretmensiniz Maaşınız 1500");
                    break;
                case Kadrolar.İdareci:
                    Console.WriteLine("İdarecisiniz Maaşınız 2000");
                    break;
                case Kadrolar.Memur:
                    Console.WriteLine("Memursunuz Maaşınız 1300");
                    break;
                case Kadrolar.Hizmetli:
                    Console.WriteLine("Hizmetlisiniz Maaşınız 1200");
                    break;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Kadro Türününüzü Seçin..");
            Console.WriteLine("İdarecitt1");
            Console.WriteLine("Öğretment2");
            Console.WriteLine("Memurtt3");
            Console.WriteLine("Hizmetlit4");
            Console.WriteLine("Seçiminiz...");
            Kadrolar personel = (Kadrolar)Convert.ToByte(Console.ReadLine());
            PersonelBul(personel - 1);
            Console.ReadLine();
        }

    }
}
