using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace InventoryLib.DataConfiguration
{
    internal class DbContextFactory : IDesignTimeDbContextFactory<InventoryContext>
    {
        //private readonly string ConnectionString = "Server=172.26.16.90;Database=Test;port=3306;user=POS01;password=ttDev@2023;Persist Security Info=False;Connect Timeout=120;";
        //private readonly string ConnectionString = "Server=localhost;Database=Inventory;port=3306;user=root;password=Mypassword;Persist Security Info=False;Connect Timeout=120;";

        public InventoryContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<InventoryContext> dbContextOptionsBuilder = new();
            // Sql Server
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Inventory;user=sa;password=Mypassword;trustservercertificate=true;");
            //Mysql 
            //dbContextOptionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
            return new InventoryContext(dbContextOptionsBuilder.Options);
        }
    }
}