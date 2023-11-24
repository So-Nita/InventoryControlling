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
        public RoleType Role { get; set; }
        public long Contact { get; set; }
        public string Password { get; set; } = null!;
    }
}
