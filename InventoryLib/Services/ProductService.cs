using InventoryLib.Interface;
using InventoryLib.Models;

namespace InventoryLib.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        var products = _unitOfWork.GetRepository<Product>().GetAll().Result;
        return products;
    }

    
    public Task<bool> CreateProduct(Product productDetails)
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetProductById(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateProduct(Product productDetails)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProduct(int productId)
    {
        throw new NotImplementedException();
    }
}