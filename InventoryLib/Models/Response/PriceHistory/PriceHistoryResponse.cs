using System;
namespace InventoryLib.Models.Response
{
	public class PriceHistoryResponse
	{
        public string ProductId { get; set; } = "";
        public string ProductCode { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Image { get; set; } = "";
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public List<PriceHistory> PriceHistories { get; set; } = null!;
    }
}

