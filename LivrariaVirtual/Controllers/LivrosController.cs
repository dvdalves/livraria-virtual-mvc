using LivrariaVirtual.Business.Interface;
using LivrariaVirtual.Business.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaVirtual.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ILivroService _livroService;

        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _livroService.ObterTodos());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LivroViewModel livroViewModel)
        {
            var resultado = await _livroService.Incluir(livroViewModel);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {

            var resultado = await _livroService.RetornaPorId(id);

            return View(resultado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, LivroViewModel livroViewModel)
        {
            await _livroService.Alterar(livroViewModel);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {

            var livros = await _livroService.RetornaPorId(id);

            return View(livros);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _livroService.Excluir(id);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var livros = await _livroService.RetornaPorId(id);

            return View(livros);
        }
    }
}
