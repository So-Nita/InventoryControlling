using System;
using InventoryLib.Constant;

namespace InventoryLib.Models.Response.User
{
	public class UserResponse
	{
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Image { get; set; } = "";
        public string Role { get; set; } = "";
        public string Contact { get; set; } = "";
        public string Password { get; set; } = null!;
    }
}

