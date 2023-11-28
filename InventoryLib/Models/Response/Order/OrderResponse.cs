using System;
using InventoryLib.Models.Response.OrderDetail;
using InventoryLib.Services;

namespace InventoryLib.Models.Response.Order
{
	public class OrderResponse : IResponse
	{
		public string Id { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<OrderDetailResponse>? OrderDetails { get; set; }
    }
}

