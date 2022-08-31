using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            //array dizi

            string[] kurslar = new string[] { kurs1,kurs2,kurs3,kurs4};

            for (int i = 0; i < (kurslar.Length); i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}