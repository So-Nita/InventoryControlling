using InventoryApiClient.Model.Category;
using InventoryApiClient.Model.Order;
using InventoryApiClient.Model.Product;
using InventoryApiClient.Model.Stocking;
using InventoryApiClient.Model.User;
using InventoryApiClient.Services;
using InventoryConsole.Helpers;
using InventoryConsole.Menues;
using System;

namespace InventoryConsole
{
    public class Helper
    {
        private readonly UserManager _userManager;
        private readonly MenuManager _menuManager;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly OrderService _orderService;

        private readonly MenuList crudMenu = new MenuList();

        public Helper(UserService userService, ProductService productService, CategoryService categoryService, StockingService stockingService, OrderService orderService)
        {
            _userManager = new UserManager(userService);
            _menuManager = new MenuManager(this);
            _productService = productService;
            _categoryService = categoryService;
            _orderService = orderService;
            //_userManager.Login();  
        }

        public void Run()
        {
            _menuManager.DisplayMainMenu();
        }

        public UserResponse GetLoggedInUser()
        {
            return _userManager.GetLoggedInUser();
        }

        public void Logout()
        {
            _userManager.Logout();
        }
        public void Exit()
        {
            Environment.Exit(0);
        }

        public void PerformCrudOperations(EndPoint entity)
        {
            Console.WriteLine($"=> {entity} CRUD operations: <=");

            SetCrudMenuOptions(entity);

            while (true)
            {
                Console.WriteLine();
                crudMenu.Show();
                var activeMenu = crudMenu.GetMenu(new string(' ', 2));
                Console.WriteLine();
                activeMenu.Action();
            }
        }
        private void SetCrudMenuOptions(EndPoint entity)
        {
            switch (entity)
            {
                case EndPoint.product:
                    crudMenu.Menues = GetProductCrudMenu();
                    break;
                case EndPoint.category:
                    crudMenu.Menues = GetCategoruCrudMeu();
                    break;
                case EndPoint.stocking:
                    crudMenu.Menues = GetStockCrudMenu();
                    break;
                case EndPoint.order:
                    crudMenu.Menues = GetOrderCrudMenu();
                    break;
                case EndPoint.pricehistory:
                    crudMenu.Menues = GetPriceCrudMenu();
                    break;
            }
            crudMenu.Menues.Last().Action = _menuManager.DisplayMainMenu;
        }
        private List<Menu> GetProductCrudMenu()
        {
            return new List<Menu>
            {
                new Menu() { Title = "View Product", Action = () => PerformReadOperation(EndPoint.product) },
                new Menu() { Title = "Create Product", Action = () => PerformCreateOperation(EndPoint.product) },
                new Menu() { Title = "Update Product", Action = () => PerformUpdateOperation(EndPoint.product) },
                new Menu() { Title = "Delete Product", Action = () => PerformDeleteOperation(EndPoint.product) },
                new Menu() { Title = "Back to Main Menu", Action = () => { } }
            };
        }

        private List<Menu> GetCategoruCrudMeu()
        {
            return new List<Menu>
            {
                new Menu() { Title = "View Category", Action = () => PerformReadOperation(EndPoint.category) },
                new Menu() { Title = "Create Category", Action = () => PerformCreateOperation(EndPoint.order) },
                new Menu() { Title = "Update Category", Action = () => PerformUpdateOperation(EndPoint.category) },
                new Menu() { Title = "Delete Category", Action = () => PerformDeleteOperation(EndPoint.category) },
                new Menu() { Title = "Back to Main Menu", Action = _menuManager.DisplayMainMenu }
            };
        }
        private List<Menu> GetOrderCrudMenu()
        {
            return new List<Menu>
            {
                new Menu() { Title = "View Order", Action = () => PerformReadOperation(EndPoint.order) },
                new Menu() { Title = "Create Order", Action = () => PerformCreateOperation(EndPoint.order) },
                new Menu() { Title = "Update Order", Action = () => PerformUpdateOperation(EndPoint.order) },
                new Menu() { Title = "Delete Order", Action = () => PerformDeleteOperation(EndPoint.order) },
                new Menu() { Title = "Back to Main Menu", Action = _menuManager.DisplayMainMenu }
            };
        }
        private List<Menu> GetStockCrudMenu()
        {
            return new List<Menu>
            {
                new Menu() { Title = "View Stock Transation", Action = () => PerformReadOperation(EndPoint.stocking) },
                new Menu() { Title = "Create Stock", Action = () => PerformCreateOperation(EndPoint.stocking) },
                new Menu() { Title = "Update Stock", Action = () => PerformUpdateOperation(EndPoint.stocking) },
                new Menu() { Title = "Delete Stock", Action = () => PerformDeleteOperation(EndPoint.stocking) },
                new Menu() { Title = "Back to Main Menu", Action = _menuManager.DisplayMainMenu }
            };
        }
        private List<Menu> GetPriceCrudMenu()
        {
            return new List<Menu>
            {
                new Menu() { Title = "View Product Price", Action = () => PerformReadOperation(EndPoint.pricehistory) },
                new Menu() { Title = "Back to Main Menu", Action = _menuManager.DisplayMainMenu }
            };
        }
        public void PerformReadOperation(EndPoint entity)
        {
            switch (entity)
            {
                case EndPoint.product:
                    Console.WriteLine("Viewing Products");
                    DisplayProducts();
                    break;
                case EndPoint.category:
                    Console.WriteLine("Viewing Categories");
                    DisplayCategories();
                    break;
                case EndPoint.stocking:
                    Console.WriteLine("Viewing Stocking Information");
                    DisplayStockings();
                    break;
                case EndPoint.order:
                    Console.WriteLine("Viewing Order Summary");
                    DisplaySaleOrders();
                    break;
                case EndPoint.pricehistory:
                    DisplayProductPriceHistoryAsync();
                    Console.WriteLine("Viewing Product's price history");
                    break;
                default:
                    Console.WriteLine("Invalid entity.");
                    break;
            }
        }

