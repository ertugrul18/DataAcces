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
    public class BahisCesitDetayMap:BaseMap<BahisCesitDetay>
    {
        public override void Configure(EntityTypeBuilder<BahisCesitDetay> builder)
        {
            
            base.Configure(builder);
        }
    }
}
