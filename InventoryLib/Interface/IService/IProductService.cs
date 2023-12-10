using InventoryLib.DataResponse;
using InventoryLib.Models;
using InventoryLib.Models.Request.Product;
using InventoryLib.Models.Response.Product;
using InventoryLib.Services;

namespace InventoryLib.Interface;

public interface IProductService : IService<ProductResponse,ProductCreateReq,ProductUpdateReq>
{
    public Response<string> ReActiveProduct(Key id);
    //Task<List<ProductResponse>> GetAllProducts();

    //Task<Product> GetProductById(Key key);

    //Task<bool> UpdateProduct(ProductUpdateReq productDetails);

    //Task<bool> DeleteProduct(Key productId);
}

