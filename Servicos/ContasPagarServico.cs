using ControleComercial.Interfaces;
using ControleComercial.Models;

namespace ControleComercial.Servicos
{
    public class ContasPagarServico : IContasPagarServico
    {
        private readonly IContasPagarRepositorio _contasPagarRepositorio;
        public ContasPagarServico(IContasPagarRepositorio contasPagarRepositorio)
        {
            _contasPagarRepositorio = contasPagarRepositorio;
        }
        public void InserirContasPagas(ContasPagar contasPagar)
        {
            _contasPagarRepositorio.InserirContasPagas(contasPagar);
        }
    }
}
