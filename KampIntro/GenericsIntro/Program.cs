using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> isimler=new MyList<string>();
            //isimler.Add("Eyüp");

            List<string> isimler1=new List<string> {"Eyp","Ozt"};

            foreach (var isim in isimler1)
            {
                Console.WriteLine(isim);
            }

            MyList<string> isimler2 = new MyList<string>();
            isimler2.Add("eyq");

        }
    }
}