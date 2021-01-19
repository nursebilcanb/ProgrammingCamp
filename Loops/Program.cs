using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java";

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kursu",
                "Programlamaya başlangıç için temel kurs",
                "Java",
                "C++"
        };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
               

            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Foreach bitti");
            Console.WriteLine("sayfa sonu - footer");
            Console.ReadLine();
        }
    }
}