        private void PerformCreateOperation(EndPoint entity)
        {
            switch (entity)
            {
                case EndPoint.product:
                    Console.WriteLine("Creating a Product");
                    DisplayCreateProducts();
                    break;
                case EndPoint.category:
                    Console.WriteLine("Creating a Category");
                    DisplayCreateCategory();
                    break;
                case EndPoint.stocking:
                    Console.WriteLine("Updating Stocking Information");
                    DisplayCreateStock();
                    break;
                case EndPoint.order:
                    Console.WriteLine("Creating an Order");
                    DisplayCreateOrder();
                    break;
                default:
                    Console.WriteLine("Invalid entity.");
                    break;
            }
        }
        //Update
        private void PerformUpdateOperation(EndPoint entity)
        {
            switch (entity)
            {
                case EndPoint.product:
                    DisplayUpdateProduct();
                    break;
                case EndPoint.category:
                    DisplayUpdateCategory();
                    break;
                case EndPoint.stocking:
                    DisplayUpdateStocking();
                    break;
               /* case EndPoint.order:
                    DisplayUpdateOrder();*/
                    break;
                default:
                    Console.WriteLine("Invalid entity.");
                    break;
            }
        }

        private void PerformDeleteOperation(EndPoint entity)
        {
            switch (entity)
            {
                case EndPoint.product:
                    DisplayDeleteProduct();
                    break;
                case EndPoint.category:
                    DisplayDeleteCategory();
                    break;
                case EndPoint.stocking:
                    DisplayDeleteStocking();
                    break;
                case EndPoint.order:
                    DisplayDeleteOrder();
                    break;
                default:
                    Console.WriteLine("Invalid entity.");
                    break;
            }
        }
        //Delete 
        private async void DisplayDeleteProduct()
        {
            Console.Write("Enter product ID to delete: "); var productId = Console.ReadLine();
            var result = await _productService.DeleteAsync(productId);
            Console.WriteLine(result == true ? "Delete Successfully" : "Faled to delete.");
        }
        private async void DisplayDeleteCategory()
        {
            Console.Write("Enter category ID to delete: "); var categoryId = Console.ReadLine();
            var result = await _categoryService.DeleteAsync(categoryId);
            Console.WriteLine(result == true ? "Delete Successfully" : "Faled to delete.");
        }
        private async void DisplayDeleteStocking()
        {
            Console.Write("Enter stocking ID to delete: "); var stockId = Console.ReadLine();
            var stock = new StockingService();
            var result = await stock.DeleteAsync(stockId);
            Console.WriteLine(result == true ? "Delete Successfully" : "Faled to delete.");
        }
        private async void DisplayDeleteOrder()
        {
            Console.Write("Enter order ID to delete: "); var orderId = Console.ReadLine();
            var result = await _orderService.DeleteAsync(orderId);
            Console.WriteLine(result == true ? "Delete Successfully" : "Faled to delete.");
        }

