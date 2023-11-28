using InventoryLib.Constant;
using InventoryLib.Interface;
using InventoryLib.Models;

namespace InventoryLib.Services
{
    public abstract class StockTransaction
    {
        protected readonly string ProductId;
        protected readonly int Qty;
        public abstract int Factor { get; }

        protected StockTransaction(string productId, int qty, DateTime date, StatusType status)
        {
            ProductId = productId;
            Qty = qty;
        }
        public abstract void OperateOn(StockingService stockingService);

        public abstract Stocking GetStock();

        protected void AddQtyToStock(StockingService stockingService)
        {
            var product = stockingService.Read(new Key() { Id = ProductId });
            product.Result.Qty += Qty * Factor;
        }
    }

    public class StockInTransaction : StockTransaction
    {
        public StockInTransaction(string productId, int qty)
            : base(productId, qty, DateTime.Now, StatusType.StockIn)
        {
        }

        public override int Factor => 1;

        public override void OperateOn(StockingService stockingService)
        {
            AddQtyToStock(stockingService);
        }

        public override Stocking GetStock()
        {
            return new Stocking
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = ProductId,
                Qty = Qty,
                TransactionDate = DateTime.Now,
                Status = StatusType.StockIn
            };
        }
    }

    public class StockOutTransaction : StockTransaction
    {
        public StockOutTransaction(string productId, int qty)
            : base(productId, qty, DateTime.Now, StatusType.StockOut)
        {
        }

        public override int Factor => -1;

        public override void OperateOn(StockingService stockingService)
        {
            AddQtyToStock(stockingService);
        }

        public override Stocking GetStock()
        {
            return new Stocking
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = ProductId,
                Qty = Qty,
                TransactionDate = DateTime.Now,
                Status = StatusType.StockOut
            };
        }
    }   
}