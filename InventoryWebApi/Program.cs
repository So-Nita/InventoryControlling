using InventoryLib.DataConfiguration;
using InventoryLib.Interface;
using InventoryLib.Interface.IService;
using InventoryLib.Models;
using InventoryLib.Models.Response;
using InventoryLib.Models.Response.User;
using InventoryLib.Repository;
using InventoryLib.Services;
using InventoryLib.UnitOfWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// SQL Server 
/*builder.Services.AddDbContext<InventoryContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
},ServiceLifetime.Transient);*/

var connectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<InventoryContext>(opt =>
{
    opt.UseMySql(connectionStrings, ServerVersion.AutoDetect(connectionStrings));
}, ServiceLifetime.Transient);

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IUserService<UserResponse>, UserService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPriceHistoryService<PriceHistoryResponse>, PriceHistoryService>();
builder.Services.AddScoped<IStockingService, StockingService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();