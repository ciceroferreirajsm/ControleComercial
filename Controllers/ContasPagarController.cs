using ControleComercial.Models;
using Microsoft.AspNetCore.Mvc;
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
            var contas = _contasPagarServico.ObterContasAPagar();

            return View(contas);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(ContasPagar contasPagar)
        {
            _contasPagarServico.InserirContasPagas(contasPagar);
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int id)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
