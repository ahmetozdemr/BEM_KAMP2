using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Otomasyonu
{
    internal class Pizza
    {
        public string adi { get; set; }
        public decimal fiyat { get; set; }
        public Ebat Ebati { get; set; }
        public KenarTip KenarTipi { get; set; }
        public List<string> Malzemeler { get; set; }

        public decimal Tutar { 
            get
            {
                decimal tutar = 0;
                tutar = fiyat * (decimal)Ebati.carpan;
                tutar += KenarTipi.ek_fiyat;

                return tutar;
            }               
        }
        public override string ToString()
        {
            return adi;

        }
    }
}
