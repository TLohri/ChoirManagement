using ChoirManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChoirManagement.Controllers
{
    public class ChoirController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ChoirController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Choirs()
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