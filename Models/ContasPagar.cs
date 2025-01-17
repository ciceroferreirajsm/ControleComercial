using System;

namespace ControleComercial.Models
{
    public class ContasPagar
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal? Valor { get; set; }

        public DateTime? DataVencimento { get; set; }

        public DateTime? DataPagamento { get; set; }

        public string Status { get; set; }

        public string Fornecedor { get; set; }

        public string Categoria { get; set; }

        public string Observacoes { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataUltimaAlteracao { get; set; }

        public ContasPagar()
        {
            DataCriacao = DateTime.Now;
            DataUltimaAlteracao = DateTime.Now;
        }
    }
}
