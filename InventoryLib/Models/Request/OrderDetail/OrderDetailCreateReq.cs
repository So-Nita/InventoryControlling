using System;
using InventoryLib.Services;

namespace InventoryLib.Models.Request.OrderDetail
{
	public class OrderDetailCreateReq : ICreateReq
	{
        public string ProductId { get; set; } = "";
        public int Qty { get; set; }
    }
}

