using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Geliştirme Kampı";
            string kurs2 = "Proglamlamaya Başlamak İçin Temel Kurs";
            string kurs3 = "Java";

            // array
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Geliştirme Kampı",
                "Proglamlamaya Başlamak İçin Temel Kurs",
                "Java",
                "Python"
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

            int a = 0;
            while (a < 3)
            {
                Console.WriteLine(kurslar[a]);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
