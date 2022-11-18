using EfCoreKalitim.Abstract;
using EfCoreKalitim.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKalitim.Contexts
{
    public class OkulSqlDbcontext:DbContext
    {
        public DbSet<Ogrenci>   Ogrenciler { get; set; }
        public DbSet<Brans> Branslar { get; set; }
        public DbSet<Ogretmen>  Ogretmenler { get; set; }
        public DbSet<Sinif>  Sinif { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\Mssqllocaldb;Database=OkulDb;Trusted_Connection=True");
        }
    }
}
