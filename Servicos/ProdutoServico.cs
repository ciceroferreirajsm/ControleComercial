using ControleComercial.Interfaces;
using ControleComercial.Models;

namespace ControleComercial.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _ProdutoRepositorio;
        public ProdutoServico(IProdutoRepositorio ProdutoRepositorio)
        {
            _ProdutoRepositorio = ProdutoRepositorio;
        }
        public void InserirProduto(Produto Produto)
        {
            _ProdutoRepositorio.InserirProduto(Produto);
        }

        public List<Produto> ObterProdutos()
        {
            return _ProdutoRepositorio.ObterProdutos();
        }
    }
}
