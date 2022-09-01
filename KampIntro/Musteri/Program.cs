using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Isim = "Eyüp";
            musteri1.Soyisim = "Ozturk";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Isim = "Ahmet";
            musteri2.Soyisim = "Arslan";


            MusteriManager mustetiManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2};

            mustetiManager.Add(musteri1);

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
            }

        }
    }
}