namespace SmartPhone.ViewModels
{
    public class OrderView
    {
        public string Code { get; set; }

        public string DeliveryAddress { get; set; }

        public string Phone { get; set; }

        public string Receiver { get; set; }

        public int Quantity { get; set; }

        public decimal SalePrice { get; set; }

        public decimal Total { get; set; }

        public int? UserId { get; set; }

        public int ProductId { get; set; }

        public int OrderStatusId { get; set; }
    }
}
