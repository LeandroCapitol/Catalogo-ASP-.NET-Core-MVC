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
    }
}
