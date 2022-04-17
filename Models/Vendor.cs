using System.Collections.Generic;

namespace Sammishop.Models
{
    public class Vendor : InfoBase
    {
        public virtual List<Product> Products { get; set; }
    }
}
