using InventoryLib.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.Models
{
    public class User
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Image { get; set; } = "";
        public RoleType Role { get; set; }
        public string Contact { get; set; } =null!; 
        public string Password { get; set; } = null!;
    }

}
