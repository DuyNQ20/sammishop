using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.ViewModels
{
    public class DiscountProductView
    {
        public int DiscountId { get; set; }

        public int ProductId { get; set; }

        public bool Active { get; set; }
    }
}
