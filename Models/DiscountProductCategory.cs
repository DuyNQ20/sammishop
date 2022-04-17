using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sammishop.Models
{
    public class DiscountProductCategory : BaseModel
    {
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
