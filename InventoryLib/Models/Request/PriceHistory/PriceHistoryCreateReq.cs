using System;
namespace InventoryLib.Models.Request.PriceHistory
{
	public class PriceHistoryCreateReq
	{
        public string ProductId { get; set; } = "";
        public decimal OldPrice { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}

