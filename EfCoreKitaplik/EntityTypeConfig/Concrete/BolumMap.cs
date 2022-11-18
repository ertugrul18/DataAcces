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
    public class BolumMap:BaseMap<Bolum,Guid>
    {

        public override void Configure(EntityTypeBuilder<Bolum> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.BolumAdi).HasMaxLength(50);
          
            
        }
    }
}
