using Microsoft.AspNetCore.Mvc;

namespace CookingRecipes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
