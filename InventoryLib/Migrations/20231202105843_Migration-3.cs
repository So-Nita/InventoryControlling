using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryLib.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Init Data Stockings
            migrationBuilder.InsertData(
                table: "Stockings",
                columns: new[] { "Id", "ProductId", "Status", "Qty", "TransactionDate" },
                values: new object[] { Guid.NewGuid().ToString(), "0aab3800-9ea5-4735-91aa-3144e2f3376c", 1, 10, DateTime.Now });

            migrationBuilder.InsertData(
                table: "Stockings",
                columns: new[] { "Id", "ProductId", "Status", "Qty", "TransactionDate" },
                values: new object[] { Guid.NewGuid().ToString(), "4919b227-4f17-422a-a49e-e73a5dbab07b", 1, 20, DateTime.Now });

            migrationBuilder.InsertData(
                table: "Stockings",
                columns: new[] { "Id", "ProductId", "Status", "Qty", "TransactionDate" },
                values: new object[] { Guid.NewGuid().ToString(), "53dc958f-0a33-4505-b497-f55a044e329a", 1, 34, DateTime.Now });

            migrationBuilder.InsertData(
                table: "Stockings",
                columns: new[] { "Id", "ProductId", "Status", "Qty", "TransactionDate" },
                values: new object[] { Guid.NewGuid().ToString(), "9deace6f-b69e-4a03-84f6-b05a719e377e", 1, 22, DateTime.Now });

            migrationBuilder.InsertData(
                table: "Stockings",
                columns: new[] { "Id", "ProductId", "Status", "Qty", "TransactionDate" },
                values: new object[] { Guid.NewGuid().ToString(), "be2bc34d-cf43-42b5-859c-0f0a3db5d391", 1, 50, DateTime.Now });

            // Update Product Qty based on Stocking data
            //migrationBuilder.Sql(
            //    "UPDATE Products SET Qty = Qty + 10 WHERE Id = '0aab3800-9ea5-4735-91aa-3144e2f3376c'");

            //migrationBuilder.Sql(
            //    "UPDATE Products SET Qty = Qty + 20 WHERE Id = '4919b227-4f17-422a-a49e-e73a5dbab07b'");

            //migrationBuilder.Sql(
            //    "UPDATE Products SET Qty = Qty + 34 WHERE Id = '53dc958f-0a33-4505-b497-f55a044e329a'");

            //migrationBuilder.Sql(
            //    "UPDATE Products SET Qty = Qty + 22 WHERE Id = '9deace6f-b69e-4a03-84f6-b05a719e377e'");

            //migrationBuilder.Sql(
            //    "UPDATE Products SET Qty = Qty + 50 WHERE Id = 'be2bc34d-cf43-42b5-859c-0f0a3db5d391'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
