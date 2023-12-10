using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.Category
{
    public class CategoryUpdateReq
    {
        public string Id { get; set; } = "";
        public string? Name { get; set; } = "";
        public string? Image { get; set; } = "";
        public string? Description { get; set; }
    }
}
