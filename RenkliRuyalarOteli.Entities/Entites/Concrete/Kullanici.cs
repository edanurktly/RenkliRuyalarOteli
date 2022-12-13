using RenkliRuyalarOteli.Entities.Entites.Abstarct;

namespace RenkliRuyalarOteli.Entities.Entites.Concrete
{
    public class Kullanici : BaseEntity
    {

        public string Email { get; set; }

        public string Password { get; set; }
        public string TcNo { get; set; }
    }
}
