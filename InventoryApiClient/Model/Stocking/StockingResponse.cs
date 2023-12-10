using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.Stocking
{
    public class StockingResponse
    {
        public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Status { get; set; } = "";
        public int? Qty { get; set; }
        public string? Note { get; set; }
        public DateTime TransactionDate { get; set; }
    }
    public class StockingsDataResponse
    {
        public int Status { get; set; }
        public int Total { get; set; }
        public List<StockingResponse> Result { get; set; }
    }

}
