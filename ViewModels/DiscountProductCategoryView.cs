using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.ViewModels
{
    public class DiscountProductCategoryView
    {
        public int DiscountId { get; set; }

        public int ProductCategoryId { get; set; }

        public bool Active { get; set; }
    }
}
