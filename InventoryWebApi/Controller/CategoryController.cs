using Microsoft.AspNetCore.Mvc;

namespace InventoryWebApi.Controller;

[ApiController][Route("api/category")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }
}