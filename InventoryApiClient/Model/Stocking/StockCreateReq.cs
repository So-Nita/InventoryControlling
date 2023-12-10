using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.Stocking
{
    public class StockCreateReq
    {
        public string Id { get; set; } = "";
        //public string ProductId { get; set; } = "";
        public string Status { get; set; } = "";
        public int Qty { get; set; }    
        public string? Note { get; set; }
    }
}
