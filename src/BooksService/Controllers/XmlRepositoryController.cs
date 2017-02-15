using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksService.Interfaces;
using BooksService.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BooksService.Controllers
{
    [Route("api/[controller]")]
    public class XmlRepositoryController : Controller
    {
        private readonly IXmlRepository _xmlRepository;
        public XmlRepositoryController(IXmlRepository xmlRepository)
        {
            _xmlRepository = xmlRepository;
        }
        // GET: api/values
        [HttpGet, Produces("application/xml")]
        public async Task<string> GetCatalogAsync()
        {
            return await _xmlRepository.GetCatalogAsync();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
