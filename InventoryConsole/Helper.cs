using InventoryApiClient.Model.User;
using InventoryApiClient.Services;
using InventoryConsole.Helpers;
using InventoryConsole.Menues;

namespace InventoryConsole
{
    public class Helper
    {
        private readonly UserManager _userManager;
        private readonly MenuManager _menuManager;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;

        private readonly MenuList crudMenu = new MenuList();

        public Helper(UserService userService, ProductService productService, CategoryService categoryService, StockingService stockingService, OrderService orderService)
        {
            _userManager = new UserManager(userService);
            _menuManager = new MenuManager(this);
            _productService = productService;
            _categoryService = categoryService;
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
                new Menu() { Title = "View Product in Stock", Action = () => PerformReadOperation(EndPoint.stocking) },
                new Menu() { Title = "Create Stock", Action = () => PerformCreateOperation(EndPoint.stocking) },
                new Menu() { Title = "Update Stock", Action = () => PerformUpdateOperation(EndPoint.stocking) },
                new Menu() { Title = "Delete Stock", Action = () => PerformDeleteOperation(EndPoint.stocking) },
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
                    break;
                case EndPoint.order:
                    Console.WriteLine("Viewing Order Summary");
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
                    break;
                case EndPoint.category:
                    Console.WriteLine("Creating a Category");
                    break;
                case EndPoint.stocking:
                    Console.WriteLine("Updating Stocking Information");
                    break;
                case EndPoint.order:
                    Console.WriteLine("Creating an Order");
                    break;
                default:
                    Console.WriteLine("Invalid entity.");
                    break;
            }
        }
        private void PerformUpdateOperation(EndPoint entity)
        {
            switch (entity)
            {
                case EndPoint.product:
                    Console.WriteLine("Updating a Product");
                    break;
                case EndPoint.category:
                    Console.WriteLine("Updating a Category");
                    break;
                case EndPoint.stocking:
                    Console.WriteLine("Updating Stocking Information");
                    break;
                case EndPoint.order:
                    Console.WriteLine("Updating an Order");
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
                    Console.WriteLine("Deleting a Product");
                    break;
                case EndPoint.category:
                    Console.WriteLine("Deleting a Category");
                    break;
                case EndPoint.stocking:
                    Console.WriteLine("Deleting Stocking Information");
                    break;
                case EndPoint.order:
                    Console.WriteLine("Deleting an Order");
                    break;
                default:
                    Console.WriteLine("Invalid entity.");
                    break;
            }
        }

        // Read Data 
        public void DisplayProducts()
        {
            var products = _productService.ReadAllAsync().Result;
            Console.WriteLine("\n====== Product List ======");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("===========================\n");
        }
        public void DisplayCategories()
        {
            var products = _categoryService.ReadAllAsync().Result;
            Console.WriteLine("\n====== Product List ======");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Description}");
            }
            Console.WriteLine("===========================\n");
        }
    }
}
