using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sammishop.Models
{
    public class DiscountProduct : BaseModel
    {
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
