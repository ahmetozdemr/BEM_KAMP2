using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumGunler
{
    class Program
    {
        public enum Gunler
        {

            Pazartesi,

            Salı,

            Çarşamba,

            Perşembe,

            Cuma,

            Cumartesi,

            Pazar

        }

        static void Main(string[] args)
        {
            byte i = Convert.ToByte(Console.ReadLine());

            Gunler gunadı;

            gunadı = (Gunler)i;

            Console.WriteLine(gunadı.ToString()  );
            Console.Read();

        }
    }
}
