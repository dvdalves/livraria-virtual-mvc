namespace LivrariaVirtual.Business.ViewModels
{
    public class BaseViewModel
    {
        public Guid Id { get; set; }
        public string MensagemErro { get; set; }
        public bool Sucesso { get; set; }       

        public BaseViewModel()
        {
            Id = Guid.NewGuid();
        }

        public void DefinirErro(string mensagem)
        {
            MensagemErro = mensagem;
            Sucesso = false;
        }

        public void DefinirSucesso()
        {
            MensagemErro = string.Empty;
            Sucesso = true;
        }
    }
}