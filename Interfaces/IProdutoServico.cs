using ControleComercial.Models;

namespace ControleComercial.Interfaces
{
    public interface IProdutoServico
    {
        void InserirProduto(Produto contasPagar);
        List<Produto> ObterProdutos();
    }
}
