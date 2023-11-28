using InventoryLib.Interface;
using InventoryLib.Models.Response.Product;

namespace InventoryConsole.Helper;

public class Helper
{
    private readonly IProductService _productService;
        
    public Helper(IProductService productService)
    {
            _productService = productService;
    }

    public void GetAllProducts()
    { 
        var products = _productService.ReadAll().Result; 

        foreach (var product in products) 
        { 
            Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }
        
    }
    
}

