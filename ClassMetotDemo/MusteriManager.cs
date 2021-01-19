using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Adi);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Adi);
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi : " + musteri.Adi);
        }
    }
}