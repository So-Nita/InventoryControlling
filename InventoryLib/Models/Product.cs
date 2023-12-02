namespace InventoryLib.Models;

public class Product
{
    public string Id { get; set; } = "";
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    //public decimal SellPrice { get; set; }
    public int? Qty { get; set; }
    public string Image { get; set; } = "";
    public decimal Cost { get; set; }
    public string CategoryId { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime? CreatedAt { get; set; }
    public bool? IsDeleted { get; set; }

    // Navigation
    public Category Category { get; set; } = null!;
    public ICollection<Stocking>? Stockings { get; set; }= default;
    public ICollection<OrderDetail>? OrderDetails { get; set; } = default;
    public ICollection<PriceHistory>? PriceHistories { get; set; } = default;
}