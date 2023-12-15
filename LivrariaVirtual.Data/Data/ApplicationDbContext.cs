using LivrariaVirtual.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LivrariaVirtual.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<LivroAutor> LivrosAutores { get; set; }
        public DbSet<LivroAvaliacao> LivrosAvalicoes { get; set; }
        public DbSet<LivroCategoria> LivrosCategorias { get; set; }
    }
}