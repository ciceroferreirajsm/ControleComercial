using ControleComercial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControleComercial.Controllers
{
    public class ContasPagarController : Controller
    {
        private readonly ILogger<ContasPagarController> _logger;

        public ContasPagarController(ILogger<ContasPagarController> logger)
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
