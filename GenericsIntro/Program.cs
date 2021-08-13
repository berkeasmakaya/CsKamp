using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Berke");
            isimler.Add("Ahsen");

            Console.WriteLine(isimler);

            MyDictionary<string, string> sehirler = new MyDictionary<string, string>();
            sehirler.Add("Türkiye", "İstanbul");
            sehirler.Add("İngiltere", "Londra");
        }
    }
}
