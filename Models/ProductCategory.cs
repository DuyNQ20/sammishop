using System.Collections.Generic;

namespace SmartPhone.Models
{
    public class ProductCategory : BaseModel
    {
        public string Name { get; set; }
        
        public virtual List<Product> Products { get; set; }

        public virtual List<DiscountProductCategory> DiscountProductCategories { get; set; }
    }
}
