using System.Collections.Generic;

namespace SmartPhone.Models
{
    public class Vendor : InfoBase
    {
        public virtual List<Product> Products { get; set; }
    }
}
