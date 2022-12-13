﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenkliRuyalarOteli.Entities.Entites.Abstarct;

namespace RenkliRuyalarOteli.DAL.EntityConfigrations
{
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(p => p.Id)
                .HasDefaultValue(new Guid());

            builder.Property(p => p.CreateDate)
                .HasDefaultValue(new DateTime());

            builder.Property(p => p.Status).HasDefaultValue(1);





        }
    }
}
