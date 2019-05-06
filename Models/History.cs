namespace SmartPhone.Models
{
    public class History : BaseModel
    {
        public  int? UserId { get; set; }
        public User User { get; set; }

        public int? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
