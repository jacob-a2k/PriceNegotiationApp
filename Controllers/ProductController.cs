using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PriceNegotiationApp.Entities;

namespace PriceNegotiationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static private List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Bike", Price = 99.99m },
            new Product { Id = 2, Name = "Scooter", Price = 59.59m },
            new Product { Id = 3, Name = "Skateboard", Price = 49.49m }
        };

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product is null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct(Product newProduct)
        {
            if (newProduct is null) return BadRequest();

            newProduct.Id = products.Max(p => p.Id) + 1;
            products.Add(newProduct);

            return CreatedAtAction(nameof(GetProductById), new { Id = newProduct.Id }, newProduct);
        }
    }
}
