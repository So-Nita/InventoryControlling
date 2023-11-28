using InventoryLib.Constant;

namespace InventoryLib.Models;

public class Stocking
{
    public string Id { get; set; } = "";
    public string ProductId { get; set; } = "";
    public StatusType Status { get; set; }
    public int Qty { get; set; }
    public DateTime TransactionDate { get; set; }

    public Product? Product { get; set; } 
}