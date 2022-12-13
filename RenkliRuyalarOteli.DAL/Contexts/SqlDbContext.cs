﻿using Microsoft.EntityFrameworkCore;
using RenkliRuyalarOteli.Entities.Entites.Concrete;

namespace RenkliRuyalarOteli.DAL.Contexts
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Oda> Odalar { get; set; }
        public DbSet<OdaFiyat> OdaFiyatlari { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=RenkliRuyalarOteli;Trusted_Connection=true");
        }
    }
}
