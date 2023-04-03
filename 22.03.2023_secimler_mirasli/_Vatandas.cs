using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03._2023_secimler_mirasli
{
    internal abstract class _Vatandas : IAd, ISoyad, IYas, IOyKullanabilme, IOySayisi
    {
        public abstract string Ad { get; set; }
        public abstract string Soyad { get; set; }
        public abstract byte Yas { get; set; }
        public virtual int OySayisi { get; set; }



        public abstract void OyKullan(Milletvekili mv, Cumhurbaskani cb);
       

        

    }
}
