using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductExpiryCalculator.Models;
using System.Diagnostics;

namespace ProductExpiryCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var productText = System.IO.File.ReadAllText("config/products.json");
            return View(JsonConvert.DeserializeObject<List<Product>>(productText));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}