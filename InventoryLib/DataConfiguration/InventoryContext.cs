using System.Reflection;
using InventoryLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace InventoryLib.DataConfiguration;

public class InventoryContext : DbContext
{
    public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
    {
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
