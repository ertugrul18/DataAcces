using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConApp.Entities
{
    public class MyDbContext:DbContext
    {
        //Database aktarilacak tablolar DbSet prop icerisinde bildirilmelidir

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Product> Urunler { get; set; }

        //Burada ise hangi server uzerinde calisacagini belirliyoruz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\Mssqllocaldb;Database=FirstDb;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Fluent Api ile Configurasyon


            #region ToTable
            modelBuilder.Entity<Personel>().ToTable("Personeller");

            #region 
       
            #endregion

            #region Personel tanimlari Column
            modelBuilder.Entity<Personel>()
                .Property(p => p.Email)
                .HasMaxLength(100)
                .HasColumnName("Email");

            modelBuilder.Entity<Personel>()
                .Property(p => p.FirstName)
                .HasMaxLength(50)
                .HasColumnName("Adi")
                .HasColumnOrder(3)
                .HasDefaultValue(" ");

            modelBuilder.Entity<Personel>()
                .Property(p => p.LastName)
                .HasMaxLength(50)
                .HasColumnName("Soyadi")
                .HasColumnOrder(4)
                .HasDefaultValue(" "); ;
            modelBuilder.Entity<Personel>()
                .Property(p => p.Phone)
                .HasMaxLength(20)
                .HasDefaultValue(" "); 
            #endregion


            #endregion
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
