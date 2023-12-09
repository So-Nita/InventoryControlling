using System;
namespace InventoryLib.Models.Request.User
{
	public class UserRequest
	{
		public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}

