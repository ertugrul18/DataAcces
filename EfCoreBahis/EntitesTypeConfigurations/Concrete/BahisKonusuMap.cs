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
    public class BahisKonusuMap:BaseMap<BahisKonusu>
    {
        public override void Configure(EntityTypeBuilder<BahisKonusu> builder)
        {
            builder.Property(p => p.BahisAciklama).HasMaxLength(300);
            
            builder.HasData(new BahisKonusu() { Id=1,CreateDate=DateTime.Now,
                                                Acikmi=true,
                                                BahisAciklama="Derse Gec Kalma",
                                                KapanisSaati=DateTime.Now.AddDays(1)}
                            );
            base.Configure(builder);
        }
    }
}
