using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace  Sammishop.ViewModels
{
    public class DiscountView
    {
        public string Code { get; set; }

        public string Descriptions { get; set; }

        public decimal DiscountMoney { get; set; }

        public int Quantity { get; set; }

        public string DateTimeStart { get; set; }

        public string DateTimeFinish { get; set; }

        public bool ApplyAll { get; set; } = true;

        public int DiscountCategoryId { get; set; }

        public int? UserId { get; set; }
    }
}