        // Update 
        private async void DisplayUpdateProduct()
        {
            var product = new ProductUpdateReq();
            Console.Write("Enter product ID to update: "); product.Id = Console.ReadLine();
            Console.Write("Enter new product code: ");  product.Code = Console.ReadLine();
            Console.Write("Enter new product name: ");
            product.Name = Console.ReadLine();

            Console.Write("Enter new product cost: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal cost))
            {
                product.Cost = cost;
            }
            else
            {
                Console.WriteLine("Invalid input for cost. Exiting...");
                return;
            }

            Console.Write("Enter new product price: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                product.Price = price;
            }
            else
            {
                Console.WriteLine("Invalid input for price. Exiting...");
                return;
            }
            Console.Write("Enter new category ID: "); product.CategoryId = Console.ReadLine();
            Console.Write("Enter new product image URL (optional): "); product.Image = Console.ReadLine();
            Console.Write("Enter new product description (optional): "); product.Description = Console.ReadLine();
            var result = await _productService.UpdateAsync(product);
            Console.WriteLine(result.Status == 200 ? "Update Successfully" : "Faled to Update.");
        }
        private async void DisplayUpdateCategory()
        {
            var category = new CategoryUpdateReq();

            Console.Write("Enter category ID to update: "); category.Id = Console.ReadLine();
            Console.Write("Enter new category name: "); category.Name = Console.ReadLine();
            Console.Write("Enter new category image URL (optional): "); category.Image = Console.ReadLine();
            Console.Write("Enter new category description (optional): "); category.Description = Console.ReadLine();
            var result = await _categoryService.UpdateAsync(category);

            Console.WriteLine(result ? "Update Successfully" : "Failed to Update.");
        }
        private async void DisplayUpdateStocking()
        {
            var stock = new StockUpdateReq();
            Console.Write("Enter stock ID to update: "); stock.Id = Console.ReadLine();
            Console.Write("Enter new stock quantity (optional): ");
            if (int.TryParse(Console.ReadLine(), out int qty))
            {
                stock.Qty = qty;
            }
            Console.Write("Enter new stock status (optional): ");   stock.Status = Console.ReadLine();
            Console.Write("Enter new stock note (optional): ");  stock.Note = Console.ReadLine();
            var _stock = new StockingService();
            var result = await _stock.UpdateAsync(stock);

            Console.WriteLine(result.Status == 200 ? "Update Successfully" : "Failed to Update.");
        }


        // Create Date 
        private async void DisplayCreateProducts()
        {
            Console.Write("Enter product code: "); var code = Console.ReadLine() ;
            Console.Write("Enter product name: "); var name = Console.ReadLine() ;
            Console.Write("Enter product cost: ");
            decimal cost=0;
            decimal price = 0;
            if (decimal.TryParse(Console.ReadLine(), out decimal _cost)) { cost = _cost; }
            else
            {
                Console.WriteLine("Invalid input for cost. Exiting...");
                return;
            }
            Console.Write("Enter product price: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal _price))
            {
                price = _price;
            }
            else
            {
                Console.WriteLine("Invalid input for price. Exiting...");
                return;
            }
            Console.Write("Enter category ID: "); var categoryId = Console.ReadLine().Trim();
            Console.Write("Enter product image URL (optional): "); var image = Console.ReadLine().Trim();
            if (image == "")
            {
                image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBVm97ffff3JtR09e4xkkjys5SXrlPv3coTQ&usqp=CAU";
            }
            Console.Write("Enter product description (optional): ");  var description = Console.ReadLine();
            var newProduct = new ProductCreateReq()
            {
                Code = code.Trim(),
                Name = name.Trim(),
                Cost = cost,
                Price = price,
                CategoryId = categoryId.Trim(),
                Image = image,
                Description = description.Trim(),
            };

            var result = await _productService.CreateAsync(newProduct);
            if (result.Equals(200))
            {
                Console.WriteLine("\nCreate Product Successfully.");
            }
        }

        private async void DisplayCreateCategory()
        {
            var newCategory = new CategoryCreateReq();
            Console.Write("Enter category name: "); newCategory.Name = Console.ReadLine();

            Console.Write("Enter category image URL (optional): "); newCategory.Image = Console.ReadLine();

            Console.Write("Enter category description (optional): "); newCategory.Description = Console.ReadLine();

            var result = await _categoryService.CreateAsync(newCategory);
            if (result ==true)
            {
                Console.WriteLine("\nCreate Category Successfully.");
            }
            else
            {
                Console.WriteLine($"\nSomething Went wrong. Error: {result}");
            }
        }

        private async void DisplayCreateStock()
        {
            var stock = new StockCreateReq();

            Console.Write("Enter Stock ID: "); stock.Id = Console.ReadLine();

            Console.Write("Enter Status: "); stock.Status = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            if (int.TryParse(Console.ReadLine(), out int qty))
            {
                stock.Qty = qty;
            }
            else
            {
                Console.WriteLine("Invalid quantity. Please enter a valid numeric value.");
                return;
            }
            Console.Write("Enter Note (optional): ");
            stock.Note = Console.ReadLine();
            var stocking = new StockingService();
            var result = await stocking.CreateAsync(stock);

            if (result.Status == 200)
            {
                Console.WriteLine("\nCreate Stock Successfully.");
            }
            else
            {
                Console.WriteLine($"\nSomething went wrong. Error: {result}");
            }
        }

        private async void DisplayCreateOrder()
        {
            var order = new OrderCreateReq();
            var _order = new OrderService();

            while (true)
            {
                var orderDetail = new OrderDetail();

                Console.Write("Enter Product ID (or 0 to submit order): "); string productIdInput = Console.ReadLine();

                if (productIdInput == "0") { break; }
 
                orderDetail.ProductId = productIdInput;  Console.Write("Enter Quantity: ");
                if (int.TryParse(Console.ReadLine(), out int qty))
                {
                    orderDetail.Qty = qty;
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please enter a valid numeric value.");
                    return;
                }

                order.OrderDetails.Add(orderDetail);
            }
            var result = await _order.Create(order);

            if (result == true)
            {
                Console.WriteLine("\nCreate Order Successfully.");
            }
            else
            {
                Console.WriteLine($"\nSomething went wrong. Error: {result}");
            }
        }



        // Read Data 
        public void DisplayProducts()
        {
            var products = _productService.ReadAllAsync().Result;
            Console.WriteLine("\n================================================================================================ Product List =================================================================================================");
            Console.WriteLine("\n{0,-38} {1,-15} {2,-38} {3,-38} {4,-15} {5,-10} {6,-10} {7,-22} {8,-15}",
                              " ID", "Code", "Name", "CategoryId", "CategoryName", "Cost", "Price", "CreatedAt", "Description");
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            if(products != null)
            {
                foreach (var product in products)
                {
                    Console.WriteLine($" {product.Id,-38} {product.Code,-15} {product.Name,-38} {product.CategoryId,-38} {product.CategoryName,-15} " +
                                      $" {product.Cost,-10:C} {product.Price,-10:C} {product.CreatedAt?.ToString("MM/dd/yyyy HH:mm:ss"),-22} {product.Description,-15}");
                }
            }
            Console.WriteLine("\n===============================================================================================================================================================================================================\n");
        }

        public void DisplayCategories()
        {
            var categories = _categoryService.ReadAllAsync().Result;
            Console.WriteLine("\n=================================== Category List ====================================");
            Console.WriteLine("\n{0,-38} {1,-15} {2,-20}",
                              "ID", "Name", "Description");
            Console.WriteLine("\n--------------------------------------------------------------------------------------\n");
            if (categories.Any())
            {
                foreach (var item in categories)
                {
                    Console.WriteLine($" {item.Id,-38} {item.Name,-15} {item.Description,-20}");
                }

            }
            Console.WriteLine("\n======================================================================================\n");
        }

        private async Task DisplayProductPriceHistoryAsync()
        {
            var prices = new PriceHistoryService();
            var data = await prices.ReadAllAsync();
            Console.WriteLine("\n=================================================================== Price History List ======================================================================");
            Console.WriteLine("\n{0,-38} {1,-38} {2,-20} {3,-20} {4,-22}",
                              "ID", "ProductId", "OldPrice", "CurrentPrice", "UpdateDate");
            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------------------------------------------------\n");

            if (data != null)
            {
                foreach (var item in data)
                {
                    Console.WriteLine($" {item.Id,-38} {item.ProductId,-38} {item.OldPrice,-20:C} {item.CurrentPrice,-20:C} {item.UpdateDate,-22:MM/dd/yyyy HH:mm:ss}");
                }
            }
            Console.WriteLine("\n=============================================================================================================================================================\n");
        }
        private async void DisplaySaleOrders()
        {
            var _order = new OrderService();
            var orders = await _order.ReadAllAsync();
            Console.WriteLine("\n=============================================Order List===================================================");
            Console.WriteLine("\nOrderID, \t\t\t\tTotalPrice \t\tOrderDate");
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------\n");

            if (orders!=null)
            {
                foreach (var order in orders)
                {
                    Console.WriteLine($" {order.Id,-38} {order.TotalPrice,-15} {order.OrderDate,-20}");
                }
            }

            Console.WriteLine("\n==========================================================================================================\n");
        }




        private async void DisplayStockings()
        {
            var prices = new PriceHistoryService();
            var data = await prices.ReadAllAsync();
            Console.WriteLine("\n=================================================================== Price History List ======================================================================");
            Console.WriteLine("\n{0,-38} {1,-38} {2,-20} {3,-20} {4,-22}",
                              "ID", "ProductId", "OldPrice", "CurrentPrice", "UpdateDate");
            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------------------------------------------------\n");

            if (data != null)
            {
                foreach (var item in data)
                {
                    Console.WriteLine($" {item.Id,-38} {item.ProductId,-38} {item.OldPrice,-20:C} {item.CurrentPrice,-20:C} {item.UpdateDate,-22:MM/dd/yyyy HH:mm:ss}");
                }
            }
            Console.WriteLine("\n=============================================================================================================================================================\n");
        }

    }
}
