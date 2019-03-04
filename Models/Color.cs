﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.Models
{
    public class Color : BaseModel
    {
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
