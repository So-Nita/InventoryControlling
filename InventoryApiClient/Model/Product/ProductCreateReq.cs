using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.Product
{
    public class ProductCreateReq
    {
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; } = "";
        public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
   