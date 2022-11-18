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
    public class BahisCesitMap:BaseMap<BahisCesit>
    {
        public override void Configure(EntityTypeBuilder<BahisCesit> builder)
        {

            builder.Property(p=>p.Aciklama).HasMaxLength(100);



            base.Configure(builder);
        }
    }
}
