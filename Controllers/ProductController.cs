using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PriceNegotiationApp.Entities;
using PriceNegotiationApp.Services;

namespace PriceNegotiationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(ProductService service) : ControllerBase
    {
        private readonly ProductService _service = service;
        
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return Ok(_service.GetProducts());
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _service.GetProduct(id);
            if (product is null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct(Product newProduct)
        {
            var isCreated = _service.CreateProduct(newProduct);
            if (!isCreated) return BadRequest();

            return CreatedAtAction(nameof(_service.CreateProduct), new { Id = newProduct.Id }, newProduct);
        }
    }
}
