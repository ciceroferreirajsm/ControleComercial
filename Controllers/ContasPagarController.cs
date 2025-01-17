using ControleComercial.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StackExchange.Profiling.Data;
using StackExchange.Profiling;
using System.Data;
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
            AdicionarContasPagar();
            return View();
        }

        public void AdicionarContasPagar()
        {
            string query = string.Empty;
            var param = new DynamicParameters();

            query =
                     "SELECT * " +
                     "FROM dbo.Regioes ";
            param.AddDynamicParams
                (new
                {
                    @Dados = ""
                }
                );

            using (var db = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=ControleComercial;Trusted_Connection=True;"))
            {
                db.Open();
                db.Execute(query, param);
            }
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
