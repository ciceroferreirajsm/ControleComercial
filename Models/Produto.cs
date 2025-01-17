using System;

namespace ControleComercial.Models
{
    public class Produto
    {
        public int Id { get; set; }                 // ID do produto
        public string Nome { get; set; }             // Nome do produto
        public string Descricao { get; set; }        // Descrição do produto
        public decimal Preco { get; set; }           // Preço do produto
        public int QuantidadeEstoque { get; set; }   // Quantidade disponível em estoque
        public string Categoria { get; set; }        // Categoria do produto
        public DateTime DataCriacao { get; set; }    // Data de criação do produto
        public DateTime DataUltimaAlteracao { get; set; } // Data da última alteração

        // Construtor padrão
        public Produto()
        {
            DataCriacao = DateTime.Now;              // Atribui a data e hora atuais
            DataUltimaAlteracao = DateTime.Now;      // Atribui a data e hora atuais
        }
    }
}
