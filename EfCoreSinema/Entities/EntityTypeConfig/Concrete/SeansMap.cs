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
    public class SeansMap:BaseMap<Seans,Guid>
    {
        public override void Configure(EntityTypeBuilder<Seans> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SeansAdi)
                .HasMaxLength(50);


        }
    }
}
