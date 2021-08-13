using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method Injection
        public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService)
        {
            // Basvuran bilgilerini değerlendirme
            //

            crediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnbilgilendirmesiYap(List<ICrediManager> krediler)
        {
            foreach (var credi in krediler)
            {
                credi.Hesapla();
            }
        }
    }
}
