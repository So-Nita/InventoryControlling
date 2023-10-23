namespace InventoryLib.Models.Response.Product;

public class ProductResponse
{
    public string Id { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal SellPrice { get; set; }
    public string? Description { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public string CategoryId { get; set; }= null!;
    public string CategoryName { get; set; } = null!;
}