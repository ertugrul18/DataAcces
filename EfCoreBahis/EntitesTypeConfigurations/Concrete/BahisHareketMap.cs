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
    public class BahisHareketMap:BaseMap<BahisHareket>
    {
        public override void Configure(EntityTypeBuilder<BahisHareket> builder)
        {

            base.Configure(builder);
        }
    }
}
