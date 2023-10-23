namespace InventoryLib.Models.Response.Product;

public class ProductResponse
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal SellPrice { get; set; }
    public string Description { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
}