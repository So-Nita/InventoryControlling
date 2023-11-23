using InventoryLib.Interface;

namespace InventoryConsole.Helper;

public class Helper
{
    private readonly IProductService _productService;
        
    public Helper(IProductService productService)
    {
            _productService = productService;
    }

    public async Task GetAllProducts()
    { 
        var products = await _productService.GetAllProducts(); 

        foreach (var product in products) 
        { 
            Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }
    }
    
}

