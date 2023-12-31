﻿using InventoryLib.Constant;
using InventoryLib.Interface;
using InventoryLib.Services;
using Microsoft.AspNetCore.Mvc;


namespace InventoryWebApi.Controller
{
    [ApiController][Route("api/stocking")]

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
        [HttpGet("readByProduct")]
        public IActionResult ReadAllByProduct()
        {
            var data = _service.ReadAllByProudct();
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Create([FromBody] StockingCreateReq req)
        {
            var data = _service.Create(req);
            if (data.Status != (int)ResponseStatusType.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost("getById")]
        public IActionResult GetById(Key req)
        {
            try
            {
                var data = _service.Read(req);
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
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

