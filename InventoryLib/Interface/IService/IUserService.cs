using System;
using InventoryLib.Constant;
using InventoryLib.DataResponse;
using InventoryLib.Models.Request.User;
using InventoryLib.Services;

namespace InventoryLib.Interface.IService
{
	public interface IUserService<T>
	{
        public Response<T> Read(UserRequest req);

        public Response<List<T>> ReadAll();
	}
}

