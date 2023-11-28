using System;
using InventoryLib.Models.Request.OrderDetail;
using InventoryLib.Services;

namespace InventoryLib.Models;

	public class OrderCreateReq : ICreateReq
    {
        public ICollection<OrderDetailCreateReq> OrderDetails { get; set; } = null!;
    }

