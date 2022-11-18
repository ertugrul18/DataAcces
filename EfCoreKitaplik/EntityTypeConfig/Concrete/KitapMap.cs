using EfCoreKitaplik.Entities.Concrete;
using EfCoreKitaplik.EntityTypeConfig.Absrtract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplik.EntityTypeConfig.Concrete
{
    public class KitapMap:BaseMap<Kitap,Guid>
    {

        public override void Configure(EntityTypeBuilder<Kitap> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.KitapAdi).HasMaxLength(50);
            
        }
    }
}
