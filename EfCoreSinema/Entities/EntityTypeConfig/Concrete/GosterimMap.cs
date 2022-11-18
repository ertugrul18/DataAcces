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
    public class GosterimMap:BaseMap<Gosterim,Guid>
    {
        public override void Configure(EntityTypeBuilder<Gosterim> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => new { p.HaftaId, p.SalonId, p.FilmId, p.SeansId }).IsUnique();
            
        }
    }
}
