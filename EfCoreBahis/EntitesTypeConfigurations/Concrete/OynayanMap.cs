using EfCoreBahis.Entites.Concrete;
using EfCoreBahis.EntitesTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBahis.EntitesTypeConfigurations.Concrete
{
    public class OynayanMap:BaseMap<Oynayan>
    {
        public override void Configure(EntityTypeBuilder<Oynayan> builder)
        {
            builder.Property(p=>p.TcNo).HasMaxLength(11);
            builder.Property(p => p.AdSoyad).HasMaxLength(30);
            builder.HasIndex(p => p.TcNo).IsUnique();


            builder.HasData(
                new Oynayan() { Id = 1, TcNo="123", AdSoyad = "Ali Yilmaz", CreateDate = DateTime.Now, Bakiye = 1000 },
                new Oynayan() { Id = 2, TcNo = "124", AdSoyad = "Ayse Kaya", CreateDate = DateTime.Now, Bakiye = 1000 },
                new Oynayan() { Id = 3, TcNo = "125", AdSoyad = "Hasan Mert", CreateDate = DateTime.Now, Bakiye = 1000 },
                new Oynayan() { Id = 4, TcNo = "126", AdSoyad = "Fatma Tasdemir", CreateDate = DateTime.Now, Bakiye = 1000 }
                );
            
            base.Configure(builder);
        }
    }
}
