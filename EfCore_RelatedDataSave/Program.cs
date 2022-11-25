using Microsoft.EntityFrameworkCore;

namespace EfCore_RelatedDataSave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext context = new SqlDbContext();
            #region One-to-one iliskilerde object referansi ile kayit ekleme
            //Adress alininadresi = new Adress
            //{
            //    Ulke = "TR",
            //    Sehir = "Van",
            //    Ilce = "Tatvan"

            //};


            //Person ali = new Person
            //{
            //    Adi = "Ali",
            //    SoyAdi = "Yilmaz",
            //    Adres = alininadresi
            //};
            //context.Personeller.Add(ali);
            //context.SaveChanges();
            #endregion

            #region One-to-one iliskilerde object initilaze ile kayit ekleme


            //Person ert = new Person
            //{
            //    Adi = "Ertuğrul",
            //    SoyAdi = "Çetinkaya",
            //    Adres = new Adress
            //    {

            //        Ulke = "TR",
            //        Sehir = "Kocaeli",
            //        Ilce = "Darıca"
            //    }
            //};


            //context.Personeller.Add(ert);
            //context.SaveChanges();
            #endregion

            #region One-to-many iliskilerde kayit islemi

            #region 1.Yöntem Primcipal Entity üzerinden Dependent Entity verisi ekleme
            //Blog blog = new Blog
            //{
            //    Name = "Dünya Kupası Maclari"
            //};
            //blog.Posts.Add(new Post { Baslik = "Almanya-Japonya Maci", Aciklama = "Hic Beklenmiyordu" });
            //blog.Posts.Add(new Post { Baslik = "Almanya-Japonya Maci", Aciklama = "Japonlar imkansızı basardi" });
            //blog.Posts.Add(new Post { Baslik = "Almanya-Japonya Maci", Aciklama = "Japonlar çöplerini topladı" });
            //context.Bloglar.Add(blog);
            //context.SaveChanges();

            #region  Object İnitializer üzerinden ekleme
            //Blog blog = new Blog
            //{
            //    Name = "Test",
            //    Posts = new List<Post>()
            //    {
            //        new Post {Baslik="Blog 2 yorum ",Aciklama="Yorum1"},
            //        new Post {Baslik="Blog 2 yorum ",Aciklama="Yorum2"},
            //        new Post {Baslik="Blog 2 yorum ",Aciklama="Yorum3"},

            //    }

            //};
            //context.Bloglar.Add(blog);
            //context.SaveChanges();


            #endregion

            #endregion


            #region 2. Yöntem Dependent Entity üzerinden kayit ekleme

            //Post post = new Post()
            //{
            //    Baslik = "Blog 3 Yorum1",
            //    Aciklama = "Blog 3 için yorum eklendi",
            //    Blog = new() { Name = "Blog3" }
            //};
            //context.Postlar.Add(post);
            //context.SaveChanges();
            #endregion

            #region 3.Yöntem Foreign Key üzerinden veri ekleme

            //Post post = new Post()
            //{
            //    Baslik = "Yorum 2",
            //    Aciklama = "Blog 3 icin yorum",
            //    BlogId = 3
            //};
            //context.Postlar.Add(post);
            //context.SaveChanges();
            #endregion



            #endregion

            #region Many-To-Many Kayit Ekleme
            //Kitap yuksekmat = new Kitap()
            //{
            //    KitapAdi = "Yüksek Matematik",
            //    Yazarlar = new HashSet<Yazar>()
            //     {
            //         new Yazar(){YazarAdi ="Ahmet Karadeniz"},
            //         new Yazar(){YazarAdi="Mehmet Karadeniz"}
            //     }


            //};
            //context.Kitaplar.Add(yuksekmat);
            //context.SaveChanges();


            //Yazar aliveli = new Yazar()
            //{
            //    YazarAdi = "Ali Veli",
            //    Kitaplar = new HashSet<Kitap>()
            //     {
            //         new Kitap(){KitapAdi ="Cin Ali"},
            //         new Kitap(){KitapAdi="Cin Ali Tatilde" }
            //     }


            //};
            //context.Yazarlar.Add(aliveli);
            //context.SaveChanges();

            #endregion

            #region Many-To-Many Kayıt Güncelleme
            //// 3 numaralı kitabı 1 numaralı yazara atamak istediğinizde

            ////Kitaba konumlan
            //Kitap? kitap = context.Kitaplar.Find(3);

            ////Yeni yazara konumlan
            //Yazar? yeniyazar = context.Yazarlar.Find(1);

            ////Eski yazara konumlan
            //Yazar? eskiyazar = context.Yazarlar.
            //    Include(p => p.Kitaplar).
            //    FirstOrDefault(p => p.Id == 3);

            ////Eski yazarı kaldır
            //eskiyazar.Kitaplar.Remove(kitap);

            ////kitabu yeni yazara ekle
            //kitap.Yazarlar.Add(yeniyazar);

            //var objects = context.ChangeTracker;

            //context.SaveChanges();


            #endregion

            #region One-to-Many Kayıt Güncelleme (blok principle - dependent(çoğul) postlar)
            // Blog 3 için yapılan en son yorumu blog 2 ye aktarın
            /*
            1- Eski Blog'a konumlan
            2- Post'a konumlan
            3- Eski Blog'dan Remove et.
            4- Yeni blog'a konumlan
            5- Yeni Blog'a ekle
             */

            // 1- Eski Blog'a konumlan
            //Blog? eskiblog = context.Bloglar.Include(p => p.Posts).FirstOrDefault(p => p.Id == 3);

            //// 2- Post'a konumlan
            //Post? post = context.Postlar.FirstOrDefault(p => p.Id == 8);

            //// 3- Eski Blog'dan Remove et.
            //eskiblog.Posts.Remove(post);

            ////  4-5 Yeni blog'a konumlan
            //Blog? yeniBlog = context.Bloglar.Find(2);
            //yeniBlog.Posts.Add(post);


            //context.SaveChanges();

            #endregion

            #region Bağımlı verilerin ilişkisel olduğu ana veriyi güncelelme (Dependent Entity'nin Principal Entity'sini güncelleme)
            //6 numaralı post'u 3 numaralı Blog'a atama islemi

            //Post? post = context.Postlar.Find(6);
            //Blog? blog = context.Bloglar.Find(3);

            //post.Blog = blog;

            //context.SaveChanges();


            #endregion

            #region One-To-Many Kayit Silme

            //Blog? blog = context.Bloglar.Include(p => p.Posts).FirstOrDefault(p => p.Id == 3);
            //blog.Posts.Clear();
            //context.SaveChanges();


            Blog? blog = context.Bloglar.Include(p => p.Posts).FirstOrDefault(p => p.Id == 2);
            
            context.Bloglar.Remove(blog);

            context.SaveChanges();

            #endregion



        }
    }
}