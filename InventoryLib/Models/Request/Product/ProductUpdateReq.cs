using InventoryLib.Services;

namespace InventoryLib.Models.Request.Product;

public class ProductUpdateReq : IUpdateReq
{
    public string Id { get; set; } = "";
    //public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public decimal SellPrice { get; set; }
    public string? Description { get; set; }
}