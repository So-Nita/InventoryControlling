using InventoryLib.DataResponse;

namespace InventoryLib.Services
{
    public interface IStockingService : IService<StockingResponse,StockingCreateReq,StockingUpdateReq>
    {
        public Response<List<ProductStocking>> ReadAllByProudct();
    }
}