using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryLib.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Init Data Category 
            migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "Id", "Name", "Image", "Description", "CreatedAt", "IsDeleted" },
            values: new object[,]
            {
                { "d350f0c2-33a4-4f63-bf61-7582b88bb9d1", "Sneaker", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNDOsp3KV0Q98keEmRNJ-DKkYpJ64LgK8bng&usqp=CAU", null, DateTime.Now, false },
                { "fae1c6b8-2547-4651-bf1c-789f8d437e01" , "BEER", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBVm97ffff3JtR09e4xkkjys5SXrlPv3coTQ&usqp=CAU", null, DateTime.Now, false },
                { "8a83a4a0-5f18-4ed0-8b4a-4f56b23f7a53", "Coffee", "https://images.squarespace-cdn.com/content/v1/541e22dde4b0fcd826d4d5a1/1526672830446-8MWSDEWIS8GDRNC2Y3RE/HolyKombucha_Hero_3_WEB.jpg", null, DateTime.Now, false },
                { "c0a76be4-8f1a-40f2-9d15-2c1a0745c16e" , "Drink", "https://www.coca-colastore.com/media/wysiwyg/COKE-684_new-bottle-blocks-feature_step-3_customized_pattern-trio_v2.png", null, DateTime.Now, false },
                { "63c9840b-e57d-4852-9c90-6a8f4e71f74f", "Shampoo", "https://static.spacecrafted.com/dbe4e3ceec5049d281a85658fae6e3e7/i/bd417b71101b4618b3288e5a715fd9f3/1/4SoifmQp45JMgBnHp7ed2/Loreal%20Pro%20Blondie%20Serie%20Expert%201.png", null, DateTime.Now, false },
            });

            // Seed Products
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Name", "Price", "Image", "Cost", "CategoryId", "Description", "CreatedAt", "IsDeleted" },
                values: new object[,]
                {
                { Guid.NewGuid().ToString(), "SMTH001", "Smoth Shampoo", 9.99m, "https://www.thebeautybasket.ie/cdn/shop/products/smoothshampoofront_800x800_crop_center@2x.jpg?v=1631621734", 5.99m, "63c9840b-e57d-4852-9c90-6a8f4e71f74f", null, DateTime.Now, false },
                { Guid.NewGuid().ToString(), "CC001", "Coca Cola", 1.99m, "https://www.luckystore.in/cdn/shop/products/CocaColaOriginal250ML_imported.png?v=1670837210", 0.99m, "c0a76be4-8f1a-40f2-9d15-2c1a0745c16e" , null, DateTime.Now, false },
                { Guid.NewGuid().ToString(), "NES001", "NesCafe Pack 190g", 7.49m, "https://m.media-amazon.com/images/I/81h3AcrJ6pL.jpg", 4.99m, "8a83a4a0-5f18-4ed0-8b4a-4f56b23f7a53", null, DateTime.Now, false },
                { Guid.NewGuid().ToString(), "NES002", "NesCafe Gold 7 sachets", 5.99m, "https://fengany.com/cdn/shop/products/NescafeGoldIcedSaltedCaramelLatte-7sachets.jpg?v=1627739262&width=1080", 3.99m, "8a83a4a0-5f18-4ed0-8b4a-4f56b23f7a53", null, DateTime.Now, false },
                { Guid.NewGuid().ToString(), "HAN001", "Hanuman Berr Bottle", 3.99m, "https://cdn.s-liquor.com.kh/wp-content/uploads/2022/07/Hanuman-Lager.jpg?strip=all&lossy=1&webp=90&avif=50&resize=300%2C300&ssl=1", 2.99m, "fae1c6b8-2547-4651-bf1c-789f8d437e01", null, DateTime.Now, false },
                { Guid.NewGuid().ToString(), "HAN002", "Hanuman Beer Black", 4.99m, "https://cdn.s-liquor.com.kh/wp-content/uploads/2022/02/Hanuman-Black-01.jpg", 3.49m, "fae1c6b8-2547-4651-bf1c-789f8d437e01", null, DateTime.Now, false },
                { Guid.NewGuid().ToString(), "GF001", "Schar Gluten Free Crackers 210g", 3.99m, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT885cxlgzOFHZzztvIO0uxPh368p29bgmzNw&usqp=CAU", 2.49m, "d350f0c2-33a4-4f63-bf61-7582b88bb9d1", null, DateTime.Now, false },
                { Guid.NewGuid().ToString(), "MC001", "Munchy's Crackers", 2.49m, "https://media.nedigital.sg/fairprice/fpol/media/images/product/XL/13035079_XL1_20210218.jpg?w=1200&q=70", 1.49m, "d350f0c2-33a4-4f63-bf61-7582b88bb9d1", null, DateTime.Now, false }
                });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
