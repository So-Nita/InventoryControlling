using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.Order;

public class OrderResponse
{
    public string Id { get; set; } = "";
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OorderDetails> OrderDetails = new();
}
public class OorderDetails
{
    public string Id { get; set; } = "";
    public string ProductId { get; set; } = "";
    public string ProductName { get; set; }
    public string categoryname { get; set; } = "";
    public string OrderId { get; set; } = "";
    public int Qty { get; set; }    
    public decimal Price { get; set; }
    public decimal GrandTotal {  get; set; }
}
