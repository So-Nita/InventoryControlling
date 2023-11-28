using InventoryLib.Services;

namespace InventoryLib.Models.Response.Product;

public class ProductResponse : IResponse
{
    public string Id { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal Cost { get; set; }
    public string Image { get; set; } = "";
    public string? Description { get; set; } = null!;
    public DateTime? CreatedAt { get; set; }
    public string CategoryId { get; set; }= null!;
    public string CategoryName { get; set; } = null!;
}