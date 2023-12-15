using AutoMapper;
using LivrariaVirtual.Business.ViewModels;
using LivrariaVirtual.Domain.Models;

namespace LivrariaVirtual.Configurations
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Livro, LivroViewModel>().ReverseMap();
            CreateMap<LivroCategoria, LivroCategoriaViewModel>().ReverseMap();
            CreateMap<LivroAvaliacao, LivroAvaliacao>().ReverseMap();
            CreateMap<LivroAutor, LivroAutorViewModel>().ReverseMap();
        }           
    }
}
