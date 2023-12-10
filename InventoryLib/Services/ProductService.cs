using System.Collections;
using InventoryLib.DataResponse;
using InventoryLib.Interface;
using InventoryLib.Models;
using InventoryLib.Models.Request.PriceHistory;
using InventoryLib.Models.Request.Product;
using InventoryLib.Models.Response;
using InventoryLib.Models.Response.Product;
using InventoryLib.Validation;
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
    
    public Response<string> Create(ProductCreateReq req)
    {
        var validationErrors = DataValidation<ProductCreateReq>.ValidateDynamicTypes(req);
        if (validationErrors.Count > 0)
        {
            return Response<string>.Fail(data: validationErrors.First().ToString());
        }
        var existPro = ReadAll().Result!.FirstOrDefault(e => e.Code == req.Code);
        if (existPro != null)
        {
            return Response<string>.Conflict("Product's Code is existing.");
        }
        if (req.Price < req.Cost)
        {
            return Response<string>.Fail("Price must be more than Cost.");
        }
        var image = req.Image.IsNullOrEmpty() ? DefaultImage : req.Image;
        var product = new Product()
        {
            Id = Guid.NewGuid().ToString(),
            Code = req.Code,
            Name = req.Name,
            Price = req.Price,
            Cost = req.Cost,
            Image = image!,
            Description = req.Description,
            CategoryId = req.CategoryId,
            CreatedAt = DateTime.Now,
            IsDeleted = false,
        };
        try
        {
            _unitOfWork.GetRepository<Product>().Add(product);
            _unitOfWork.Save();
            return Response<string>.Success("Product Create Successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Response<string>.Fail("Failed Create Product.");
        }
    }
    private string DefaultImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHNXEIpQNJp1iixgogbJk5quiWkQk3MoarYQ&usqp=CAU";

    public Response<List<ProductResponse>> ReadAll()
    {
        try
        {
            var products = _unitOfWork.GetRepository<Product>()
            .GetQueryable().Where(e => e.IsDeleted == false)
            .Include(e => e.Category)
            .Select(e => new ProductResponse()
            {
                Id = e.Id,
                Code = e.Code,
                Name = e.Name,
                Price = e.Price,
                Cost = e.Cost,
                Image = e.Image??DefaultImage,
                Qty = e.Qty,
                Description = e.Description!,
                CreatedAt = e.CreatedAt,
                CategoryId = e.CategoryId,
                CategoryName = e.Category.Name
            }).ToList();
            return Response<List<ProductResponse>>.Success(products,products.Count());
        }
        catch(ArgumentException ex)
        {
            return Response<List<ProductResponse>>.Fail();
        }
    }

    public Response<ProductResponse?> Read(Key key)
    {
        try
        {
            var product = _unitOfWork.GetRepository<Product>().GetQueryable()
                // .Where(e=>e.Id==key.Id || e.Code==key.Code)
                .Where(e => e.Id == key.Id)
                .Where(e=>e.IsDeleted==false)
                .Include(e =>e.Category)
                .Select(e=> new ProductResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Code = e.Code,
                    Price = e.Price,
                    Cost = e.Cost,
                    Qty = e.Qty,
                    Image = e.Image ?? default!,
                    CategoryId = e.CategoryId,
                    CategoryName = e.Category.Name
                }).First();
            
            return Response<ProductResponse>.Success(product)!;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return null!;
        }
    }

    public Response<string> Update(ProductUpdateReq req)
    {
        if (req.Id==null)
        {
            return Response<string>.Fail("Field Id is required.");
        }
        var productFound = _unitOfWork.GetRepository<Product>().GetQueryable().Where(e=>e.IsDeleted==false)
                            .FirstOrDefault(e => e.Id == req.Id || e.Code==req.Code );
        if (productFound == null)
        {
            return Response<string>.NotFound("Product does not existing.");
        }
        if (req.Price < req.Cost)
        {
            return Response<string>.Fail("Price must be more than Cost.");
        }
        if (req.Price!=null && productFound.Price != req.Price)
        {
            if (req.Price < productFound.Cost) { return Response<string>.Fail($"Price must be more than Cost is {productFound.Cost}"); }

            var priceHistory = new PriceHistoryCreateReq()
            {
                ProductId = productFound.Id,
                OldPrice = productFound.Price,
                CurrentPrice = (decimal)req.Price!
            };
            PriceHistoryService.Create(_unitOfWork, priceHistory);
        }
        productFound!.Name = (req.Name.IsNullOrEmpty()) ? productFound.Name : req.Name!;
        productFound.Price = (decimal)(req.Price ?? productFound.Price);
        productFound.Cost = (decimal)(req.Cost ?? productFound.Cost);
        productFound.Image = req.Image! ?? productFound.Image;
        productFound.Description = req.Description ?? productFound.Description;

        try
        {
            _unitOfWork.GetRepository<Product>().Update(productFound);
            _unitOfWork.Save();
            return Response<string>.Success("Updated Successfully");
        }
        catch (Exception e)
        {
            _unitOfWork.RollBackTransaction();
            return Response<string>.Fail("Failed to update product.");
        }
    }

    public Response<string> Delete(string key)
    {
        if (key == null)
        {
            return Response<string>.Fail("Product id is required.");
        }
        var product = _unitOfWork.GetRepository<Product>().GetQueryable().FirstOrDefault(e => e.Id==key);
        if (product == null) return Response<string>.NotFound("Product does not existing.");
        try
        {
            product.IsDeleted = true;
            _unitOfWork.GetRepository<Product>().Update(product);
            _unitOfWork.Save();
            return Response<string>.Success("Deleted Successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Response<string>.Fail("Failed to delete product.");
        }
    }
 
    public Response<string> ReActiveProduct(Key key)
    {
        if (key == null)
        {
            return Response<string>.Fail("Product id is required.");
        }
        var product = _unitOfWork.GetRepository<Product>().GetQueryable().FirstOrDefault(e => e.Id == key.Id);
        if (product == null) return Response<string>.NotFound("Product does not existing.");
        try
        {
            product.IsDeleted = false;
            _unitOfWork.GetRepository<Product>().Update(product);
            _unitOfWork.Save();
            return Response<string>.Success("Product is active Successfully");
        }
        catch (Exception e)
        {
            return Response<string>.Fail("Failed to reactive product.");
        }
    }
}



