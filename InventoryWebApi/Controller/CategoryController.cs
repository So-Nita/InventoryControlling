using InventoryLib.Constant;
using InventoryLib.Interface;
using InventoryLib.Models.Request.Category;
using InventoryLib.Services;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InventoryWebApi.Controller;

[ApiController][Route("api/category")]

public class CategoryController : ControllerBase
{
    private readonly ICategoryService _service;

    public CategoryController(ICategoryService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        try
        {
            var data = _service.ReadAll();
            return Ok(data);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public IActionResult CreateCategory([FromBody] CategoryCreateReq req)
    {
        try
        {
            var data = _service.Create(req);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("getById")]
    public IActionResult GetCategoryById([FromForm] Key key)
    {
        try
        {
            var data = _service.Read(key);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }catch(Exception ex)
        {
            Console.WriteLine(ex);
            return BadRequest(ex);
        }
    }

    [HttpPut]
    public IActionResult Update([FromBody] CategoryUpdateReq req)
    {
        try
        {
            var data = _service.Update(req);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return BadRequest(data);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return BadRequest(ex);
        }
    }

    [HttpDelete]
    public IActionResult Delete([FromBody] Key key)
    {
        try
        {
            var data = _service.Delete(key.Id!);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return BadRequest(data);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return BadRequest(ex);
        }
    }
}