using RenkliRuyalarOteli.Entities.Entites.Abstarct;

namespace RenkliRuyalarOteli.Entities.Entites.Concrete
{
    public class Oda : BaseEntity
    {
        public string OdaNo { get; set; }
        public byte KisiSayisi { get; set; }
        public bool Durum { get; set; } = true;
        public ICollection<OdaFiyat> OdaFiyatlari { get; set; }
        public ICollection<Rezervasyon> Rezervasyonlar { get; set; }

    }
}
