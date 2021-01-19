using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Sadi Mert";
            musteri1.Soyad = "YILMAZ";
            musteri1.Telefon = 554;
            musteri1.EMail = "sadimertyl@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ali";
            musteri2.Soyad = "YILMAZ";
            musteri2.Telefon = 542;
            musteri2.EMail = "Aliii@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Veli";
            musteri3.Soyad = "YILMAZ";
            musteri3.Telefon = 543;
            musteri3.EMail = "Veliii@gmail.com";
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriMenager musteriManager = new MusteriMenager();
            foreach (var musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
                Console.WriteLine("---------------------------");

            }
            Console.WriteLine("Müşteriler:");
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("Müşteri Sil");
            Console.WriteLine("---------------------------");

            foreach (var musteri in musteriler)
            {
                musteriManager.Sil(musteri);
                Console.WriteLine("---------------------------");
            }
        }
    }
}
