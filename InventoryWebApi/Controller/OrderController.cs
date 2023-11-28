using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryLib.Constant;
using InventoryLib.Interface;
using InventoryLib.Interface.IService;
using InventoryLib.Models;
using InventoryLib.Models.Request.Order;
using Microsoft.AspNetCore.Mvc;

namespace InventoryWebApi.Controller
{
    [ApiController][Route("api/order")]

    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
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
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("getById")]
        public IActionResult GetById([FromBody] Key id)
        {
            try
            {
                var data = _service.Read(id);
                if(data.Status != (int)ResponseStatusType.Success)
                {
                    return NotFound(data);
                }
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] OrderCreateReq req)
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
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] OrderUpdateReq req)
        {
            try
            {
                var data = _service.Update(req);
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch
            {
                return BadRequest();
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
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("deletOrderDetails")]
        public IActionResult DeleteOrderDetails([FromBody] List<Key> keys)
        {
            try
            {
                var data = _service.DeleteDetails(keys);
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}

