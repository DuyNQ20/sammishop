namespace SmartPhone.ViewModels
{
    public class CartView
    {
        public bool Active { get; set; }

        public virtual int ProductId { get; set; }

        public int? UserId { get; set; }

        public int Quantity { get; set; }

        public CartView()
        {
            Quantity = 1;
        }
    }
}
