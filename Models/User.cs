using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace SmartPhone.Models
{
    public class User : InfoBase
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public virtual List<Cart> Carts { get; set; }
    }
}
