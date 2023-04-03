using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumBolum
{
    class Program
    {
        enum bolumler
        {
            Bilgisayar_öğretmenliği,
            Elektronik_öğretmenliği,
            Elektrik_öğretmenliği,
            Yapı_öğretmenliği,
            Otomotiv_öğretmenliği
        }

        public static void Main()
        {
            bolumler b;
            for (b = bolumler.Bilgisayar_öğretmenliği; b <= bolumler.Otomotiv_öğretmenliği; b++)
            {
                Console.WriteLine("{0} 'nın etiketi ={1}", b, (int)b);
            } 
            Console.ReadKey();

        }

    }
}
