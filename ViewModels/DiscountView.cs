using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.ViewModels
{
    public class DiscountView
    {
        public string Code { get; set; }

        public string Descriptions { get; set; }

        public decimal DiscountMoney { get; set; }

        public int Quantity { get; set; }

        public DateTime DateTimeStart { get; set; }

        public DateTime DateTimeFinish { get; set; }

        public int DiscountCategoryId { get; set; }

        public int? UserId { get; set; }
    }
}
