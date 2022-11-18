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
    public class FilmMap:BaseMap<Film,Guid>
    {

        public override void Configure(EntityTypeBuilder<Film> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.FilmAdi).HasMaxLength(100);
            builder.Property(p => p.Aciklama).HasMaxLength(500);
            
        }
    }
}
