using CWebApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace CWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InMemoryController : ControllerBase
    {

        private readonly IInMemoryService _inMemoryService;

        public InMemoryController(IInMemoryService inMemoryService)
        {
            _inMemoryService = inMemoryService;
        }

        [HttpGet("Get-number-details")]
        public IActionResult GetNumberDetails(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                ModelState.AddModelError("Number", "Number cannot be empty");
                return BadRequest(ModelState);
            }
            
            if(number.Length < 13 || number.Length > 13)
            {
                ModelState.AddModelError("Number", "Number lenght must be 13");
                return BadRequest(ModelState);
            };

            if(!BigInteger.TryParse(number, out BigInteger _))
            {
                ModelState.AddModelError("Number", "Number must be digit");
                return BadRequest(ModelState);
            }

            var response = _inMemoryService.GetNumberDetails(number);
            if (response == null) return NotFound(new { status = "Not found", Description = "Country code not found", Data = response });

            return Ok(new { status = "successful", Description = "Country details retrieved successfully", Data = response });
        }
    }
}
