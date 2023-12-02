using LivrariaVirtual.Data.Data;
using LivrariaVirtual.Data.Interface;
using LivrariaVirtual.Domain.Models;
using System.Data.Entity;

namespace LivrariaVirtual.Data.Repository
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        public LivroRepository(ApplicationDbContext context) : base(context) { }
    }
}
