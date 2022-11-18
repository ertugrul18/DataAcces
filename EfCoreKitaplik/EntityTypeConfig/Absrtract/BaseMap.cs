using EfCoreKitaplik.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplik.EntityTypeConfig.Absrtract
{
    public class BaseMap<Type, Key> : IEntityTypeConfiguration<Type> where Type : BaseEntity<Key>
    {
        public virtual void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p=>p.CreateDate).HasColumnType("datetime").HasDefaultValueSql("GetDate()");
            builder.Property(p => p.UpdateDate).HasColumnType("datetime");
            builder.Property(p => p.DeleteDate).HasColumnType("datetime");
        }
    }
}
