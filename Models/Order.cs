namespace SmartPhone.Models
{
    public class Order : BaseModel
    {
        public string Code { get; set; }

        public string DeliveryAddress { get; set; }

        public string Phone { get; set; }

        public string Receiver { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int? PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public int Quantity { get; set; }

        public decimal SalePrice { get; set; }

        public decimal Total { get; set; }

        public int OrderStatusId { get; set; }
        public OrderStatus orderStatus { get; set; }
    }
}
