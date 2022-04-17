
namespace Sammishop.Models
{
    public class User : InfoBase
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        //public virtual List<Cart> Carts { get; set; }
    }
}   