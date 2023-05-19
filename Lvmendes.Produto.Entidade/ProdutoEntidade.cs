
using System.ComponentModel.DataAnnotations.Schema;

namespace Lvmendes.Produtos.Entidade
{

    [Table("Tb_Produto")]
    public class ProdutoEntidade : IdentificadorEntidade
    {
        public string Cod_Produto { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal PorcentagemLucro { get; set; }
    }
}
