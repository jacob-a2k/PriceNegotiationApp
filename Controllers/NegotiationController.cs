using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PriceNegotiationApp.Entities;
using PriceNegotiationApp.Services;

namespace PriceNegotiationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegotiationController : ControllerBase
    {
        private readonly NegotiationService _negotiationService;

        public NegotiationController(NegotiationService negotiationService)
        {
            _negotiationService = negotiationService;
        }

        static private List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Bike", Price = 99.99m },
            new Product { Id = 2, Name = "Scooter", Price = 59.59m },
            new Product { Id = 3, Name = "Skateboard", Price = 49.49m }
        };

        [HttpPost("bid")]
        public ActionResult<Product> UpdatePrice([FromBody]Product product)
        {
            ////////////////////////////////////////////////////
            ////////////////////////////////////////////////////
            ////////////////////////////////////////////////////
            return Ok();
        }
    }
}
