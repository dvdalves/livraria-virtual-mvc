using LivrariaVirtual.Business.ViewModels;

namespace LivrariaVirtual.Business.Interface
{
    public interface ILivroService
    {
        Task<IEnumerable<LivroViewModel>> ObterTodos();
        Task<LivroViewModel> RetornaPorId(Guid id);
        Task<LivroViewModel> Incluir(LivroViewModel livroViewModel);
        Task<LivroViewModel> Alterar(LivroViewModel livroViewModel);
        Task<LivroViewModel> Excluir(Guid id);
    }
}
