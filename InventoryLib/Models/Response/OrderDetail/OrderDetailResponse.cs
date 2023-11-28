using System;
using InventoryLib.Services;

namespace InventoryLib.Models.Response.OrderDetail
{
	public class OrderDetailResponse : IResponse
	{
        public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Categoryname { get; set; } = "";
        public string OrderId { get; set; } = null!;
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal GrandTotal { get; set; }
    }
}

