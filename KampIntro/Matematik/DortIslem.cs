using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;

            Console.WriteLine("Sonuç:"+" "+toplam);
        }
        public int Topla2(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;
            return result;
        }
        public int Multiply(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }
        //overloaded
        public int Multiply(int sayi1, int sayi2,int sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }
        public int Topla3(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
