using System;

namespace TernaryOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir değişkene/metoda/property'e değer atarken,eğer ki bu şarta göre
            //fark edecekse satır bazlı /tek satırda bu şart kontrolünü yaparak
            //duruma göre değerini döndürmemzi sağlayan bir kalıpsal operatördür.

            // ......sart/durum....?..(sart doğru ise)......:....(sart yanlış ise)..;    ?:

            //geriye dönücek değerler aynı türde olmalıdır.

            bool mediniHal = true;
            string mesaj = mediniHal == true ? "Evlilere kampanya..." : "Bekarlara kampanya...";
            Console.WriteLine(mesaj);
        }
    }
}