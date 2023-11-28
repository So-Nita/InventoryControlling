using System;
using InventoryLib.Models.Request.OrderDetail;
using InventoryLib.Models.Response.OrderDetail;
using InventoryLib.Services;

namespace InventoryLib.Models.Request.Order
{
	public class OrderUpdateReq : IUpdateReq
	{
        //public string Id { get; set; } = null!;
        //public decimal? TotalPrice { get; set; }

        public ICollection<OrderDetailUpdateReq>? OrderDetails { get; set; }
    }
}

