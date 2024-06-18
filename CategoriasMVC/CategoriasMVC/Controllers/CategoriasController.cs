using CategoriasMVC.Models;
using CategoriasMVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CategoriasMVC.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaServices _categoriaServices;

        public CategoriasController(ICategoriaServices categoriaServices)
        {
            _categoriaServices = categoriaServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaViewModel>>> Index()
        {
            var result = await _categoriaServices.GetCategorias();

            if (result is null)
                return View("Error");

            return View(result);
        }

        [HttpGet]
        public IActionResult CriarNovaCategoria()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaViewModel>> CriarNovaCategoria(CategoriaViewModel categoriaVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoriaServices.CriarCategoria(categoriaVM);

                if (result != null)
                    return RedirectToAction(nameof(Index));
            }
            ViewBag.Erro = "Erro ao criar Categoria";
            return View(categoriaVM);
        }

        [HttpGet]
        public async Task<IActionResult> AtualizarCategoria(int id)
        {
            var result = await _categoriaServices.GetCategoriaPorId(id);

            if (result is null)
                return View("Error");

            return View(result);
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaViewModel>> AtualizarCategoria(int id,
            CategoriaViewModel categoriaVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoriaServices.AtualizarCategoria(id,categoriaVM);

                if (result)
                    return RedirectToAction(nameof(Index));
            }
            ViewBag.Erro = "Erro ao atualizar Categoria";
            return View(categoriaVM);
        }
    }
}