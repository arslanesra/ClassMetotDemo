using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Esra";
            musteri1.Soyadi = "Arslan";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Selim Mert";
            musteri2.Soyadi = "Aydın";



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteri1);
            musteriManager.List(musteri2);


            Console.ReadLine();

        }

       
    }


}
