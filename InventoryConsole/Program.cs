using InventoryConsole;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
                .AddSingleton<Startup>()  
                .BuildServiceProvider();

var startup = serviceProvider.GetService<Startup>();

var serviceCollection = new ServiceCollection();
startup!.ConfigureServices(serviceCollection);

serviceProvider = serviceCollection.BuildServiceProvider();

var helper = serviceProvider.GetService<Helper>();

if (helper != null)
{
    helper.Run();
}
else
{
    Console.WriteLine("Helper not found.");
}
