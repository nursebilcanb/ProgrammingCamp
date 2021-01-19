using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kategoriEtiketi = "Kategori:";
            //bool sistemeGirisYapmisMi = true;
            //Console.WriteLine(kategoriEtiketi);
            double dolarDun = 7.45;
            double dolarBugun = 7.45;
            

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            Console.ReadKey();
        }
    }
}
