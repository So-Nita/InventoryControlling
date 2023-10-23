
using InventoryLib.Interface;
using InventoryLib.Models;
using InventoryLib.Models.Request.Product;
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
    public IActionResult GetAllProducts()
    {
        var products = _service.GetAllProducts();
        return Ok(products);
    }
    [HttpGet("getById")]
    public IActionResult GetById([FromBody] Key key)
    {
        try
        {
            var product = _service.GetProductById(key);
            return Ok(product);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e.Message);
        }        
    }

    [HttpPost]
    public IActionResult CreateProduct([FromBody] ProductCreateReq request)
    {
        try
        {
            var product = _service.CreateProduct(request);   
            return Ok("Create successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e.Message);
        }
    }
    [HttpPut]
    public IActionResult UpdaeProduct([FromBody] ProductUpdateReq request)
    {
        try
        {
            var product = _service.UpdateProduct(request);   
            return Ok("Update successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e.Message);
        }
    }
    [HttpDelete]
    public IActionResult DeleteProduct([FromBody] Key request)
    {
        try
        {
            var product = _service.DeleteProduct(request);   
            return Ok("Delete successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e.Message);
        }
    }
}