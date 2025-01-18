using ControleComercial.Models;

namespace ControleComercial.Interfaces
{
    public interface IContasPagarRepositorio
    {
        void InserirContasPagas(ContasPagar contasPagar);
        List<ContasPagar> ObterContasAPagar();
    }
}
