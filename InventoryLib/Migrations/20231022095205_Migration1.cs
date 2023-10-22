using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryLib.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Code = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CategoryId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Code",
                table: "Products",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
