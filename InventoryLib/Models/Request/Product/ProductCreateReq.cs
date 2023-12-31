using InventoryLib.Services;

namespace InventoryLib.Models.Request.Product;

public class ProductCreateReq : ICreateReq
{
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public decimal Cost { get; set; }
    public decimal Price { get; set; }
    public string? Image { get; set; } 
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public string CategoryId { get; set; } = null!;
}