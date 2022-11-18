using EfCoreSinema.Entities.Concrete;
using EfCoreSinema.Entities.EntityTypeConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entities.EntityTypeConfig.Concrete
{
    public class KategoriMap:BaseMap<Kategori,Guid>
    {

        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.KategoriAdi).HasMaxLength(50);
            builder.Property(p => p.Aciklama).HasMaxLength(100);

            // Ayni Kategori isminden bir tane daha olmasin 
            builder.HasIndex(p => p.KategoriAdi).IsUnique();

        }
    }
}
