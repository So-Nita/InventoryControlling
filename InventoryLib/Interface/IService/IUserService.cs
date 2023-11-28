using System;
using InventoryLib.Constant;
using InventoryLib.DataResponse;
using InventoryLib.Services;

namespace InventoryLib.Interface.IService
{
	public interface IUserService<T>
	{
        public Response<T> Read(string Id);

        public Response<List<T>> ReadAll();
	}
}

