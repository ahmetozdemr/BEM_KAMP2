using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    enum bolumler
    {
        Türkiye,
        İrlanda,
        Pakistan,
        Malezya,
        Rusya,
        Japonya,
        Arjantin,
        Lübnan

    }

    class Program
    {
        static void Main(string[] args)
        {
            bolumler b;
            for (b = bolumler.Türkiye; b <= bolumler.Rusya; b++)
            {
                Console.WriteLine("{0} 'nın etiketi ={1}", b, (int)b);
            } Console.ReadKey();
 

        }
    }
}
