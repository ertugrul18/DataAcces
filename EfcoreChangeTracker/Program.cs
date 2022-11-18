namespace EfcoreChangeTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext db = new SqlDbContext();
            #region ChangeTracker Nedir
            /* Context nesnesi uzerinden gelen tum nesneler otomatik olarak takip mekanizmansi tarfindan izlenirler
             * Bu mekanizmaya ChangeTracker Denir. Nesneler uzerinde yapilan degisikliklere istinaden ilgili sql sorgusu generate edilir
             * 
             * DbContext Sinifi uzerinde Bir property olarak gelir.
            */

            #region Urun Ekeleme Durumu
            //Urun kola = new Urun { UrunAdi = "Kola", Adet = 2, Fiyat = 10 };
            //Urun gazoz = new Urun { UrunAdi = "Gazoz", Adet = 2, Fiyat = 10 };
            //Urun ayran = new Urun { UrunAdi = "Ayran", Adet = 2, Fiyat = 10 };
            //Urun limonata = new Urun { UrunAdi = "Limonata", Adet = 2, Fiyat = 10 };
            //Urun soda = new Urun { UrunAdi = "Soda", Adet = 2, Fiyat = 10 };


            //db.Urunler.Add(kola);
            //db.Urunler.Add(gazoz);
            //db.Urunler.Add(ayran);
            //db.Urunler.Add(soda);
            //db.Urunler.Add(limonata); 
            #endregion
            #region ChangeTracker Ornek

            //var urunler = db.Urunler.ToList();

            //urunler[2].Fiyat = 15; // Update
            //urunler[3].Adet = 10; // Update

            //db.Urunler.Remove(urunler[4]); //Delete

            //var sonuc = db.ChangeTracker.Entries();
            //foreach (var item in sonuc)
            //{
            //    Console.WriteLine(item.Entity + " "+ item.CurrentValues + " " + item.OriginalValues);
            //}

            //db.SaveChanges();

            #endregion

            #region DetectChanges Metodu
            /*
             /EF Core, context nesnesi tarafından izlenen tüm nesnelerdeki değişiklikleri Change Tracker sayesinde
            //takip edebilmekte ve nesnelerde olan verisel değişiklikler yakalanarak bunların anlık
            //görüntüleri(snapshot)'ini oluşturabilir.
            //Yapılan değişikliklerin veritabanına gönderilmeden önce algılandığından emin olmak gerekir.
            //SaveChanges fonksiyonu çağrıldığı anda nesneler EF Core tarafından otomatik kontrol edilirler.
            //Ancak, yapılan operasyonlarda güncel tracking verilerinden emin olabilmek için değişişiklerin
            //algılanmasını opsiyonel olarak gerçekleştirmek isteyebiliriz. İşte bunun için DetectChanges
            //fonksiyonu kullanılabilir ve her ne kadar EF Core değişikleri otomatik algılıyor olsa da siz 
            //yine de iradenizle kontrole zorlayabilirsiniz.

             */
            //var urun = db.Urunler.FirstOrDefault(p => p.UrunAdi == "Ayran");

            //urun.Adet = 40;
            //db.ChangeTracker.DetectChanges();
            //db.SaveChanges();
            #endregion


            #region Entity State
            // Entity Nesnelerinin durumlarini ifade eder

            #region Detached
            // Nesnenin ChangeTracke tarafindan takip edilmedigini ifade eder.
            //Urun elma = new Urun { UrunAdi="Elma",Adet=1,Fiyat=5};
            //Console.WriteLine(db.Entry(elma).State);
            #endregion
            #region Added
            // VewriTabanina eklenecek olan nesneyi ifade eder. Yanliz db'ye henuz eklenmemistir.
            // SaveChanges() metodu ile insert cumlesi calistirilir
            //Urun elma = new Urun { UrunAdi = "Elma", Adet = 1, Fiyat = 5 };
            //Console.WriteLine(db.Entry(elma).State);
            //db.Urunler.Add(elma);
            //Console.WriteLine(db.Entry(elma).State);
            //db.SaveChanges();
            //elma.Fiyat = 20;
            //Console.WriteLine(db.Entry(elma).State);

            //db.SaveChanges();
            #endregion


            #region Unchanged
            // Veritabaninda sorgulandigindan beri nesne uzerinde herhangi bir degisiklik yapilmadigini ifade eder.
            //Sorgu neticesinde elde edilen tum nesneler başlangicta bu state degerine sahiptir.

            //var urunler = db.Urunler.ToList();
            //var data = db.ChangeTracker.Entries();

            #endregion


            #region Modified
            // Nesne uzerinde degisiklik yapildigini ifade eder.SaveChanges() metodu cagrildiginda Update sorgusu olusturur.
            var urun = db.Urunler.FirstOrDefault(p => p.ID == 2);
            Console.WriteLine(db.Entry(urun).State);
            urun.Fiyat = 50;
            Console.WriteLine(db.Entry(urun).State);


            #endregion

            #region Deleted
            //Nesenin silindigini ifade eder. SaveChanges() metodu cagrildiginda Delete sorgusu olusturur.
            var urun2 = db.Urunler.FirstOrDefault(p => p.ID == 3);
            Console.WriteLine(db.Entry(urun2).State);
            db.Urunler.Remove(urun2 );
            Console.WriteLine(db.Entry(urun2).State);
            #endregion



            #endregion


            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}