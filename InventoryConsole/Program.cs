using InventoryLib.DataConfiguration;
using InventoryLib.Interface;
using InventoryLib.Services;
using InventoryLib.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryConsole;
static class Program
{
    static async Task Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddScoped<IUnitOfWork, UnitOfWork>()
            .AddScoped<IProductService, ProductService>()
            .AddDbContext<InventoryContext>(options => options.UseSqlServer("Server=localhost;Database=Inventory;User Id=sa;password=MyPassword;trustservercertificate=True;"))
            .BuildServiceProvider();

        var productService = serviceProvider.GetRequiredService<IProductService>();
        var productServiceHelper = new Helper.Helper(productService);

        try
        {
            productServiceHelper.GetAllProducts();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}