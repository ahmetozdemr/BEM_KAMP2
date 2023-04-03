using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumAyakkabi
{ 
    public enum MarkaIsimleri 
        { 
            Adidas,
            Nike,
            Camel 
        }
    public enum AyakkabiTipleri 
        { 
            Bot,
            Çizme,
            SporAyakkabi, 
            Sandalet
        }
      
        
        
        public enum MalzemeTipleri
        { 
            Nubuk,
            Deri,
            Suet 
        }
        
        
    public class Ayakkabi
    {
        public byte numarasi { get; set; }
        public MarkaIsimleri Markasi { get; set; }
        public MalzemeTipleri Malzemesi { get; set; }
        
        public Ayakkabi(byte ayakkabiNo, MarkaIsimleri marka)
        {
            numarasi = ayakkabiNo; 
            Markasi = marka;
        }

        public Ayakkabi(byte ayakkabiNo, MarkaIsimleri marka, MalzemeTipleri malzeme)
        {
            numarasi = ayakkabiNo; 
            Markasi = marka;
            Malzemesi = malzeme; 
        }
    }
    
    
    
    
    
    class Program
    {
       
  public AyakkabiTipleri AyakkabiTipi { get; set; }
        static void Main(string[] args)
        {
            Ayakkabi ayk = new Ayakkabi(42, MarkaIsimleri.Adidas);
        }
    }
}
