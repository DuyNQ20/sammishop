using System.Collections.Generic;

namespace SmartPhone.Models
{
    public class Supplier:BaseModel
    {
        public string Name { get; set; }

        public string Info { get; set; }

        public string Logo { get; set; }

        public virtual List<ProductCategory> ProductCategories { get; set; }
    }
}
