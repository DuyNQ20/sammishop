using System.Collections.Generic;

namespace SmartPhone.Models
{
    public class Role : BaseModel
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
