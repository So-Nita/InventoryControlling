using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryLib.Constant;
using InventoryLib.Interface;
using InventoryLib.Services;
using Microsoft.AspNetCore.Mvc;


namespace InventoryWebApi.Controller
{
    [ApiController] [Route("api/stocking")]

    public class StockingController : ControllerBase
    {
        private readonly IStockingService _service;

        public StockingController(IStockingService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ReadAll()
        {
            var data = _service.ReadAll();
            if(data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpGet]
        public IActionResult Create([FromBody] StockingCreateReq req)
        {
            var data = _service.Create(req);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpGet]
        public IActionResult GetById(Key req)
        {
            var data = _service.Read(req);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Update([FromBody] StockingUpdateReq req)
        {
            var data = _service.Update(req);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpDelete]
        public IActionResult Delete(Key key)
        {
            var data = _service.Delete(key.Id!);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}

