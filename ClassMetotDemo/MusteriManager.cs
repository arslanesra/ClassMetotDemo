using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " Müşteri Eklendi");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " Müşteri Silindi");
        }

        public void List()
        {
            Console.WriteLine(" Müşteri Listelesi");
        }
    }
}
