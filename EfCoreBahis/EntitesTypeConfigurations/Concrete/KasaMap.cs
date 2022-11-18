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
    public class KasaMap:BaseMap<Kasa>
    {
        public override void Configure(EntityTypeBuilder<Kasa> builder)
        {
           builder.Property(p=>p.KasaAdi).HasMaxLength(64); //Kasa icerisindeki KasaAdi propert'sinin max uzunlugu
            builder.HasIndex(p => p.KasaAdi).IsUnique();//Kasa adindan sadece 1 adet kayit olmasini sagliyoruz
            
            //TL Kasaini olusturuyoruz
            builder.HasData(new Kasa() { Id = 1, KasaAdi = "TL Kasasi", CreateDate = DateTime.Now, ToplamBakiye = 100000 });


            //Burasini yanlislikla silmeyin. BaseEntity'nin configurayion'i burada yapilir.
            base.Configure(builder);

        }
    }
}
