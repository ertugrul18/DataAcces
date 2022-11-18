using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDeleting_Related_Data
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TestDb;Trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /* DeleteBehavior.Cascade : yapilirsa 
             *  esas tablodan veri silinirse bagimli tablodakiler de
             *  silinir
             * 
             * DeleteBehavior.NoAction : Bu durumda bagimli tabloda herhangi bir islem yapma
             * DeleteBehavior.Restrict : Bu durumda bagimli tabloda herhangi bir islem yapma
             * DeleteBehavior.SetNull :  Bu durumda ise bagimli tablodaki verilere null degeri atacaktir
              */
            modelBuilder.Entity<Urun>()
                .HasOne(p => p.Kategori)
                .WithMany(p => p.Urunler)
                .OnDelete(DeleteBehavior.Restrict);

            
               


            modelBuilder.Entity<Kategori>()
                .HasData(new Kategori { Id = 1, KategoriAdi = "Yiyecek" },
                new Kategori { Id = 2, KategoriAdi = "İcecek" });

            modelBuilder.Entity<Urun>()
                .HasData(new Urun { Id = 1, UrunAdi = "Peynir", KategoriId = 1 },
                new Urun { Id = 2, UrunAdi = "Ekmek", KategoriId = 1 },
                new Urun { Id = 3, UrunAdi = "Kavun", KategoriId = 1 },
                new Urun { Id = 4, UrunAdi = "Karpuz", KategoriId = 1 });

        }

        public SqlDbContext()
        {
        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options)
            : base(options)
        {
        }

    }
}
