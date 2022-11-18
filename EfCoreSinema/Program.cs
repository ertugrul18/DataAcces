using System;
using EfCoreSinema.Contexts;
using EfCoreSinema.Entities.Abstract;
using EfCoreSinema.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EfCoreSinema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlDbContext dbContext = new SqlDbContext();
            #region Kayit Ekleme
            //Kategori kategori = new Kategori() { KategoriAdi = "Komedi", Aciklama = "Komedi" };
            //dbContext.Kategoriler.Add(kategori);
            //dbContext.SaveChanges();

            #endregion

            #region Kayit Guncelleme 

            // Once kaydi bulalim
            //var kategori = dbContext.Kategoriler.FirstOrDefault(p => p.KategoriAdi == "Macera");

            //if (kategori != null)
            //{
            //    kategori.Aciklama = "Macera kategorisi";

            //}
            //dbContext.SaveChanges();
            #endregion

            #region Kayit Silme

            //var kategori = dbContext.Kategoriler.Where(p => p.KategoriAdi == "Macera").FirstOrDefault();
            //dbContext.Kategoriler.Remove(kategori);
            //dbContext.SaveChanges();

            #endregion


            #region KAyit listesi Alma
            //var sonuc = dbContext.Kategoriler.ToList();
            //foreach (var item in sonuc)
            //{
            //    global::System.Console.WriteLine(item.KategoriAdi + " " + item.Status);
            //}

            #endregion


            #region  Global Filter'i Disable etme
            var sonuc = dbContext.Kategoriler.IgnoreQueryFilters().ToList();
            foreach (var item in sonuc)
            {
                global::System.Console.WriteLine(item.KategoriAdi + " " + item.Status);
            }

            #endregion


            //Console.WriteLine("Hello, World!");
        }
    }
}