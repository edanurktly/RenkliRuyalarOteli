namespace RenkliRuyalarOteli.Entities.Entites.Abstarct
{
    public enum Status
    {
        Active = 1,
        Update = 2,
        Delete = 3
    }
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public string CreateUser { get; set; }
        public Status Status { get; set; }
    }
}
