using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace InventoryLib.DataConfiguration
{
    internal class DbContextFactory : IDesignTimeDbContextFactory<InventoryContext>
    {
        //private readonly string ConnectionString = "Server=172.26.16.90;Database=Test;port=3306;user=POS01;password=ttDev@2023;Persist Security Info=False;Connect Timeout=120;";
        //private readonly string ConnectionString = "Data Source=SQL8003.site4now.net;Initial Catalog=db_aa25a0_inventory;User Id=db_aa25a0_inventory_admin;Password=Mypassword@123";

        public InventoryContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<InventoryContext> dbContextOptionsBuilder = new();
            // Sql Server
            //dbContextOptionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Inventory;user=sa;password=Mypassword;trustservercertificate=true;");
            dbContextOptionsBuilder.UseSqlServer("Data Source=SQL5106.site4now.net;Initial Catalog=db_aa2617_sonita;User Id=db_aa2617_sonita_admin;Pwd=Sonita@atec07");
            return new InventoryContext(dbContextOptionsBuilder.Options);
        }
    }
}