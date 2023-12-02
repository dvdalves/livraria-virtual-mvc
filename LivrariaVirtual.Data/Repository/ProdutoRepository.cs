using LivrariaVirtual.Data.Data;
using LivrariaVirtual.Data.Interface;
using LivrariaVirtual.Domain.Models;

namespace LivrariaVirtual.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context) { }
    }
}
