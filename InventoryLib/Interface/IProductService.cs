using InventoryLib.Models;
using InventoryLib.Models.Response.Product;

namespace InventoryLib.Interface;

public interface IProductService
{
    Task<bool> CreateProduct(Product productDetails);

    Task<IEnumerable<ProductResponse>> GetAllProducts();

    Task<Product> GetProductById(string productId);

    Task<bool> UpdateProduct(Product productDetails);

    Task<bool> DeleteProduct(int productId);
}

