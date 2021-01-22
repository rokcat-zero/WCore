using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcceptController : ControllerBase
    {
        private readonly ServiceContext _serviceContext;
        private readonly ILogger<AcceptController> _logger;

        public AcceptController(ServiceContext serviceContext, ILogger<AcceptController> logger)
        {
            _logger = logger;
            _serviceContext = serviceContext;
        }
        

        [HttpPost]
        public void Post([FromBody] UserAccepted value) 
        {
            _serviceContext.UserAccepteds.Add(value);
            _serviceContext.SaveChanges();
        }

    }
}
