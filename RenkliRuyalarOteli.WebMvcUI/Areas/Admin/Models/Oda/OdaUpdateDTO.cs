namespace RenkliRuyalarOteli.WebMvcUI.Areas.Admin.Models.Oda
{
    public class OdaUpdateDTO
    {
        public Guid Id { get; set; }
        public string OdaNo { get; set; }

        public int KisiSayisi { get; set; }
        public bool Durum { get; set; }

    }
}
