using EfCoreBahis.Entites.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBahis.EntitesTypeConfigurations.Abstract
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {

            builder.HasKey(p => p.Id);

            builder.Property(p => p.CreateDate)
                .IsRequired(true)
                .HasColumnName("CreateDate")
                .HasColumnType("datetime2");
            
            builder.Property(p => p.UpdateDate)
                .IsRequired(false)
                .HasColumnName("UpdateDate")
                .HasColumnType("datetime2");


        }
    }
}
