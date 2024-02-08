using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using salesapi.DataHandler;
using salesapi.Models;
using salesapi.QueryHelper;

namespace salesapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesController : ControllerBase
    {
       


    //getting all the json object from the datahandler
        [HttpGet]
        public IActionResult GetAll() 
        {
            var dataHandler = new JsonDataHandler();
            var data = dataHandler.GetSalesModels();

            if(data == null) {
                return StatusCode(500);
            }
            return Ok(data);
        }



        //getting the name of data by string
        
        [HttpGet("{name}")]
        public IActionResult GetByName([FromRoute] string name)
        {
             var dataHandler = new JsonDataHandler();
            var data = dataHandler.GetSalesModels();
            if(data == null) {
                return StatusCode(500);
            }
            
            var singleSale = data.FirstOrDefault(x => x.Name == name);

            if(singleSale == null) {

                return NotFound();
            }
            return Ok(singleSale);
        }
        
    }


}