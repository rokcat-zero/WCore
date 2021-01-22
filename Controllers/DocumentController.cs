using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {

        private readonly ServiceContext _serviceContext;
        private readonly ILogger<DocumentController> _logger;

        public DocumentController(ServiceContext serviceContext, ILogger<DocumentController> logger)
        {
            _logger = logger;
            _serviceContext = serviceContext;
        }

        [HttpGet]
        public string Get()
        {
            return new string(".|.");
        }

        // GET api/<Document>/5
        [HttpGet("{id}")]
        public string Get(int id, string doctype)
        {
            var docText = _serviceContext.Documents
                .Where(c => c.ProjectId == id)
                .Where(c=>c.TypeDocumentId == Convert.ToInt32(doctype))
                .Select(c => c.ContentText).FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(docText))
            {
                return docText;
            }
            return string.Empty;
        }

        // POST api/<Document>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Document>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Document>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
