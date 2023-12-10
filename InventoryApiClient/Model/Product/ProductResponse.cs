using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.Product
{
    public class ProductResponse
    {
        public string Id { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int? Qty { get; set; }
        public string? Image { get; set; }  
        public string? Description { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public string CategoryId { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
    }
}
