using ControleComercial.Models;
using Microsoft.AspNetCore.Mvc;
using ControleComercial.Interfaces;

namespace ControleComercial.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly IProdutoServico _ProdutoServico;

        public ProdutoController(ILogger<ProdutoController> logger, IProdutoServico ProdutoServico)
        {
            _logger = logger;
            _ProdutoServico = ProdutoServico;
        }

        public IActionResult Index()
        {
            var produtos = _ProdutoServico.ObterProdutos();

            return View(produtos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto Produto)
        {
            _ProdutoServico.InserirProduto(Produto);
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
