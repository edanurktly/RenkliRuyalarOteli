﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenkliRuyalarOteli.Entities.Entites.Concrete;

namespace RenkliRuyalarOteli.DAL.EntityConfigrations
{
    public class RezervasyonConfiguration : BaseEntityConfiguration<Rezervasyon>
    {
        public override void Configure(EntityTypeBuilder<Rezervasyon> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.Oda)
                .WithMany(p => p.Rezervasyonlar)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);

            builder.HasOne(p => p.OdaFiyat)
                .WithMany(p => p.Rezervasyonlar)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);

            builder.HasOne(p => p.Kullanici)
                .WithMany(p => p.Rezervasyonlar).
                OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);


        }
    }
}
