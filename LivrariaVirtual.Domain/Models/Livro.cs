namespace LivrariaVirtual.Domain.Models;

public class Livro : Entity
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public DateTime Data { get; set; }
    public string Autor { get; set; }
    public decimal Preco { get; set; }
    public string Idioma { get; set; }
}
