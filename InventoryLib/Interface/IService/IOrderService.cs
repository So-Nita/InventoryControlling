using System;
using InventoryLib.Constant;
using InventoryLib.DataResponse;
using InventoryLib.Models;
using InventoryLib.Models.Request.Order;
using InventoryLib.Models.Response.Order;
using InventoryLib.Services;

namespace InventoryLib.Interface.IService
{
	public interface IOrderService : IService<OrderResponse,OrderCreateReq,OrderUpdateReq>
	{
		Response<string> DeleteDetails(ICollection<Key> keys);
	}
}

