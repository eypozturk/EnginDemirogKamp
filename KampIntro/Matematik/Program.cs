using System;


namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {

            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 9);
            Console.WriteLine("Hello World!");

            Console.WriteLine(dortIslem.Topla2(1, 2));

            Console.WriteLine(dortIslem.Multiply(8, 7));

            Console.WriteLine(dortIslem.Topla3(4, 7, 8, 5));
        }
    }
}