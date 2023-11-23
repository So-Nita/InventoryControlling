using InventoryLib.DataConfiguration;
using InventoryLib.Interface;
using InventoryLib.Models;
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

builder.Services.AddDbContext<InventoryContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
},ServiceLifetime.Transient);

builder.Services.AddScoped<InventoryLib.Interface.IProductService,InventoryLib.Services.ProductService>();
builder.Services.AddScoped<InventoryLib.Interface.IRepository<Product>,InventoryLib.Repository.Repository<Product>>();
builder.Services.AddScoped<InventoryLib.Interface.IUnitOfWork,InventoryLib.UnitOfWork.UnitOfWork>();

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