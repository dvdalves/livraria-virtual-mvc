namespace LivrariaVirtual.Domain.Models
{
    public class Livro : Entity
    {
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public DateOnly Data { get; set; }
    }
}
