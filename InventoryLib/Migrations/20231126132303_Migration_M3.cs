using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryLib.Migrations
{
    /// <inheritdoc />
    public partial class Migration_M3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
            // Init Data User
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName", "Role", "Image", "Contact", "Password" },
                values: new object[,]
                {
                    { "5e25cc94-424f-4b29-8729-cbc55c09e5a3", "Admin", 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTlvcJSJgrLlqVEQ1XNM3GzT0qGSyBX5jg1nd5Xn7_krVmMVL3gXR5u6TaU1q8xS4FNV6k&usqp=CAU", "015558811", "Admin@123" },
                    { "d675e5a1-c86c-46af-a926-e4e8e49f8690", "Sellman", 2, "https://www.shutterstock.com/image-vector/avatar-girls-icon-vector-woman-260nw-433429546.jpg", "098885558", "Sell@123" },
                });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
