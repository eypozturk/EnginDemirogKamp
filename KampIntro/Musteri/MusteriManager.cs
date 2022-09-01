using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musteri
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklendi. Eklenen Müsteri bilgileri: "+ musteri.Isim +" "+musteri.Soyisim);
        }

    }
}
