using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using salesapi.DataHandler;
using salesapi.Mapper;

namespace salesapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RevenueController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetAll() 
        {
            var dataHandler = new JsonDataHandler();
            var allOrders = dataHandler.GetOrderModels();

            if(allOrders == null) {
                return StatusCode(500);
            }

            return Ok(allOrders);
        }

        [HttpGet("{orderNumber}")]
        public IActionResult GetByName([FromRoute] string orderNumber)
        {
            var dataHandler = new JsonDataHandler();
            var data = dataHandler.GetOrderModels();
            if(data == null) {
                return StatusCode(500);
            }
            
            var singleOrder = data.FirstOrDefault(x => x.OrderNumber == orderNumber);

            if(singleOrder == null) {
                return NotFound();
            }
            return Ok(singleOrder);
        }

        
        [HttpGet("/api/noRevenue")]
        public IActionResult GetOrderWithRevenue()
        {
            var dataHandler = new JsonDataHandler();
            var orders = dataHandler.GetOrderModels();

            if(orders == null) 
            {
                return NotFound();
            }

            var ordersDto = orders.Select(O => O.ToOrderDtoNoRevenue());

            return Ok(ordersDto);
        }

        
    }
}