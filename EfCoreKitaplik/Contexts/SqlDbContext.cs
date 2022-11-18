using EfCoreKitaplik.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplik.Contexts
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Kitaplik.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent Api Uzerinde Yapilirsa Composit Tabloyu kendimiz olusturmamiz gerekir


            //modelBuilder.Entity<KitapYazar>()
            //    .HasKey(p => new { p.YazarID, p.KitapId });
            //modelBuilder.Entity<KitapYazar>()
            //    .HasOne(p => p.Kitap)
            //    .WithMany(p => p.Yazarlar)
            //    .HasForeignKey(p => p.KitapId);

            //modelBuilder.Entity<KitapYazar>()
            //    .HasOne(p => p.Yazar)
            //    .WithMany(p => p.Kitaplar)
            //    .HasForeignKey(p => p.YazarID);



            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
