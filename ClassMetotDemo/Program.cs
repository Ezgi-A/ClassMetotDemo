using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriID = "159753123";
            musteri1.musteriİsim = "Acun";
            musteri1.musteriSoyisim = "Ilıcalı";
            musteri1.musteriBirikim = 25000000;

            Musteri musteri2 = new Musteri();
            musteri2.musteriID = "259762123";
            musteri2.musteriİsim = "Demet";
            musteri2.musteriSoyisim = "Akalın";
            musteri2.musteriBirikim = 2500;

            Musteri musteri3 = new Musteri();
            musteri3.musteriID = "359412523";
            musteri3.musteriİsim = "Bülent";
            musteri3.musteriSoyisim = "Ersoy";
            musteri3.musteriBirikim = 450000000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var must in musteriler)
            {
                Console.WriteLine("Müşteri ID: "+ must.musteriID+" /Müşteri İsmi: "+ must.musteriİsim+" /Müşteri Soyismi: "+ must.musteriSoyisim+" /Müşteri Birikimi: "+ must.musteriBirikim);
            }

            Console.WriteLine("******************************************");

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);


            Console.WriteLine("*******************************************");

            musterimanager.Sil(musteri1);
            musterimanager.Sil(musteri2);
            musterimanager.Sil(musteri3);





        }
    }
}
