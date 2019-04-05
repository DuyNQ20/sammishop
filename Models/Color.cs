using System.Collections.Generic;

namespace SmartPhone.Models
{
    public class Color : BaseModel
    {
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
