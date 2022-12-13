using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenkliRuyalarOteli.Entities.Entites.Concrete;

namespace RenkliRuyalarOteli.DAL.EntityConfigrations
{
    public class RezervasyonConfiguration : BaseEntityConfiguration<Rezervasyon>
    {
        public override void Configure(EntityTypeBuilder<Rezervasyon> builder)
        {
            base.Configure(builder);

        }
    }
}
