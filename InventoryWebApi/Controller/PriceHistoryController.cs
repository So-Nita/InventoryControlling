using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryLib.Constant;
using InventoryLib.Interface;
using InventoryLib.Interface.IService;
using InventoryLib.Models;
using InventoryLib.Models.Response;
using Microsoft.AspNetCore.Mvc;


namespace InventoryWebApi.Controller
{
    [ApiController][Route("api/priceHistory")]

    public class PriceHistoryController : ControllerBase
    {
        private readonly IPriceHistoryService<PriceHistoryResponse> _service;

        public PriceHistoryController(IPriceHistoryService<PriceHistoryResponse> service)
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
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("getByProductId")]
        public IActionResult GetByProductId([FromBody] Key key)
        {
            try
            {
                var data = _service.Read(key.Id!);
                if(data.Status != (int)ResponseStatusType.Success)
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

