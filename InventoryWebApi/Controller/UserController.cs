using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryLib.Constant;
using InventoryLib.DataResponse;
using InventoryLib.Interface;
using InventoryLib.Interface.IService;
using InventoryLib.Models;
using InventoryLib.Models.Request.User;
using InventoryLib.Models.Response.User;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace InventoryWebApi.Controller
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService<UserResponse> _service;

        public UserController(IUserService<UserResponse> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var data = _service.ReadAll();
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("getById")]
        public IActionResult Read([FromBody] UserRequest request)
        {
            try
            {
                var data = _service.Read(request);
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return NotFound(Response<string>.NotFound("Incorrect username or password."));
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

