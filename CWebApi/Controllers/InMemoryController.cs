using CWebApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
                return BadRequest();

            var response = _inMemoryService.GetNumberDetails(number);

            return Ok(response);
        }
    }
}
