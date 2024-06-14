using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphane
{
    public class Database
    {

        public static List<Urun> UrunTablo = new List<Urun>()
        {

            new Urun()
            {
         id = 1,
         urunAdi = "Bir Ömür Nasıl Yaşanır",
         stokAdet = 10,
         urunKategori = "Roman",
         aciklama = @"İlber Ortaylı'nın 'Bir Ömür Nasıl Yaşanır' adlı kitabı, sıradan hayatları olağanüstü kılmayı anlatıyor.",
         yazar = "İlber Ortaylı",
         urunResim = @"C:\Users\pc\Downloads\1.jpg.jpeg"
          },

           new Urun()
           {
          id = 2 , urunAdi="Rüzgarı dizginleyen çocuk", stokAdet=15, urunKategori="Roman" , aciklama = @"Merak ettim denedim ve başardım."
          , yazar="william kamkwamba", urunResim=@"C:\Users\pc\Downloads\indir.jpeg"

           },

           new Urun()
           {
          id = 4,
           urunAdi = "Pusula",
           stokAdet = 20,
           urunKategori = "Tarih",
            aciklama = @"Sinan Meydan'ın 'Pusula' kitabı, kanıtlarıyla birlikte Türkiye Cumhuriyeti tarihini ve Atatürk'ün hayatını anlatıyor.",
            yazar = "Sinan Meydan",
            urunResim = @"C:\Users\pc\Downloads\5.jpg.jpeg"
           },


             new Urun()
            {
          id = 3,
           urunAdi = "Büyük kederler küçük öyküler",
          stokAdet = 13,
          urunKategori = "Roman",
          aciklama = @"Büyük kederle küçük öyküler dese de içindekilerin hepsi öykü değil bence. Biraz deneme biraz anı da serpiştirilmiş içine.",
          yazar = "Ali Lidar",
          urunResim = @"C:\Users\pc\Downloads\wh_true.jpeg"
          },



        };






    }
}
