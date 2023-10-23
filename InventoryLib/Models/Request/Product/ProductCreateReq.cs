namespace InventoryLib.Models.Request.Product;

public class ProductCreateReq
{
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public decimal SellPrice { get; set; }
    public string? Description { get; set; }
}