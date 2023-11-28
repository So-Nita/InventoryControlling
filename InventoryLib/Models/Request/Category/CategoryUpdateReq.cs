using System;
using InventoryLib.Services;

namespace InventoryLib.Models.Request.Category
{
	public class CategoryUpdateReq : IUpdateReq
	{
        public string Id { get; set; } = "";
        public string? Name { get; set; } = "";
        public string? Image { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsDeleted { get; set; }
    }
}

