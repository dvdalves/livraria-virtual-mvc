using AutoMapper;
using LivrariaVirtual.Business.Interface;
using LivrariaVirtual.Business.ViewModels;
using LivrariaVirtual.Data.Interface;
using LivrariaVirtual.Domain.Models;

namespace AdmCrmProver.Business.Service
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IMapper _mapper;

        public LivroService(ILivroRepository livroRepository, IMapper mapper)
        {
            _livroRepository = livroRepository;
            _mapper = mapper;
        }

        public async Task<LivroViewModel> Incluir(LivroViewModel livroViewModel)
        {
            var livro = _mapper.Map<Livro>(livroViewModel);
            var livroAdicionado = await _livroRepository.Adicionar(livro);
            var livroAdicionadoViewModel = _mapper.Map<LivroViewModel>(livroAdicionado);

            return livroAdicionadoViewModel;
        }


        public async Task<LivroViewModel> Alterar(LivroViewModel livroViewModel)
        {
            var livroExistente = await _livroRepository.ObterPorId(livroViewModel.Id);

            if (livroExistente == null)
            {
                return null;
            }

            livroExistente = _mapper.Map(livroViewModel, livroExistente);

            var livroAlterado = await _livroRepository.Atualizar(livroExistente);

            var livroAlteradoViewModel = _mapper.Map<LivroViewModel>(livroAlterado);

            return livroAlteradoViewModel;
        }

        public async Task<LivroViewModel> Excluir(Guid id)
        {
            var livroExistente = await _livroRepository.ObterPorId(id);

            if (livroExistente == null)
            {
                return null;
            }

            await _livroRepository.Remover(id);

            var livroExcluidoViewModel = _mapper.Map<LivroViewModel>(livroExistente);

            return livroExcluidoViewModel;
        }

        public async Task<IEnumerable<LivroViewModel>> ObterTodos()
        {
            var livros = await _livroRepository.ObterTodos();

            var livrosViewModel = _mapper.Map<IEnumerable<LivroViewModel>>(livros);

            return livrosViewModel;
        }

        public async Task<LivroViewModel> RetornaPorId(Guid id)
        {
            var livro = await _livroRepository.ObterPorId(id);

            if (livro == null)
            {
                return null;
            }

            var livroViewModel = _mapper.Map<LivroViewModel>(livro);

            return livroViewModel;
        }
    }
}