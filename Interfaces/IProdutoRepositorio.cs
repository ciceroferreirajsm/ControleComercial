using ControleComercial.Models;

namespace ControleComercial.Interfaces
{
    public interface IProdutoRepositorio
    {
        void InserirProduto(Produto contasPagar);
        List<Produto> ObterProdutos();
    }
}
