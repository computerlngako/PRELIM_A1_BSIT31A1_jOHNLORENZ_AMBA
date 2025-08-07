using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRELIM_A1_BSIT31A1_jOHN_LORENZ_AMBA.Models;

namespace PRELIM_A1_BSIT31A1_jOHN_LORENZ_AMBA.Controllers
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
            return View();
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
