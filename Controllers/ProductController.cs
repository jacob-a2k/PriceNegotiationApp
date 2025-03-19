using Microsoft.AspNetCore.Mvc;

namespace PriceNegotiationApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
