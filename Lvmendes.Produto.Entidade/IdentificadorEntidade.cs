using System.ComponentModel.DataAnnotations;

namespace Lvmendes.Produtos.Entidade
{
    public class IdentificadorEntidade
    {
        [Key]
        public Int64  Id { get; set; }
        private DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}