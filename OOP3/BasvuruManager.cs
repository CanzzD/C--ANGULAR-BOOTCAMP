using System;
using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {

            /*Burada interfaceimimi implemente ettiğimiz için
             hangi krediyi gönderirsek gönderelim onun işlemi
            yapılacaktır.*/


            //Method injection 
            krediManager.Hesapla();
            loggerService.Log();
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
