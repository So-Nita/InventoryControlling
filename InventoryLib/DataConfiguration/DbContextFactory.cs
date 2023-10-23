using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace InventoryLib.DataConfiguration
{
    internal class DbContextFactory : IDesignTimeDbContextFactory<InventoryContext>
    {
        public InventoryContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<InventoryContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Inventory;User Id=sa;Password=Mypassword;encrypt=true;trustservercertificate=true;");
            return new InventoryContext(dbContextOptionsBuilder.Options);
        }
    }
}