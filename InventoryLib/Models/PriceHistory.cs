using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.Models
{
    public class PriceHistory
    {
        public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public decimal OldPrice { get; set; }  
        public decimal CurrentPrice { get; set; }
        public DateTime UpdateDate { get; set; }

        public Product Product { get; set; } = null!;
    }
}
