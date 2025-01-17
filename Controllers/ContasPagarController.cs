using ControleComercial.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StackExchange.Profiling.Data;
using StackExchange.Profiling;
using System.Data;
using System.Diagnostics;
using ControleComercial.Interfaces;

namespace ControleComercial.Controllers
{
    public class ContasPagarController : Controller
    {
        private readonly ILogger<ContasPagarController> _logger;
        private readonly IContasPagarServico _contasPagarServico;

        public ContasPagarController(ILogger<ContasPagarController> logger, IContasPagarServico contasPagarServico)
        {
            _logger = logger;
            _contasPagarServico = contasPagarServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(ContasPagar contasPagar)
        {
            _contasPagarServico.InserirContasPagas(contasPagar);
            return View();
        }
    }
}
