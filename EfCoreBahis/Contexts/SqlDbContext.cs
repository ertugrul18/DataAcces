using EfCoreBahis.Entites.Concrete;
using EfCoreBahis.EntitesTypeConfigurations.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBahis.Contexts
{
    public  class SqlDbContext:DbContext
    {
        public DbSet<BahisKonusu> BahisKonulari { get; set; }

        public DbSet<BahisCesit> BahisCesitleri { get; set; }
        public DbSet<BahisHareket> BahisHareketleri { get; set; }

        public DbSet<Kasa> Kasalar { get; set; }

        public DbSet<KasaHareket> KasaHareketleri { get; set; }

        public DbSet<Oynanan> Oyanananlar { get; set; }
        public DbSet<Oynayan> Oynayanlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Bahis;Trusted_Connection=true");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    // 300 adet tablo oldugunu dusunursek burasi da sisecek
        //    //modelBuilder.ApplyConfiguration<Kasa>(new KasaMap());


        //    //Bu kod mevcut projede IEntityTypeConfiguration Interface'inden kalitim almis ne kadar 
        //    // class varsa hepsini import ederek configuration'larini yapar
        //    //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Eger Burasi yanlislikla silinir ise EntityFrameWorkCore Default Davranisini Sergileyemez
            base.OnModelCreating(modelBuilder);

            // Bu kod mevcut projede IEntityTypeConfiguration Interface'inden kalitim almis ne kadar 
            // class varsa hepsini import ederek configuration'larini yapar


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
