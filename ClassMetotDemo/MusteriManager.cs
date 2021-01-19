using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri must)
        {
            Console.WriteLine(must.musteriİsim+" "+must.musteriSoyisim+" eklendi!");
        }
        public void Sil(Musteri must)
        {
            Console.WriteLine(must.musteriİsim + " " + must.musteriSoyisim + " silindi!");
        }
    }
}
