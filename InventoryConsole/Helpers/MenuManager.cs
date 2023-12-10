using InventoryConsole.Menues;
using System;

namespace InventoryConsole
{
    public class MenuManager
    {
        private readonly Helper _helper;
        public MenuManager(Helper helper)
        {
            _helper = helper;
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine($"\nHello {_helper.GetLoggedInUser().UserName}! \n======> Here are your available options <======");

            var menuList = new MenuList
            {
                Title = "Main",
                Menues = GetMenusForRole("Admin")
            };

            while (true)
            {
                Console.WriteLine();
                menuList.Show();
                var activeMenu = menuList.GetMenu(new string(' ', 2));
                Console.WriteLine();
                activeMenu.Action();
            }
        }

        private List<Menu> GetMenusForRole(string role)
        {
            switch (role)
            {
                case "Admin":
                    return GetAdminMenus();
                case "Sellman":
                    return GetSellmanMenus();
                default:
                    Console.WriteLine("Invalid role.");
                    return new List<Menu>();
            }
        }

        private List<Menu> GetAdminMenus()
        {
            return new List<Menu>
            {
                new Menu() { Title = "Menu Product", Action = () => _helper.PerformCrudOperations(EndPoint.product) },
                new Menu() { Title = "Menu Category", Action = () => _helper.PerformCrudOperations(EndPoint.category) },
                new Menu() { Title = "Menu Stocking", Action = () => _helper.PerformCrudOperations(EndPoint.stocking) },
                new Menu() { Title = "Menu Order Summary", Action = () => _helper.PerformCrudOperations(EndPoint.order) },
                new Menu() { Title = "Menu Product Price Update Summary", Action = () => _helper.PerformCrudOperations(EndPoint.pricehistory) },

                new Menu() { Title = "Log Out", Action = _helper.Logout }
            };
        }

        private List<Menu> GetSellmanMenus()
        {
            return new List<Menu>
            {
                new Menu() { Title = "Menu Product", Action = () => _helper.PerformReadOperation(EndPoint.product) },
                new Menu() { Title = "Menu Category", Action = () => _helper.PerformReadOperation(EndPoint.category) },
                new Menu() { Title = "Menu Stocking", Action = () => _helper.PerformReadOperation(EndPoint.stocking) },
                new Menu() { Title = "Menu Order Summary", Action = () => _helper.PerformCrudOperations(EndPoint.order) },
                new Menu() { Title = "Menu Product Price Update Summary", Action = () => _helper.PerformCrudOperations(EndPoint.pricehistory) },

                new Menu() { Title = "Log Out", Action = _helper.Exit }
            };
        }
    }
}
