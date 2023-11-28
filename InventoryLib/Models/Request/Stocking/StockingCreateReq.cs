using InventoryLib.Constant;

namespace InventoryLib.Services
{
    public class StockingCreateReq : ICreateReq
    {
        public string ProductId { get; set; } = "";
        public StatusType Status { get; set; }
        public int Qty { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}