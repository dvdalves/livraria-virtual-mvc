using LivrariaVirtual.Business.Services;
using LivrariaVirtual.Business.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaVirtual.Controllers
{
    public class LivrosController : Controller
    {
        private readonly LivroService _livroService;

        public LivrosController(LivroService livroService)
        {
            _livroService = livroService;
        }

        public async Task Index(LivroViewModel livroViewModel)
        {

        }

        public async Task Create(LivroViewModel livroViewModel)
        {

        }

        public async Task Edit(LivroViewModel livroViewModel)
        {

        }

        public async Task Update(LivroViewModel livroViewModel)
        {

        }

        public async Task Delete(LivroViewModel livroViewModel)
        {

        }     
    }
}
