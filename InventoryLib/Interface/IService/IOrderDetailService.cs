using System;
using InventoryLib.Models.Request.Order;
using InventoryLib.Models.Request.OrderDetail;
using InventoryLib.Models.Response.Order;
using InventoryLib.Models.Response.OrderDetail;
using InventoryLib.Services;

namespace InventoryLib.Interface.IService
{
	public interface IOrderDetailService : IService<OrderDetailResponse,OrderDetailCreateReq,OrderDetailUpdateReq>
	{
		
	}
}

