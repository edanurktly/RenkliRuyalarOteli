using RenkliRuyalarOteli.Entities.Entites.Abstarct;

namespace RenkliRuyalarOteli.Entities.Entites.Concrete
{
    public class Rezervasyon : BaseEntity
    {
        //Hnagi Odaya Rezervasyon Yapildi
        public Guid OdaId { get; set; }
        public Oda Oda { get; set; }

        //Odanın O Tarihteki Fiyati nedir
        public Guid OdaFiyatId { get; set; }
        public OdaFiyat OdaFiyat { get; set; }

        //Odaya Giris ve Cikis Tarihleri
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public Guid KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public ICollection<RezervasyonDetay> RezervasyonDetaylari { get; set; }

    }
}
