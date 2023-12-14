using System;
using InventoryLib.Models.Response.Product;
using InventoryLib.Services;

namespace InventoryLib.Models.Response.Category
{
	public class CategoryResponse : IResponse
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Image { get; set; } = null!;
        public string? Description { get; set; }
        public ICollection<ProductResponse>? Products { get; set; }
    }
}

