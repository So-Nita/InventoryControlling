using InventoryLib.Constant;

namespace InventoryLib.Services
{
    public class StockingUpdateReq : IUpdateReq
    {
        public string Id { get; set; } = "";
        public int? Qty { get; set; }
        public StatusType? Status { get; set; }
    }
}