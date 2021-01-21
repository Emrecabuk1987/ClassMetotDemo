using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();

            musteri.MusteriAdi = "Emre";
            musteri.MusteriSoyadi = "Çabuk";
            musteri.Id = 103167813;
            musteri.DogumTarihi = 1987;

            Musteri[] Musteriler = new Musteri[] { musteri };

            foreach (var musteri1 in Musteriler)

            {
                Console.WriteLine("Musteri Adı : " + musteri.MusteriAdi + "\nMusteri Soyadı : " + musteri.MusteriSoyadi + "\nDoğum Tarihi : " + musteri.DogumTarihi + "\nMusteri İd Numarası " + musteri.Id);

            }

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle();

            MusteriManager Musterimanager = new MusteriManager();
            Musterimanager.Sil();
       
        }



        class Musteri
        {

            public string MusteriAdi { get; set; }
            public string MusteriSoyadi { get; set; }
            public int Id { get; set; }
            public int DogumTarihi { get; set; }

        }



        


        






















        








    }
}