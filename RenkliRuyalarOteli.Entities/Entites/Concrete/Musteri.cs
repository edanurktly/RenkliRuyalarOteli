using RenkliRuyalarOteli.Entities.Entites.Abstarct;

namespace RenkliRuyalarOteli.Entities.Entites.Concrete
{
    public class Musteri : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public string MusteriTcNo { get; set; }
        public string CepNo { get; set; }

        public ICollection<Rezervasyon> Rezervasyonlar { get; set; }
    }
}



