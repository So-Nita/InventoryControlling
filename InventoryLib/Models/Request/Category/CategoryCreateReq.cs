using System;
using InventoryLib.Services;

namespace InventoryLib.Models.Request.Category
{
	public class CategoryCreateReq : ICreateReq
	{
        public string Name { get; set; } = "";
        public string Image { get; set; } = null!;
        public string? Description { get; set; }
    }
}

