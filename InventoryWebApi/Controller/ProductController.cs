using InventoryLib.Constant;
using InventoryLib.Interface;
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
        try
        {
            var products = _service.ReadAll();
            if (products == null) { return BadRequest("Something went wrong."); }
            return Ok(products);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpPost("getById")]
    public IActionResult GetById([FromBody] Key key)
    {
        try
        {
            var product = _service.Read(key);
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
            var data = _service.Create(request);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
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
            var data = _service.Update(request);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
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
            var product = _service.Delete(request.Id!);
            if (product.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(product);
            }
            return Ok(product);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}