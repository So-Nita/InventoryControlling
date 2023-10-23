using System.Collections;
using InventoryLib.Interface;
using InventoryLib.Models;
using InventoryLib.Models.Request.Product;
using InventoryLib.Models.Response.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace InventoryLib.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public Task<List<ProductResponse>> GetAllProducts()
    {
        var products = _unitOfWork.GetRepository<Product>()
            .GetQueryable()
            .Include(e => e.Category)
            .Select(e => new ProductResponse()
            {
                Id = e.Id,
                Code = e.Code,
                Name = e.Name,
                Price = e.Price,
                SellPrice = e.SellPrice,
                Description = e.Description!,
                CreatedAt = e.CreatedAt,
                CategoryId = e.CategoryId,
                CategoryName = e.Category.Name
            }).ToListAsync();
        return Task.FromResult(products.Result);
    }
    
    public Task<Product> CreateProduct(ProductCreateReq req)
    {
        if(req.Code.IsNullOrEmpty()) throw new SecurityTokenException("Code is required");
        if (req.Name.IsNullOrEmpty()) throw new SecurityTokenException("Name is required");
        if (req.Price == 0) throw new SecurityTokenException("Price is required");
        if(req.Price > req.SellPrice) throw new SecurityTokenException("Price must be less than Sell Price");
        var existPro = GetAllProducts().Result.FirstOrDefault(e=>e.Code==req.Code);
        if(existPro != null) throw new SecurityTokenException("Product code is existing.");
        var product = new Product()
        {
            Id = Guid.NewGuid().ToString(),
            Code = req.Code,
            Name = req.Name,
            Price = req.Price,
            SellPrice = req.SellPrice,
            Description = req.Description,
            CategoryId = req.CategoryId,
            CreatedAt = DateTime.Now,
            IsDeleted = false,
        };
        try
        {
            _unitOfWork.GetRepository<Product>().Add(product);
            _unitOfWork.Save();
            return Task.FromResult(product);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Task.FromResult<Product>(null!);
        }
    }

    public Task<Product> GetProductById(Key key)
    {
        var product = _unitOfWork.GetRepository<Product>().GetById(key.Id).Result;
        if (product == null) throw new SecurityTokenException("Product does not existing.");
        return Task.FromResult(product);
    }

    
    public Task<bool> UpdateProduct(ProductUpdateReq req)
    {
        if(req.Id.IsNullOrEmpty()) throw new SecurityTokenException("Product identify is required");
        var product = _unitOfWork.GetRepository<Product>().GetQueryable().FirstOrDefault(e=>e.Id==req.Id);
        
        if(req.Price > req.SellPrice) throw new SecurityTokenException("Price must be less than Sell Price");
        if (product == null) throw new SecurityTokenException("Product does not existing.");
        product.Name = req.Name;
        product.Price = req.Price;
        product.SellPrice = req.SellPrice;
        product.Description = req.Description;
        try
        {
            _unitOfWork.GetRepository<Product>().Update(product);
            _unitOfWork.Save();
            return Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Task.FromResult(false);
        }
    }

    public Task<bool> DeleteProduct(Key key)
    {
        var product = _unitOfWork.GetRepository<Product>().GetQueryable().FirstOrDefault(e=> e.Code==key.Code || e.Id==key.Id);
        if (product == null) throw new SecurityTokenException("Product does not existing.");
        try
        {
            _unitOfWork.GetRepository<Product>().Delete(product);
            _unitOfWork.Save();
            return Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Task.FromResult(false);
        }
    }
}



