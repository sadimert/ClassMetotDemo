using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriMenager
    {
       public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
            Console.WriteLine("Adi" + musteri.Ad);
            Console.WriteLine("Soyadı" + musteri.Soyad);
            Console.WriteLine("Telefon" + musteri.Telefon);
            Console.WriteLine("E-Mail" + musteri.EMail);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "  " + musteri.Soyad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
        }
    }
}
