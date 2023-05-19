using Lvmendes.Produtos.Entidade;
using Microsoft.EntityFrameworkCore;
namespace Lvmendes.Produtos.Entidade
{
    public class ProdutoContext : DbContext
    {       

        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {

        }

        public DbSet<ProdutoEntidade> Produtos { get; set; }


    }
}