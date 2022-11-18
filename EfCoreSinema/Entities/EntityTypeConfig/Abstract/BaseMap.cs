using EfCoreSinema.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entities.EntityTypeConfig.Abstract
{
    public abstract class BaseMap<T, Key> : IEntityTypeConfiguration<T> where T : BaseEntity<Key>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasDefaultValue(Guid.NewGuid());
            builder.Property(p=>p.CreateDate)
                .HasColumnType("datetime")
                .IsRequired(true);

            builder.Property(p => p.UpdateDate)
                .HasColumnType("datetime")
                .IsRequired(false);

            builder.Property(p => p.DeleteDate)
                            .HasColumnType("datetime")
                            .IsRequired(false);
            builder.Property(p => p.Status)
                .IsRequired(true);

            // Global Sorgu tanimlamasi . Yapilacak butun sorgularin sonuna where status = 1 ifadesini ekelemeye yarar.
            builder.HasQueryFilter(p => p.Status == Status.Active || p.Status==Status.Update);
        }
    }
}
