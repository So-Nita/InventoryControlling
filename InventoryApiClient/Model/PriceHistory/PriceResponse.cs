using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.PriceHistory
{
    public class PriceResponse
    {
        /*public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public decimal OldPrice { get; set; }
        public decimal CurrentPrice { get; set; }  
        public DateTime UpdateDate { get; set; }    */
        public ICollection<PriceHistories> PriceHistories { get; set; }
    }
    public class PriceHistories
    {
        public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public decimal OldPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
