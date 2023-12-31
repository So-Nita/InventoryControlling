namespace InventoryLib.Models;

public class Category
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Image { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime? CreatedAt { get; set; }
    public bool? IsDeleted { get; set; }

    public ICollection<Product>? Products { get; set; } = default;
}