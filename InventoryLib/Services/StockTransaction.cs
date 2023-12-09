using System.Transactions;
using InventoryLib.Constant;
using InventoryLib.Interface;
using InventoryLib.Models;

namespace InventoryLib.Services
{
    public abstract class StockTransaction
    {
        protected readonly string ProductId;
        protected readonly int Qty;
        protected readonly string? Note;
        public abstract int Factor { get; }
        public int ProductQty { get; internal set; }
        public abstract StatusType TransactionStatus { get; }

        protected StockTransaction(string productId, int qty,string note ,DateTime date, StatusType status)
        {
            ProductId = productId;
            Qty = qty;
            Note = note;
        }
        public abstract void OperateOn(StockingService stockingService);

        //public abstract Stocking GetStock();
        public Stocking GetStock()
        {
            return new Stocking
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = ProductId,
                Qty = Qty,
                TransactionDate = DateTime.Now,
                Status = TransactionStatus,
                Note = Note
            };
        }
        protected void AddQtyToStock(StockingService stockingService)
        {
            var product = stockingService.Read(new Key() { Id=ProductId});
            ProductQty = product.Result!.Qty + (Qty * Factor);
        }
    }

    public class StockInTransaction : StockTransaction
    {
        public StockInTransaction(string productId, int qty, string note)
            : base(productId, qty, note, DateTime.Now, StatusType.StockOut)
        {
        }

        public override int Factor => 1;

        public override void OperateOn(StockingService stockingService)
        {
            AddQtyToStock(stockingService);
        }

        public override StatusType TransactionStatus => StatusType.StockIn;
       
    }

    public class StockOutTransaction : StockTransaction
    {
        public StockOutTransaction(string productId, int qty,string note)
            : base(productId,qty,note,DateTime.Now,StatusType.StockOut)
        {
        }

        public override int Factor => -1;

        public override void OperateOn(StockingService stockingService)
        {
            AddQtyToStock(stockingService);
        }

        public override StatusType TransactionStatus => StatusType.StockOut;

    }
}