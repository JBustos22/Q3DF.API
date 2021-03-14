using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Q3DF.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecordsController : ControllerBase
    {
        private readonly ILogger<RecordsController> _logger;

        public RecordsController(ILogger<RecordsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "This is an endpoint.";
        }
        // [HttpGet]
        // public DefragRecord Get()
        // {
        //     return new DefragRecord();
        // }
    }
}
