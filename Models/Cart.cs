namespace SmartPhone.Models
{
    public class Cart : BaseModel
    {
        public virtual int ProductId { get; set; }
        public Product Product { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public int Quantity { get; set; }
    }
}
