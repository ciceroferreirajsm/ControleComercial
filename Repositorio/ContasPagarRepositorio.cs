using ControleComercial.Interfaces;
using ControleComercial.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ControleComercial.Repositorio
{
    public class ContasPagarRepositorio : IContasPagarRepositorio
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;
        private readonly string ConnectionString;

        public ContasPagarRepositorio(IConfiguration configuration,
            IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
            ConnectionString = _configuration.GetConnectionString("ControleComercial");
        }

        public void InserirContasPagas(ContasPagar contasPagar)
        {
            string query = string.Empty;
            var param = new DynamicParameters();

            query = "INSERT INTO dbo.ContasAPagar (" +
                        "Descricao, Valor, DataVencimento, DataPagamento, Status, Fornecedor, Categoria, Observacoes, DataCriacao, DataUltimaAlteracao) " +
                    "VALUES (" +
                        "@Descricao, @Valor, @DataVencimento, @DataPagamento, @Status, @Fornecedor, @Categoria, @Observacoes, GETDATE(), GETDATE())";

            param.Add("@Descricao", contasPagar.Descricao);
            param.Add("@Valor", contasPagar.Valor);
            param.Add("@DataVencimento", contasPagar.DataVencimento);
            param.Add("@DataPagamento", contasPagar.DataPagamento);
            param.Add("@Status", contasPagar.Status);
            param.Add("@Fornecedor", contasPagar.Fornecedor);
            param.Add("@Categoria", contasPagar.Categoria);
            param.Add("@Observacoes", contasPagar.Observacoes);

            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                db.Execute(query, param);
            }
        }
        public List<ContasPagar> ObterContasAPagar()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                string query = "SELECT * FROM dbo.ContasAPagar";

                var contas = db.Query<ContasPagar>(query).ToList();
                return contas;
            }
        }

    }
}
