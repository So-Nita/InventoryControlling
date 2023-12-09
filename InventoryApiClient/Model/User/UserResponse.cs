using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.User;

public class UserResponse
{
    public string Id { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Image { get; set; } = "";
    public string Role { get; set; } = "";
    public string Contact { get; set; } = "";
    public string Password { get; set; } = null!;
}
