
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.Models
{
    public class Vendor : InfoBase
    {
        public virtual List<Product> Products { get; set; }
    }
}
