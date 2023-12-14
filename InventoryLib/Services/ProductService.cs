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
            Qty = 0,
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
    private string DefaultImage = "https://cdn.spinn.com/assets/img/empty.jpeg";
    public Response<List<ProductResponse>> ReadAll()
    {
        try
        {
            var products = GetAll().Result!.Where(e => e.IsDeleted == false).ToList();

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
            var product = GetAll().Result!.FirstOrDefault(e => e.Id == key.Id && e.IsDeleted == false);

            return Response<ProductResponse>.Success(product)!;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return null!;
        }
    }

    private Response<List<ProductResponse>> GetAll()
    {
        try
        {
            var product = _unitOfWork.GetRepository<Product>().GetQueryable()
                .Include(e => e.Category)
                .Select(e => new ProductResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Code = e.Code,
                    Price = e.Price,
                    Cost = e.Cost,
                    Qty = e.Qty.ToString().IsNullOrEmpty() ? 0 : e.Qty,
                    Image = e.Image ?? default!,
                    CategoryId = e.CategoryId,
                    CategoryName = e.Category.Name,
                    IsDeleted = e.IsDeleted
                }).ToList();

            return Response<List<ProductResponse>>.Success(product)!;
        }
        catch (Exception ex)
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
    
    public Response<string> ReActive(Key key)
    {
        if (key.Id == null)
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
    public Response<List<ProductResponse>> ReadAllDeleted()
    {
        try
        {
            /*var products = _unitOfWork.GetRepository<Product>()
            .GetQueryable().Where(e => e.IsDeleted == true)
            .Include(e => e.Category)
            .Select(e => new ProductResponse()
            {
                Id = e.Id,
                Code = e.Code,
                Name = e.Name,
                Price = e.Price,
                Cost = e.Cost,
                Image = e.Image ?? DefaultImage,
                Qty = e.Qty.ToString().IsNullOrEmpty()?0:e.Qty,
                Description = e.Description!,
                CreatedAt = e.CreatedAt,
                CategoryId = e.CategoryId,
                CategoryName = e.Category.Name,
                IsDeleted = e.IsDeleted
            }).ToList();*/

            var products = GetAll().Result.Where(e=>e.IsDeleted==true).ToList();    
            return Response<List<ProductResponse>>.Success(products, products.Count());
        }
        catch (ArgumentException ex)
        {
            return Response<List<ProductResponse>>.Fail();
        }
    }
}



