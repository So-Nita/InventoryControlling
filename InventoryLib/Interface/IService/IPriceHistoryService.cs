using System;
using InventoryLib.Constant;
using InventoryLib.DataResponse;
using InventoryLib.Models.Request.PriceHistory;
using InventoryLib.Services;

namespace InventoryLib.Interface.IService
{
	public interface IPriceHistoryService<T>
	{
		public Response<T> Read(string productId);
		public Response<List<T>> ReadAll();
    }
}

