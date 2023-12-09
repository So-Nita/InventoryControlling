using InventoryApiClient.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryConsole;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<Helper>();
        services.AddScoped<UserService>();
        services.AddScoped<ProductService>();
        services.AddScoped<StockingService>();
        services.AddScoped<OrderService>();
        services.AddScoped<CategoryService>();

    }

}
