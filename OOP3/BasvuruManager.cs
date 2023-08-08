using System;
using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {

            /*Burada interfaceimimi implemente ettiğimiz için
             hangi krediyi gönderirsek gönderelim onun işlemi
            yapılacaktır.*/

            krediManager.Hesapla();
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
