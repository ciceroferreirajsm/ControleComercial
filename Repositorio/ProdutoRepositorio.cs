using ControleComercial.Interfaces;
using ControleComercial.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ControleComercial.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;
        private readonly string ConnectionString;

        public ProdutoRepositorio(IConfiguration configuration,
            IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
            ConnectionString = _configuration.GetConnectionString("ControleComercial");
        }

        public void InserirProduto(Produto produto)
        {
            string query = string.Empty;
            var param = new DynamicParameters();

            query = "INSERT INTO dbo.Produto (" +
                        "Nome, Descricao, Preco, QuantidadeEstoque, Categoria, DataCriacao, DataUltimaAlteracao) " +
                    "VALUES (" +
                        "@Nome, @Descricao, @Preco, @QuantidadeEstoque, @Categoria, GETDATE(), GETDATE())";

            param.Add("@Nome", produto.Nome);
            param.Add("@Descricao", produto.Descricao);
            param.Add("@Preco", produto.Preco);
            param.Add("@QuantidadeEstoque", produto.QuantidadeEstoque);
            param.Add("@Categoria", produto.Categoria);

            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                db.Execute(query, param);
            }
        }

        public List<Produto> ObterProdutos()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                string query = "SELECT * FROM dbo.Produto";

                var Produtos = db.Query<Produto>(query).ToList();
                return Produtos;
            }
        }
    }
}
