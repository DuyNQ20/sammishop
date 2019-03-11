using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SmartPhone.Models
{
    public class Role : BaseModel
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
