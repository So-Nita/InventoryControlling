using InventoryLib.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.Models
{
    public class Order
    {
        public string Id { get; set; } = "";
        public decimal TotalPrice { get; set; }  
        public DateTime OrderDate { get; set; }
        //public string User_Id { get; set; } = "";

        public ICollection<OrderDetail>? OrderDetails { get; set; }  
    }
}
