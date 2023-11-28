using System;
using InventoryLib.Interface;

namespace InventoryLib.Services.StockCal
{
    public class StockIn : StockingService
    {
        public StockIn(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }
}

