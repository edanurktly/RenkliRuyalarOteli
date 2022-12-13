using RenkliRuyalarOteli.Entities.Entites.Abstarct;

namespace RenkliRuyalarOteli.Entities.Entites.Concrete
{
    public class OdaFiyat : BaseEntity
    {
        public Guid OdaId { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public float Fiyat { get; set; }
        public ICollection<Rezervasyon> Rezervasyonlar { get; set; }

    }
}
