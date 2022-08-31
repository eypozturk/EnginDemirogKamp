using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] ogrenciler = new string[2];
            ogrenciler[0] = "eyup";
            ogrenciler[1] = "ahmet";

            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }
        }
    }
}