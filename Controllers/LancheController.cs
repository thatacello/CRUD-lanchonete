using Lanches_Prof_Macoratti.Repositories;
using Lanches_Prof_Macoratti.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lanches_Prof_Macoratti.Controllers
{
    public class LancheController : Controller
    {
        public ILancheRepository _lancheRepository { get; }
        public ICategoriaRepository _categoriaRepository { get; }
        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }
        public IActionResult List()
        {
             ViewBag.Lanche = "Lanches"; // outra forma de passar informação para a view
             ViewData["Categoria"] = "Categoria"; // outra forma

            // var lanches = _lancheRepository.Lanches;
            // return View(lanches);

            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lancheListViewModel);
        }
    }
}