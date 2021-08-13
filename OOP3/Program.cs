using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // İnterfacleri birbirinin alternafi olan ama kod içerikleri farklı olan durumlar için kullanırız.
            ICrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICrediManager tasitKrediManager = new TasitKrediManager();
            ICrediManager konutCrediManager = new KonutCrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

            List<ICrediManager> krediler = new List<ICrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutCrediManager};
            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);
        }
    }
}
