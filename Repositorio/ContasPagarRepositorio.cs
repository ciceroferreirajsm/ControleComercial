using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StackExchange.Profiling;
using StackExchange.Profiling.Data;
using System.Data;

namespace ControleComercial.Repositorio
{
    public class ContasPagarRepositorio
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public ContasPagarRepositorio(IConfiguration configuration,
            IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public void AdicionarContasPagar()
        {
            string query = string.Empty;
            var param = new DynamicParameters();

            query =
                     "SELECT * " +
                     "FROM dbo.ContasAPagar ";
            param.AddDynamicParams
                (new
                {
                    @Dados = ""
                }
                );

            using (var db = GetConnection())
            {
                db.Open();
                db.Execute(query, param);
            }
        }

        private IDbConnection GetConnection()
        {
            var connection = new SqlConnection(_configuration.GetConnectionString("ControleComercial"));

            if (_environment.IsDevelopment())
                return new ProfiledDbConnection(connection, MiniProfiler.Current);

            return connection;
        }
    }
}
