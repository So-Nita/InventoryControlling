using InventoryLib.Constant;
using InventoryLib.Models;

namespace InventoryLib.Services
{
    public class StockingResponse : IResponse
    {
        //public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public string ProductName { get; set; } = "";
        //public StatusType Status { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public List<Stocking> Stockings { get; set; } = new List<Stocking>();
    }
}