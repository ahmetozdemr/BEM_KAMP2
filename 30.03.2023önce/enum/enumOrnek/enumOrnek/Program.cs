using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumOrnek
{
    public enum EvTuru
    {
        Bilinmiyor,
        Apart,
        Apartman,
        Müstakil
    }
    public class Ev
    {
        public EvTuru ozellik;

        public Ev()
        {
            ozellik = EvTuru.Bilinmiyor;
        }

        public void Goruntule()
        {
            Console.WriteLine("Evinizin Özelliği: {0}", ozellik);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Ev bicim = new Ev();
            bicim.Goruntule();
            bicim.ozellik = EvTuru.Müstakil;
            bicim.Goruntule();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
