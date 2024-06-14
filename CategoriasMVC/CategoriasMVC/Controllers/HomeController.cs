using Microsoft.AspNetCore.Mvc;

namespace CategoriasMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
