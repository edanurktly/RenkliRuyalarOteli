using RenkliRuyalarOteli.Entities.Entites.Abstarct;

namespace RenkliRuyalarOteli.Entities.Entites.Concrete
{
    public class OdaFiyat : BaseEntity
    {
        public Oda Oda { get; set; }
        public Guid OdaId { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public float Fiyat { get; set; }
        public Guid KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public ICollection<Rezervasyon> Rezervasyonlar { get; set; }

    }
}
