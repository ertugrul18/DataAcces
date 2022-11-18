using EfCoreSinema.Entities.Abstract;
using EfCoreSinema.Entities.Concrete;
using EfCoreSinema.Entities.EntityTypeConfig.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Contexts
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Seans> Seanslar{ get; set; }
        public DbSet<Hafta> Haftalar { get; set; }
        public DbSet<Salon> Salonlar{ get; set; }
        public DbSet<Gosterim> Gosterimler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Sinema;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            
        }


        public override int SaveChanges()
        {
            UpdateSoftDelete();
            return base.SaveChanges();
        }

        private void UpdateSoftDelete()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["Status"] = Status.Delete;
                        entry.CurrentValues["DeleteDate"] = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["Status"] = Status.Update;
                        entry.CurrentValues["UpdateDate"] = DateTime.Now;

                        break;
                    case EntityState.Added:
                        entry.CurrentValues["Status"] = Status.Active;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
