using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.Models
{
    public class Discount : BaseModel
    {
        public string Code { get; set; }

        public string Descriptions { get; set; }

        public decimal DiscountMoney { get; set; }

        public int Quantity { get; set; }

        public DateTime DateTimeStart { get; set; }

        public DateTime DateTimeFinish { get; set; }

        public int DiscountCategoryId { get; set; }
        public DiscountCategory DiscountCategory { get; set; }

        public bool ApplyAll { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public virtual List<DiscountProduct> DiscountProducts { get; set; }

        public virtual List<DiscountProductCategory> DiscountProductCategories { get; set; }
        
    }
}
