using System;
using System.Runtime.Intrinsics.X86;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string urunAdi = "Elma";
            double fiyatı = 15;
            string aciklama = "Amasya elması";

            Urun urun1=new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Açıklama";

            Urun urun2=new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            

            Urun urun3 = new Urun();
            
            Urun[] urunler = new Urun[]{urun1, urun2, urun3};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi+"'nın fiyatı:"+urun.Fiyati);
            }

            //Encapsulation
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Sarı armut",10,5);
            sepetManager.Ekle2("Elma", "Yeşil elma", 10,5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 10, 5);

            

        }

    }
}