using Microsoft.AspNetCore.Mvc;

namespace BurgerSignalR.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
