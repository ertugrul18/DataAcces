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
    public class OynananMap:BaseMap<Oynanan>
    {
        public override void Configure(EntityTypeBuilder<Oynanan> builder)
        {
            builder.Property(p=>p.Adi).HasMaxLength(256);
            
            base.Configure(builder);
        }
    }
}
