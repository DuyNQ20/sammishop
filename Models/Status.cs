using System.Collections.Generic;

namespace Sammishop.Models
{
    public class Status : BaseModel
    {
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
