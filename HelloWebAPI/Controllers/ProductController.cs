using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWebAPI.Models;
using HelloWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductRepository _repo;

        public ProductController()
        {
            _repo = new ProductRepository();
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return StatusCode(StatusCodes.Status400BadRequest, "A bad request");
        }

        [HttpGet]
        public ActionResult Details()
        {
            return Ok("Details Page");
        }

        [HttpGet("catalog")]
        public ActionResult Catalog()
        {
            return Ok(_repo.GetProducts());
        }

        [HttpGet("catalog/{id}")]
        public ActionResult Catalog(int id)
        {
            
            var product = _repo.GetProduct(id);
            if (product == null)
                return NotFound("Product not found");
            return Ok(product);
        }

       




    }
}