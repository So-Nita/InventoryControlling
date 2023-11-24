using InventoryLib.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.Models
{
    public class OrderDetail
    {
        public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public string OrderId { get; set; } = null!;
        public int Qty { get; set; }
        public decimal Price { get; set; }

        public Product? Product { get; set; } = default;
        public Order? Order { get; set; } = null!;
    }
}
