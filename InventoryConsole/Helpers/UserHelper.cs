using InventoryApiClient.Model.User;
using InventoryApiClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryConsole.Helpers
{
    public class UserManager
    {
        private readonly UserService _userService;
        private bool _loggedIn = false;
        private UserResponse User = new UserResponse();

        public UserManager(UserService userService)
        {
            _userService = userService;
        }

        public void Login()
        {
            Console.WriteLine("\n=============> Welcome <=============");
            do
            {
                Console.Write("Input user name: ");
                var username = Console.ReadLine();
                Console.Write("Input password: ");
                var password = Console.ReadLine();

                var users = _userService.ReadAllAsync();
                User = users.Result.FirstOrDefault(u => u.UserName == username && u.Password == password)!;

                if (User != null)
                {
                    Console.WriteLine("\nLogin successful!\n");
                    _loggedIn = true;
                }
                else
                {
                    Console.WriteLine("\nIncorrect username or password.\nTry Again.");
                }
            } while (!_loggedIn);
        }

        public void Logout()
        {
            _loggedIn = false;
        }

        public UserResponse GetLoggedInUser()
        {
            return User;
        }
    }
}
