
using InventoryLib.Interface;
using InventoryLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryWebApi.Controller;

[ApiController][Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }
    [HttpGet]
    public IActionResult Index()
    {
        var products = _service.GetAllProducts();
        return Ok(products);
    }
}