using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //SwitchCase, kodun akışında belirli bir şarta göre yönlendirme yapmamızı(farklı
            //algoritma çalıştırmamızı/farklı operasyon gerçekleştirmemizi/tetiklememizi) sağlayan yapılardır.

            //Swich case yapılanması sadece bir değişkenin değerini sadece eşitlik durumlarını
            //kontrol ederken kullanılabilir.

            //Sadece eşitlik durumunu check edilecekse o zaman switch kullanılabilir.

            // switch(değer)
            // {
            // case value1:.....;
            // ...CODE...;
            // break;
            // case value2:....;
            // ...CODE....;
            // break;
            // default:
            // ...CODE....;
            //break;
            // }


            //Swicth yapılanmasındaki amaç eşitlik durumuna göre belirli bir kod blogunu tetiklemiştir.


            string adi = "Ahmet";
            switch (adi)
            {
                case "Mehmet":
                    Console.WriteLine("Adi Mehmet");
                    break;
                case "Ahmet":
                    Console.WriteLine("Adi Ahmet");
                    break;
                default:
                    Console.WriteLine("Adi Eyüp");
                    break ;
                        
            }
        }
    }
}