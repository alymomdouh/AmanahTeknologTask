using AmanahTeknologTask.Dto;
using AmanahTeknologTask.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmanahTeknologTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = service.GetList();
            return Ok(result);
        }
        // GET: api/<ProductController>
        [HttpPost]
        public ActionResult Add([FromBody] AddProduct product)
        {
            return Ok(service.Insert(product));
        }
    }
}
