using System;
using InventoryLib.Services;

namespace InventoryLib.Models.Request.OrderDetail
{
	public class OrderDetailUpdateReq : IUpdateReq
	{
        public string Id { get; set; } = "";
        //public string? ProductId { get; set; } = "";
        //public string OrderId { get; set; } = null!;
        public int? Qty { get; set; }
        //public decimal? Price { get; set; }
    }
}

