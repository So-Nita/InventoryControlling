using InventoryLib.Constant;
using InventoryLib.Models;

namespace InventoryLib.Services
{
    public class StockingResponse : IResponse
    {
        public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Status { get; set; }
        public int Qty { get; set; }
        public string? Note {  get; set; }  
        public DateTime TransactionDate {  get; set; }
    }
    
    public class ProductStocking
    {
        public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Status { get; set; } = "";
        public int Qty { get; set; }
        public string? Note { get; set; }
        public DateTime TransactionDate { get; set; }
        public List<StockingResponse> Stockings { get; set; } = new();
    }
}