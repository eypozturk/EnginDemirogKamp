using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1) Dictionary sınıfı içinde sizin belirleyeceğiz bir key e uygun olarak değer saklama zorunluluğu vardır.
             2) key türünü belirlemeniz şart (string, int vs..)
             */ 
            Dictionary<string,int> AdYas = new Dictionary<string,int>();
            AdYas.Add("Eyüp", 25);
            AdYas.Add("Mehmet", 17);
            AdYas.Add("Ahmet", 30);

            foreach (var isim in AdYas)
            {
                Console.WriteLine(isim);
            }

            //değerleri sayma özelliği vardır.
            var elemanSayisi = AdYas.Count();
            Console.WriteLine("eleman sayısı: "+elemanSayisi);

            //Değerleri silme özelliği vardır.
            AdYas.Remove("Mehmet");
            foreach (var isim in AdYas)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("eleman sayısı: " + AdYas.Count);
        }
    }
}