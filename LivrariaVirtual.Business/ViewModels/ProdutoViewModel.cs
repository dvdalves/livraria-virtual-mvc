namespace LivrariaVirtual.Business.ViewModels
{
    public class Produtos : BaseViewModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Imagem { get; set; }
        public string ImagemUrl { get; set; }
    }
}
