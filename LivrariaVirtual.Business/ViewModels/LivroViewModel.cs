using System.ComponentModel.DataAnnotations;

namespace LivrariaVirtual.Business.ViewModels
{
    public class LivroViewModel : BaseViewModel
    {
        public string? Titulo { get; set; }
        public string? Genero { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Data { get; set; }

        public string? Autor { get; set; }
        public decimal? Preco { get; set; }
        public string? Idioma { get; set; }
    }
}
