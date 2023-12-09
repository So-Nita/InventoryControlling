using InventoryApiClient.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.Order
{
    public class OrderCreateReq
    {
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
    public class OrderDetail
    {
        public string ProductId { get; set; } = null!;
        public int Qty { get; set; }
    }

}
